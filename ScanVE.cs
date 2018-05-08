using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.IO.Ports;
using KProxAPI;
using System.Text.RegularExpressions;
using Operators;
using KROHNERecordDatabase;

namespace PTMA
{
    public partial class ScanVE : Form
    {
        List<string> szSuccessfullSerialNoFound_List = new List<string>();
        //Dummy destination  @"\\gbd1prod\ProdEng\Projects\Pressure Testing automation\LOG.txt";
        //Actual destination @"\\gbd1prod\Flowrigs\Production\pressure monitoring\Results\LOG.txt";
        string szdestinationLogFile = @"\\gbd1prod\ProdEng\Projects\Pressure Testing automation\LOG.txt";
        Operators.Operators.OperatorRecord op;
        DBConnect dbData = new DBConnect();
        uint u8read;
        string sZaddress, szStoredinTxt, szDoc = "787001", sZfullName, sZsub, sZworkingregister, sZworkingregisterinTxt, szseries, szPORT, szDate;
        string[] sZwords;
        char cSeries, cType, cextraSeries, cVersion, cVersioninTxt;
        bool bcheck, bproxCheck;// boperator;
        int iIlastDigits, IlastdigitsinTxt, iCount;//,countVE;
        decimal decVersion, decVersioninTxt;
        XmlDocument XmlObjFlanges = new XmlDocument();
        DoPressureTest PtestForm = new DoPressureTest();
        public static string szveText, szpTest; // Send unidentified VE code to new flange form for analysis[its easier then sending the corresponding ID character of the code]
        public static TextBox TxtPassPressure = new TextBox(); //used to pass pressure value over to ptest form why not use string as opposed to an entire textbox object?
        public static bool bFlangeFound = false;
        public static string szstatus; //each event is stored on string status and saved as a single line on a text file, this string is written to the text at the end of a test.
        public static bool bheatingjacket, bUARTSwitch, bReWorkFlag;
        volatile bool bDisplayEngineerAreaThreadCheck;
        int iTo, iFrom;

        private void SerialPortDropdownList_DropDownClosed(object sender, EventArgs e)
        {
            string szPort = SerialPortDropdownList.GetItemText(SerialPortDropdownList.SelectedItem);
            Properties.Settings.Default["PORT"] = szPort;
            Properties.Settings.Default.Save();
        }

        private void AquaReadState_Click(object sender, EventArgs e)
        {

        }

        private void ConnectESISensor_Click(object sender, EventArgs e)
        {

        }

        private void NextFormBtn_Click(object sender, EventArgs e)
        {
            if(!redundancyCheck())
            {
                InitiateNextForm();
            }
            else
            {
                FormInformationLabel.Text = "Meter already passed,re-test denied";
                DialogResult dialogResult = MessageBox.Show("Confirm Re-Test", "Confirm re-test?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bReWorkFlag = true;
                    InitiateNextForm();

                }
                else if (dialogResult == DialogResult.No)
                {

                    FormInformationLabel.Text = "Meter already passed,re-test denied";
                }
            }
        }

        private void InitiateNextForm()
        {

                if (bcheck == false) //no match
                {
                    szstatus = "";
                    //status string , shows what has been going on
                    szstatus = "Date&Time: " + DateTime.Now.ToString() + " " + "VE: " + VECodeTXT.Text + "Serialnr :" + SerialNumberTextBox.Text + " NFOUND";
                    //reset the scan form
                    //boperator = false;
                    bDisplayEngineerAreaThreadCheck = false;
                    checkStatusofTextBoxesTimer.Enabled = false;
                    //Console.Beep();
                    this.Hide();
                    //newflange.ShowDialog();
                    PtestForm.ShowDialog();
                    this.Show();
                    bDisplayEngineerAreaThreadCheck = true;
                    checkStatusofTextBoxesTimer.Enabled = true;
                    Thread DisplayEngineerArea = new Thread(DisplayEngineerControls);
                    DisplayEngineerArea.Start();
                    bDisplayEngineerAreaThreadCheck = true;

                    bReWorkFlag = false;
                    //EngineerModeTimer.Enabled = true;
                    checkStatusofTextBoxesTimer.Enabled = true;

                }
                else //match found! 
                {
                    //status string, shows what has been going on
                    szstatus = "";
                    szstatus = "Date&Time: " + DateTime.Now.ToString() + " " + " VE: " + VECodeTXT.Text + " Serialnr :" + SerialNumberTextBox.Text + " FOUND" + " pTest@: " + sZwords[0] + "Bar " + szseries + "Series " + "fName: " + sZwords[1]; //SZwords[0]=pressure SZwords[1]=flangename                                                                                                                                                                                                                                                   //reset the scan form
                    NextFormBtn.Enabled = false;
                    //boperator = false;
                    bDisplayEngineerAreaThreadCheck = false;
                    checkStatusofTextBoxesTimer.Enabled = false;
                    this.Hide();
                    PtestForm.ShowDialog();
                    this.Show();

                    Thread DisplayEngineerArea = new Thread(DisplayEngineerControls);
                    DisplayEngineerArea.Start();
                    bDisplayEngineerAreaThreadCheck = true;
                    checkStatusofTextBoxesTimer.Enabled = true;
                    DisplayFlangeInfolabel.Text = "";
                    FormInformationLabel.Text = "Scan VE Code";
                    VECodeTXT.Text = "";
                    SerialNumberTextBox.Text = "";

                }

            

        }
        private void CloseEngineerOptionsBtn_Click(object sender, EventArgs e)
        {
            //SerialPortDropdownList.Items.Clear();
            bproxCheck = false;
            // serialPort1.Close();
            // Properties.Settings.Default["Door1"] = Door1AvailableChkBx.Checked;
            // Properties.Settings.Default["Door2"] = Door2AvailableChkBx.Checked; 
            Properties.Settings.Default.Save();
            // serialPort1.PortName = Properties.Settings.Default["MICRO"].ToString();
            DisplayGroupBox(false);
        }

        private void Solenoid1LockTestBtn_Click(object sender, EventArgs e)
        {

        }

        private void Solenoid1UnlockTestBtn_Click(object sender, EventArgs e)
        {

        }

        private void SerialNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (VECodeTXT.Text.Length >= 12)
            {


                szveText = VECodeTXT.Text; //send VE code to object used for newflange form.
                cSeries = VECodeTXT.Text[2];
                cextraSeries = VECodeTXT.Text[3];
                cType = VECodeTXT.Text[5];
                sZaddress = VECodeTXT.Text.Substring(7, 2);
                search();

                if (VECodeTXT.Text[11] == '3' || VECodeTXT.Text[11] == '5' || VECodeTXT.Text[11] == '1' || VECodeTXT.Text[11] == 'C' || VECodeTXT.Text[11] == 'D')
                {
                    bheatingjacket = true;
                }
                else
                {
                    bheatingjacket = false;
                }
            }
            
        }


        private void checkStatusofTextBoxesTimer_Tick(object sender, EventArgs e)
        {
            if ((VECodeTXT.Text != "") && (SerialNumberTextBox.Text != ""))
            {
                NextFormBtn.Enabled = true;
            }
            else if ((VECodeTXT.Text == "") || (SerialNumberTextBox.Text == ""))
            {
                NextFormBtn.Enabled = false;
            }
            if (VECodeTXT.Text == "")
            {
                //countVE = 0;
            }
            else if (SerialNumberTextBox.Text == "")
            {
                iCount = 0;
            }
            else
            {

            }
        }


        public ScanVE()
        {
            InitializeComponent();
        }

        private void ScanVE_Load(object sender, EventArgs e)
        {

            Thread DisplayEngineerArea = new Thread(DisplayEngineerControls);
            DisplayEngineerArea.Name = "EngineerControlThread";
            DisplayEngineerArea.Start();
            bDisplayEngineerAreaThreadCheck = true;
            szDate = DateTime.Now.ToShortDateString();
            int uDailyOutput = Calculate_FirstPassYield();
            DisplayDailyOutputLabel.Text = uDailyOutput.ToString();
            FormInformationLabel.Text = "Scan VE code and serial n/o";
            SerialNumberTextBox.Text = "";
            NextFormBtn.Enabled = false;
            VECodeTXT.Enabled = true;
            SerialNumberTextBox.Enabled = true;
    
        }
        delegate void DisplayEngineerControlsCallBack(bool Visibility);
    
        private void DisplayGroupBox(bool Visibility)
        {
            if(this.EngineerModeGrpBox.InvokeRequired)
            {
                DisplayEngineerControlsCallBack d = new DisplayEngineerControlsCallBack(DisplayGroupBox);
                this.Invoke(d,new object[] { Visibility});
            }
            else
            {
                this.EngineerModeGrpBox.Visible = Visibility;
            }
        }
        public void DisplayEngineerControls()
        {
            while (bDisplayEngineerAreaThreadCheck)
            {
                u8read = pcProx.GetCardID_User();
                if (u8read > 0 && (!bproxCheck))
                {
                    //pcProx.Beep(1,false);
                    op = dbData.SelectOperatorFromID(u8read);

                    if (op.bEngineer)
                    {

                        string[] ports = SerialPort.GetPortNames();
                        foreach (string element in ports)
                        {
                            SerialPortDropdownList.Items.Add(element);
                        }
                        /////  comboBox1.SelectedIndex = comboBox1.FindStringExact(Scan.pTest);
                        // SerialPortDropdownList.SelectedIndex = SerialPortDropdownList.FindStringExact(Settings.Default["MICRO"].ToString());
                        bproxCheck = true;
                        //VECodeTXT.Text = Settings.Default["Door1"].ToString();
                        // serialPort1.PortName = Settings.Default["MICRO"].ToString();
                        // serialPort1.Open();
                        DisplayGroupBox(true);
                    }
                    else
                    {
                        //serialPort1.Close();
                        //DisplayGroupBox(false);
                    }

                }
            }
        }
        private int Calculate_FirstPassYield()
        {
            var date = DateTime.Now;
            List<string> szCompare_List = new List<string>();
            string[] szArray_lines = System.IO.File.ReadAllLines(szdestinationLogFile);
            //filter out all tests that have the pass == true and store each instance in a list containing serialcode

            int iNoOfPassesFound = 0;
            // uint iNoOfSuccessfulComparisons = 0;
            foreach (string szLine in szArray_lines)
            {
                if (szLine.Contains("Pass: True") && szLine.Contains(szDate))
                {
                    try
                    {
                        iNoOfPassesFound++;
                        iTo = szLine.LastIndexOf(" FOUND ");
                        iFrom = szLine.IndexOf("Serialnr ") + "Serialnr ".Length;
                        szSuccessfullSerialNoFound_List.Add(szLine.Substring(iFrom, iTo - iFrom));
                        iTo = 0;
                        iFrom = 0;
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        iTo = szLine.LastIndexOf(" NFOUND ");
                        szSuccessfullSerialNoFound_List.Add(szLine.Substring(iFrom, iTo - iFrom));
                        iTo = 0;
                        iFrom = 0;
                    }
                    if (szLine.Contains("ReWork: True"))
                    {
                        iNoOfPassesFound--;
                    }
                    else
                    {
                        //do nothing;
                    }
                }

            }
            return iNoOfPassesFound;
        }

        public void search()

        {
            bcheck = false;
            if (cSeries == '8')
            {
                bcheck = search1000(sZaddress, cType.ToString());
            }
            else if ((cSeries == '0' && cextraSeries == '1') || (cSeries == '0' && cextraSeries == '3') || (cSeries == '0' && cextraSeries == '4'))
            {
                bcheck = search3000(sZaddress, cType.ToString());
            }
            else if (cSeries == '7')
            {
                bcheck = search6000(sZaddress, cType.ToString());
            }
            else if (cSeries == '4' || cSeries == '2' || cSeries == '3' || cSeries == '1')
            {
                bcheck = search7000(sZaddress, cType.ToString());
            }
            else if (cSeries == '9' || (cSeries == '0' && cextraSeries == '7'))
            {
                bcheck = search4000(sZaddress, cType.ToString());
            }

            if (bcheck == false)
            {
                DisplayFlangeInfolabel.Text = "Unidentified VE Click Next";
            }
        }
        
        public bool search1000(string ID, string Type)
        {
            FileStream rfile = new FileStream(@"\\gbd1prod\flowrigs\Production\pressure monitoring\Results\new.xml", FileMode.Open);
            XmlObjFlanges.Load(rfile);
            XmlNodeList list = XmlObjFlanges.GetElementsByTagName("S1000");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement cl = (XmlElement)XmlObjFlanges.GetElementsByTagName("S1000")[i];
                if ((cl.GetAttribute("ID")) == ID && cl.GetAttribute("Type") == Type)
                {
                    sZaddress = cl.InnerText;
                    rfile.Close();
                    sZwords = sZaddress.Split(' ');
                    // sZwords[0]; //Pressure value
                    // sZwords[1]; //Flange name
                    szseries = "1000";
                    DisplayFlangeInfolabel.Text = "1000" + cType.ToString() + " " + sZwords[1] + " " + "testPressure@: " + sZwords[0] + " bar";
                    szpTest = sZwords[0];
                    return true;
                }

            }

            rfile.Close();
            return false;
        }
        public bool search2000(string ID, string Type)
        {
            FileStream rfile = new FileStream(@"\\gbd1prod\flowrigs\Production\pressure monitoring\Results\new.xml", FileMode.Open);
            XmlObjFlanges.Load(rfile);
            XmlNodeList list = XmlObjFlanges.GetElementsByTagName("S2000");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement cl = (XmlElement)XmlObjFlanges.GetElementsByTagName("S2000")[i];
                //XmlElement add = (XmlElement)xdoc.GetElementsByTagName("Pressure")[i];
                //XmlElement add2 = (XmlElement)xdoc.GetElementsByTagName("Name")[i];
                if ((cl.GetAttribute("ID")) == ID && cl.GetAttribute("Type") == Type)
                {
                    sZaddress = cl.InnerText;
                    rfile.Close();
                    sZwords = sZaddress.Split(' ');
                    // sZwords[0]; //Pressure value
                    // sZwords[1]; //Flange name
                    szseries = "2000";
                    DisplayFlangeInfolabel.Text = "2000" + cType.ToString() + " " + sZwords[1] + " " + "testPressure@: " + sZwords[0] + " bar"; ;
                    szpTest = sZwords[0];
                    return true;
                }

            }
            rfile.Close();
            return false;
        }
        public bool search3000(string ID, string Type)
        {
            FileStream rfile = new FileStream(@"\\gbd1prod\flowrigs\Production\pressure monitoring\Results\new.xml", FileMode.Open);
            XmlObjFlanges.Load(rfile);
            XmlNodeList list = XmlObjFlanges.GetElementsByTagName("S3000");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement cl = (XmlElement)XmlObjFlanges.GetElementsByTagName("S3000")[i];
                //XmlElement add = (XmlElement)xdoc.GetElementsByTagName("Pressure")[i];
                //XmlElement add2 = (XmlElement)xdoc.GetElementsByTagName("Name")[i];
                if ((cl.GetAttribute("ID")) == ID && cl.GetAttribute("Type") == Type)
                {
                    sZaddress = cl.InnerText;
                    rfile.Close();
                    sZwords = sZaddress.Split(' ');
                    // sZwords[0]; //Pressure value
                    // sZwords[1]; //Flange name
                    szseries = "3000";
                    DisplayFlangeInfolabel.Text = "3000" + cType.ToString() + " " + sZwords[1] + " " + "testPressure@: " + sZwords[0] + " bar"; ;
                    szpTest = sZwords[0];
                    return true;
                }

            }
            rfile.Close();
            return false;
        }
        public bool search6000(string ID, string Type)
        {
            FileStream rfile = new FileStream(@"\\gbd1prod\flowrigs\Production\pressure monitoring\Results\new.xml", FileMode.Open);
            XmlObjFlanges.Load(rfile);
            XmlNodeList list = XmlObjFlanges.GetElementsByTagName("S6000");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement cl = (XmlElement)XmlObjFlanges.GetElementsByTagName("S6000")[i];
                //XmlElement add = (XmlElement)xdoc.GetElementsByTagName("Pressure")[i];
                //XmlElement add2 = (XmlElement)xdoc.GetElementsByTagName("Name")[i];
                if ((cl.GetAttribute("ID")) == ID && cl.GetAttribute("Type") == Type)
                {
                    sZaddress = cl.InnerText;
                    rfile.Close();
                    sZwords = sZaddress.Split(' ');
                    // sZwords[0]; //Pressure value
                    // sZwords[1]; //Flange name
                    szseries = "6000";
                    DisplayFlangeInfolabel.Text = "6000" + cType.ToString() + " " + sZwords[1] + " " + "testPressure@: " + sZwords[0] + " bar"; ;
                    szpTest = sZwords[0];
                    return true;
                }

            }
            rfile.Close();
            return false;
        }
        public bool search7000(string ID, string Type)
        {
            FileStream rfile = new FileStream(@"\\gbd1prod\flowrigs\Production\pressure monitoring\Results\new.xml", FileMode.Open);
            XmlObjFlanges.Load(rfile);
            XmlNodeList list = XmlObjFlanges.GetElementsByTagName("S7000");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement cl = (XmlElement)XmlObjFlanges.GetElementsByTagName("S7000")[i];
                //XmlElement add = (XmlElement)xdoc.GetElementsByTagName("Pressure")[i];
                //XmlElement add2 = (XmlElement)xdoc.GetElementsByTagName("Name")[i];
                if ((cl.GetAttribute("ID")) == ID && cl.GetAttribute("Type") == Type)
                {
                    sZaddress = cl.InnerText;
                    rfile.Close();
                    sZwords = sZaddress.Split(' ');
                    // sZwords[0]; //Pressure value
                    // sZwords[1]; //Flange name
                    szseries = "7000";
                    DisplayFlangeInfolabel.Text = "7000" + cType.ToString() + " " + sZwords[1] + " " + "testPressure@: " + sZwords[0] + " bar"; ;
                    szpTest = sZwords[0];
                    return true;
                }

            }
            rfile.Close();
            return false;
        }
        public bool search4000(string ID, string Type)
        {
            FileStream rfile = new FileStream(@"\\gbd1prod\flowrigs\pressure monitoring\new.xml", FileMode.Open);
            XmlObjFlanges.Load(rfile);
            XmlNodeList list = XmlObjFlanges.GetElementsByTagName("S4000");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement cl = (XmlElement)XmlObjFlanges.GetElementsByTagName("S4000")[i];
                //XmlElement add = (XmlElement)xdoc.GetElementsByTagName("Pressure")[i];
                //XmlElement add2 = (XmlElement)xdoc.GetElementsByTagName("Name")[i];
                if ((cl.GetAttribute("ID")) == ID && cl.GetAttribute("Type") == Type)
                {
                    sZaddress = cl.InnerText;
                    rfile.Close();
                    sZwords = sZaddress.Split(' ');
                    //sZwords[0]; //Pressure value
                    //sZwords[1]; //Flange name
                    szseries = "4000";
                    DisplayFlangeInfolabel.Text = "4000" + cType.ToString() + " " + sZwords[1] + " " + "testPressure@: " + sZwords[0] + " bar"; ;
                    szpTest = sZwords[0];
                    return true;
                }
            }
            rfile.Close();
            return false;
        }
        public bool redundancyCheck()
        {
            bool bcheck;
            // return false;
            string[] lines = System.IO.File.ReadAllLines(szdestinationLogFile);
            bcheck = false;// If no lines in text file then no match and thus pass

            foreach (string line in lines)
            {
                if ((line.Contains(SerialNumberTextBox.Text) == true) && (line.Contains("Pass: True") == true))
                {
                    Console.Beep();
                    bcheck = true;
                    break;
                }
                else
                {
                    bcheck = false;
                }
            }
            if (bcheck == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
