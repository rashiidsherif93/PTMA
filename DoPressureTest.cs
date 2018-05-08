using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using ESI_USB_API_CS_Example;
using KProxAPI;
using Operators;
using KROHNERecordDatabase;
using MySql.Data.MySqlClient;
using System.IO.Ports;
namespace PTMA
{
    public partial class DoPressureTest : Form
    {
        //Dummy destination  @"\\gbd1prod\ProdEng\Projects\Pressure Testing automation\LOG.txt";
        //Actual destination @"\\gbd1prod\Flowrigs\Production\pressure monitoring\Results\LOG.txt";
        string szdestinationLogFile = @"\\gbd1prod\ProdEng\Projects\Pressure Testing automation\LOG.txt";
        //PTMBox A = new PTMBox();
        WarningScreen Warning = new WarningScreen();
        uint u8Read;
        Operators.Operators.OperatorRecord op;
        DBConnect dbData = new DBConnect();
        public static float fTemperature, fPressure;
        //int set;
        public static int iSensorUsed, iMinutes, iCount, iReturnCode, iSensorIndex = 0;
        string[] szTestLoggingArray = new string[17];
        string szData = "1111 \r\n";
        public static double dPressurereading;
        double dPressureRating, dOverPressureRating;
        double dDeltaMinPass, dDeltaMeasuredPressureDrop;
        double dFirstMainMeasurement;
        double dSliderValue=0;
        List<double> double_ListPressure_InBarlogSettle = new List<double>();
        List<double> double_ListPressure_InBarLogHold = new List<double>();
        List<double> double_ListTemperature_InCelsiusLog = new List<double>();
        List<double> double_ListOverPressure_InBar = new List<double>();
        bool bChamber, bTimecheck, bheatingjacketflag;
        public static bool  bDoor1Closed, bDoor2Closed, bDoor1Locked, bDoor2Locked;
        public static bool bReadPressureThreadFlag, bReleasePressureSensor;
        public static bool bReadRFIDThreadFlag;
        public static bool bSettleThreadFlag, bSettleTimerEndFlag;
        public static bool bMainThreadFlag,bMainTimerEndFlag;
        bool bBothDoorsClosedFlag;
        int iTestStage = 1;
        int SensorCount;
        DateTime DateTimeObj_endtime;
        DateTime DateTimeObj_FormLoad;
        public static TextBox TextBoxSettings = new TextBox();



        public DoPressureTest()
        {
            InitializeComponent();
        }

        private void DoPressureTest_Load(object sender, EventArgs e)
        {

            DisplayInformationTestTxtB.Text = "Scan RFID to begin";
            DisplayInformationTestTxtB.ForeColor = Color.Black;
            InformationLargeLabel.Text = "";
            InformationLargeLabel.ForeColor = Color.Black;

            DisplayOperatorName.Text = "Operator Name";
            DisplayOperatorName.ForeColor = Color.Black;

            PressureSensorAbsoluteGaugeReading_barTxtB.Text = "";
            DisplayTotalPressureDropTxtB.Text = "";

            LabelSensorOK.Text = "";

            TestPressureTxtB.Text = "";
            PressureSensorInit();
            DisplaySolenoid1StatusLabel.Visible = true;
            DisplaySolenoid2StatusLabel.Visible = true;
            DisableButtons();
            passFailcriteria();
            bReadRFIDThreadFlag = true;          
            Thread WaitforValidOperatorThread = new Thread(WaitForValidOperator);
            WaitforValidOperatorThread.Name = "WaitForOperatorThread";
            WaitforValidOperatorThread.Start();
            TestTimeDropDown.SelectedIndex =0 ; //2 minute default
            if (ScanVE.bFlangeFound)
            {
                TestPressureTxtB.BackColor = Color.Red;
            }
            else
            {
                TestPressureTxtB.BackColor = Color.White;
            }
            //WaitforValidOperatorThread.Join();
        }
        private bool passFailcriteria()
        {
            bool bCriteriaMet = false;
            TestPressureTxtB.Text = ScanVE.szpTest;
            try
            {
                dPressureRating = Convert.ToDouble(TestPressureTxtB.Text);

                if (dPressureRating <= 100)
                {
                    dDeltaMinPass = -0.50;
                    dOverPressureRating = dPressureRating + 2.00;
                }
                else
                {
                    dDeltaMinPass = -1.00;
                    dOverPressureRating = dPressureRating + 4.00;
                }
            }
            catch
            {
                dPressureRating = 0;
            }

            bCriteriaMet = false;
            if (double.TryParse(TestPressureTxtB.Text, out dPressureRating))
            {
                if (dPressureRating <= 100)
                {
                    dDeltaMinPass = -0.50;
                    dOverPressureRating = dPressureRating + 2.00;
                }
                else
                {
                    dDeltaMinPass = -1.00;
                    dOverPressureRating = dPressureRating + 4.00;
                }

                bCriteriaMet = true;
            }
            else
            {
                dPressureRating = 0;

            }

            bCriteriaMet = false;
            dPressureRating = 0;
            double.TryParse(TestPressureTxtB.Text, out dPressureRating);

            if (dPressureRating !=  0)
            {
                if (dPressureRating <= 100)
                {
                    dDeltaMinPass = -0.50;
                    dOverPressureRating = dPressureRating + 2.00;
                }
                else
                {
                    dDeltaMinPass = -1.00;
                    dOverPressureRating = dPressureRating + 4.00;
                }
                bCriteriaMet = true;
            }

            return bCriteriaMet;
        }

        private void UpdateTestCriteria()
        {
            dPressureRating = Convert.ToDouble(TestPressureTxtB.Text);
            if ((dPressureRating <= 100))
            {
                dDeltaMinPass = -0.50;
                dOverPressureRating = dPressureRating + 2.00;
            }
            else if (dPressureRating >= 100)
            {
                dDeltaMinPass = -1.00;
                dOverPressureRating = dPressureRating + 4.00;
            }
        }

        private void DisplayPressureGaugesTimer_Tick(object sender, EventArgs e)
        {
            PressureSensorAbsoluteGaugeReading_barTxtB.Text = dPressurereading.ToString();
            if (bMainThreadFlag)
            {
                
                DisplayTotalPressureDropTxtB.Text = (dPressurereading-dFirstMainMeasurement).ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void BeginSettleTestBtn_Click_1(object sender, EventArgs e)
        {
            bBothDoorsClosedFlag = true;
            if(dPressureRating < 25)
            {
                
                DisplayInformationTestTxtB.Text = "Cannot continue,test pressure too low";
                DisplayInformationTestTxtB.ForeColor = Color.Red;
            }
            
            else if (dPressurereading < dPressureRating)
            {
                DisplayInformationTestTxtB.BackColor = Color.Empty;
                DisplayInformationTestTxtB.Text = "Cannot continue, gauge pressure too low";
                DisplayInformationTestTxtB.ForeColor = Color.Red;
            }
            
            else if(bBothDoorsClosedFlag)
            {
                BeginSettleTestBtn.Enabled = false;
                DisplayInformationTestTxtB.Text = "Settling Pressure...";
                DisplayInformationTestTxtB.ForeColor = Color.Empty;

                iMinutes = System.Convert.ToInt32(this.TestTimeDropDown.GetItemText(this.TestTimeDropDown.SelectedItem));
                var start = DateTime.UtcNow;
                DateTimeObj_endtime = start.AddSeconds(iMinutes);
                bSettleTimerEndFlag = false;
                bSettleThreadFlag = true;
                Thread BeginSettleThread = new Thread(SettleTest);
                BeginSettleThread.Name= "SettleThread";
                BeginSettleThread.Start();

            }
        }

        private void TestPressureTxtB_Leave(object sender, EventArgs e)
        { 
            UpdateTestCriteria();
        }

        private void BeginMainPressureTestBtn_Click(object sender, EventArgs e)
        {
            BeginMainPressureTestBtn.Enabled = false;
            DisplayInformationTestTxtB.Text = "Holding Pressure...";
            iMinutes = System.Convert.ToInt32(this.TestTimeDropDown.GetItemText(this.TestTimeDropDown.SelectedItem));
            var start = DateTime.UtcNow;
            DateTimeObj_endtime = start.AddSeconds(iMinutes);
            dFirstMainMeasurement = dPressurereading;
            bMainThreadFlag = true;
            Thread BeginMainThread = new Thread(HoldTest);
            BeginMainThread.Name = "Main Thread";
            BeginMainThread.Start();
        }

        private void DisableButtons()
        {
            BeginSettleTestBtn.Enabled = false;
            BeginMainPressureTestBtn.Enabled = false;
            FinishTestBtn.Enabled = false;
            RequestToEnterChamberBtn.Enabled = false;
            CancelTestBtn.Enabled = false;
        }

        private void FinishTestBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void DoPressureTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            bReadPressureThreadFlag = false;
            bSettleTimerEndFlag = false;
            bMainTimerEndFlag = false;
            API.ReleaseSensor(0);
            API.CleanUp();

    
        }

        private void CancelTestBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnableButtons()
        {
            BeginSettleTestBtn.Enabled = true;
            BeginMainPressureTestBtn.Enabled = true;
            FinishTestBtn.Enabled = true;
            RequestToEnterChamberBtn.Enabled = true;
            CancelTestBtn.Enabled = true;
        }
        private void PressureSensorInit()
        {
            int sensorCount = 0;
            iReturnCode = API.FindSensors(ref sensorCount);
            iReturnCode = API.IsSensorUsed(0, ref iSensorUsed);
            if (iSensorUsed == 1)
            {
                iReturnCode = API.ReleaseSensor(0);
            }

            if (iSensorUsed == 0)
            {
                iReturnCode = API.UseSensor(0);
            }

        }


        delegate void DisplayOperatorNameCallBack(string OperatorName);
        private void DisplayOperator(string OperatorName)
        {
            if(this.DisplayOperatorName.InvokeRequired)
            {
                DisplayOperatorNameCallBack d = new DisplayOperatorNameCallBack(DisplayOperator);
                this.Invoke(d, new object[] { OperatorName });
            }
            else
            {
                this.DisplayOperatorName.Text = OperatorName;
            }
        }
        private void WaitForValidOperator()
        {
            while(bReadRFIDThreadFlag)
            {
                u8Read = pcProx.GetCardID_User();
                while (u8Read > 0)
                {
                    u8Read = pcProx.GetCardID_User();
                    op = dbData.SelectOperatorFromID(u8Read);
                    if ((Operators.Operators.IsOperatorTrained(op, eEquipment.Pressure)))
                    {
                        DisplayOperator(op.Name);
                        DisplayOperatorName.ForeColor = Color.Green;
                        bReadRFIDThreadFlag = false;
                        ControlSettleButton(true);
                        bReadPressureThreadFlag = true;
                        Thread ESI_PressureSensorThread = new Thread(readPressure);
                        ESI_PressureSensorThread.Name ="ESI Thread";
                        ESI_PressureSensorThread.Start();
                    }
                    else
                    {
                        DisplayOperator("User Not Trained");
                        DisplayOperatorName.ForeColor = Color.Red;
                    }
                    u8Read = 0;
                }
            }
        }
        delegate void DisplayCountDownCallBack(string CountDown);
        private void DisplayCountDown(string CountDown)
        {
            if(this.DisplayCountDownTimeTxtB.InvokeRequired)
            {
                DisplayCountDownCallBack d = new DisplayCountDownCallBack(DisplayCountDown);
                this.Invoke(d, new object[] { CountDown });
            }
            else
            {
                this.DisplayCountDownTimeTxtB.Text = CountDown;
            }
        }

        delegate void DisplayInformationTxtCallBack(string Info,string Info_Large);
        private void DisplayInformationTxt(string Info,string Info_Large)
        {
            if (this.DisplayInformationTestTxtB.InvokeRequired)
            {
                DisplayInformationTxtCallBack d = new DisplayInformationTxtCallBack(DisplayInformationTxt);
                this.Invoke(d, new object[] { Info,Info_Large });
            }
            else
            {
                this.DisplayInformationTestTxtB.Text = Info;
                this.InformationLargeLabel.Text = Info_Large;
                if(Info_Large=="PASS")
                {
                    InformationLargeLabel.ForeColor = Color.Green;
                    DisplayInformationTestTxtB.ForeColor = Color.Green;
                }
                else if(Info_Large=="FAIL")
                {
                    InformationLargeLabel.ForeColor = Color.Red;
                    DisplayInformationTestTxtB.ForeColor = Color.Red;
                }
            }
        }

        private void BeginSettleTestBtn_Leave(object sender, EventArgs e)
        {
            dPressurereading = 60;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            dSliderValue = Convert.ToDouble(trackBar1.Value)*0.5;
        }

        private void SettleTest()
        {
            while(bSettleThreadFlag)
            {
                while (!bSettleTimerEndFlag)
                {
                    TimeSpan remainingTime = DateTimeObj_endtime - DateTime.UtcNow;
                    if (remainingTime < TimeSpan.Zero)
                    {
                        bSettleTimerEndFlag = true;
                        bSettleThreadFlag = false;
                        ControlHoldButton(true);
                        DisplayCountDown("Done");
                        DisplayInformationTxt("", "");
                    }
                    else
                    {
                        dFirstMainMeasurement = dPressurereading;
                        DisplayCountDown(remainingTime.ToString());
                    }
                    if(dPressurereading>dOverPressureRating)
                    {
                        //begin logging over pressurization
                    }
                    if(dPressurereading>=dPressureRating)
                    {
                        DisplayInformationTxt("Passing","");
                        DisplayInformationTestTxtB.ForeColor = Color.Green;
                    }
                    if(dPressurereading<dPressureRating)
                    {
                        DisplayCountDown("00:00:00");
                        DisplayInformationTxt("Fail,low pressure rating", "FAIL");
                        bSettleTimerEndFlag = true;
                        bSettleThreadFlag = false;
                        ControlSettleButton(true);
                    }
                    else
                    {
                        
                    }

                }
            }

           
        }
        private void HoldTest()
        {
            while (bMainThreadFlag)
            {
                while (!bMainTimerEndFlag)
                {
                    TimeSpan remainingTime = DateTimeObj_endtime - DateTime.UtcNow;
                    if (remainingTime < TimeSpan.Zero)
                    {
                        bMainTimerEndFlag = true;
                        bMainThreadFlag = false;
                        bReadPressureThreadFlag = false;
                        ControlHoldButton(false);
                        DisplayCountDown("Done");
                        DisplayInformationTxt("Test Finished","PASS");
                        ControlFinishButton(true);
                    }
                    else
                    {
                        DisplayCountDown(remainingTime.ToString());
                    }
                    if (dPressurereading > dOverPressureRating)
                    {
                        //begin logging over pressurization
                    }
                    if (dPressurereading<dPressureRating)
                    {
                        DisplayCountDown("00:00:00");
                        DisplayInformationTxt("Fail Low Pressure","FAIL");
                        bMainTimerEndFlag = true;
                        bMainThreadFlag = false;
                        bReadPressureThreadFlag = false;
                        ControlHoldButton(false);
                        ControlFinishButton(true);
                    } 
                    if(TotalPressureDrop_Fail())
                    {
                        DisplayCountDown("00:00:00");
                        DisplayInformationTxt("Fail,Unacceptable Leak","FAIL");
                        bMainTimerEndFlag = true;
                        bMainThreadFlag = false;
                        bReadPressureThreadFlag = false;
                        ControlHoldButton(false);
                        ControlFinishButton(true);
                    }
                }
            }
        }
        public bool TotalPressureDrop_Fail()
        {
            bool bTotalPressureDrop=false;
            dDeltaMeasuredPressureDrop = dPressurereading-dFirstMainMeasurement;
            if(dDeltaMeasuredPressureDrop<dDeltaMinPass)
            {
                bTotalPressureDrop = true;
            }
            return bTotalPressureDrop;


        }
        private void Finish()
        {

        }
        delegate void DisplayStatusOfSensorCallBack(string Status,string ErrorCode);
        private void DisplayStatusOfSensor(string Status, string ErrorCode)
        {
            if (this.LabelSensorOK.InvokeRequired)
            {
                try
                {
                    DisplayStatusOfSensorCallBack d = new DisplayStatusOfSensorCallBack(DisplayStatusOfSensor);
                    this.Invoke(d, new object[] { Status, ErrorCode });
                }
                catch(SystemException ex)
                {
                    //Cannot access a disposed object.\r\nObject name: 'DoPressureTest. Thread closes, command may get caught.
                }
            }
            else
            {
                this.LabelSensorOK.Text = Status + " "+ ErrorCode;
            }
        }
        void readPressure()
        {
            while (bReadPressureThreadFlag)
            {
                //pressure reading timer
                iReturnCode = API.ReadTemperature(iSensorIndex, 0, ref fTemperature);
                iReturnCode = API.Read(iSensorIndex, 0, 0, fTemperature, ref fPressure);
                if (dPressurereading < 0)
                {
                    dPressurereading = 0;
                }

                if (fPressure < 350.00F && fPressure >= 0.00F)
                {
                    dPressurereading = Math.Round(Convert.ToDouble(fPressure.ToString()), 2, MidpointRounding.AwayFromZero);
                    dPressurereading = dSliderValue;
                }
               if(iReturnCode<0)
                {
                     API.FindSensors(ref SensorCount);
                    if (SensorCount == 1 || dPressurereading>=350.00D)
                    {
                        API.ReleaseSensor(SensorCount - 1);
                        API.CleanUp();
                        iReturnCode = API.FindSensors(ref SensorCount);
                        API.UseSensor(SensorCount - 1);
                    }
                    else
                    {
                        DisplayStatusOfSensor("Error", iReturnCode.ToString());
                        LabelSensorOK.ForeColor = Color.Red;
                        API.ReleaseSensor(SensorCount - 1);
                        API.CleanUp();
                        iReturnCode = API.FindSensors(ref SensorCount);
                        API.UseSensor(SensorCount - 1);
                    }
                }
               else if(iReturnCode==0)
                {
                    DisplayStatusOfSensor("OK", " ");
                    LabelSensorOK.ForeColor = Color.Green;
                }
            }
        }

        delegate void EnableSettleButtonCallBack(bool Enabled);
        private void ControlSettleButton(bool Enabled)
        {
            if (this.BeginSettleTestBtn.InvokeRequired)
            {
                EnableSettleButtonCallBack d = new EnableSettleButtonCallBack(ControlSettleButton);
                this.Invoke(d, new object[] { Enabled });
            }
            else
            {
                this.BeginSettleTestBtn.Enabled = Enabled;
            }
        }

        delegate void EnableHoldButtonCallBack(bool Enabled);
        private void ControlHoldButton(bool Enabled)
        {
            if (this.BeginMainPressureTestBtn.InvokeRequired)
            {
                EnableHoldButtonCallBack d = new EnableHoldButtonCallBack(ControlHoldButton);
                this.Invoke(d, new object[] { Enabled });
            }
            else
            {
                this.BeginMainPressureTestBtn.Enabled = Enabled;
            }
        }

        delegate void EnableFinishButtonCallBack(bool Enabled);
        private void ControlFinishButton(bool Enabled)
        {
            if (this.FinishTestBtn.InvokeRequired)
            {
                EnableFinishButtonCallBack d = new EnableFinishButtonCallBack(ControlFinishButton);
                this.Invoke(d, new object[] { Enabled });
            }
            else
            {
                this.FinishTestBtn.Enabled = Enabled;
            }
        }

        delegate void EnableWarningButtonCallBack(bool Enabled);
        private void ControlWarningButton(bool Enabled)
        {
            if (this.RequestToEnterChamberBtn.InvokeRequired)
            {
                EnableWarningButtonCallBack d = new EnableWarningButtonCallBack(ControlWarningButton);
                this.Invoke(d, new object[] { Enabled });
            }
            else
            {
                this.RequestToEnterChamberBtn.Enabled = Enabled;
            }
        }
    }
}
