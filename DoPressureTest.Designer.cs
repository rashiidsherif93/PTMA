namespace PTMA
{
    partial class DoPressureTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LabelSensorOK = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DisplayOperatorName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TestTimeDropDown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DisplayCountDownTimeTxtB = new System.Windows.Forms.TextBox();
            this.RequestToEnterChamberBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DisplaySolenoid2StatusLabel = new System.Windows.Forms.Label();
            this.DisplaySolenoid1StatusLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TestPressureTxtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BeginSettleTestBtn = new System.Windows.Forms.Button();
            this.CancelTestBtn = new System.Windows.Forms.Button();
            this.FinishTestBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayTotalPressureDropTxtB = new System.Windows.Forms.TextBox();
            this.DisplayPassingLabel = new System.Windows.Forms.Label();
            this.PressureSensorAbsoluteGaugeReading_barTxtB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BeginMainPressureTestBtn = new System.Windows.Forms.Button();
            this.InformationLargeLabel = new System.Windows.Forms.Label();
            this.DisplayPressureGaugesTimer = new System.Windows.Forms.Timer(this.components);
            this.DisplayInformationTestTxtB = new System.Windows.Forms.Label();
            this.LogDataTimer = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LabelSensorOK);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(969, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(407, 177);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sensor Info";
            // 
            // LabelSensorOK
            // 
            this.LabelSensorOK.AutoSize = true;
            this.LabelSensorOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSensorOK.Location = new System.Drawing.Point(17, 38);
            this.LabelSensorOK.Name = "LabelSensorOK";
            this.LabelSensorOK.Size = new System.Drawing.Size(0, 36);
            this.LabelSensorOK.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DisplayOperatorName);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.TestTimeDropDown);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.DisplayCountDownTimeTxtB);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(951, 177);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Timer settings";
            // 
            // DisplayOperatorName
            // 
            this.DisplayOperatorName.AutoSize = true;
            this.DisplayOperatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayOperatorName.Location = new System.Drawing.Point(438, 50);
            this.DisplayOperatorName.Name = "DisplayOperatorName";
            this.DisplayOperatorName.Size = new System.Drawing.Size(356, 55);
            this.DisplayOperatorName.TabIndex = 15;
            this.DisplayOperatorName.Text = "Operator Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 36);
            this.label3.TabIndex = 24;
            this.label3.Text = "Minutes";
            // 
            // TestTimeDropDown
            // 
            this.TestTimeDropDown.AutoCompleteCustomSource.AddRange(new string[] {
            "2",
            "10",
            "15",
            "30",
            "60"});
            this.TestTimeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TestTimeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestTimeDropDown.FormattingEnabled = true;
            this.TestTimeDropDown.Items.AddRange(new object[] {
            "02",
            "10",
            "15",
            "30",
            "60"});
            this.TestTimeDropDown.Location = new System.Drawing.Point(12, 37);
            this.TestTimeDropDown.Name = "TestTimeDropDown";
            this.TestTimeDropDown.Size = new System.Drawing.Size(121, 75);
            this.TestTimeDropDown.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(252, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 36);
            this.label7.TabIndex = 19;
            this.label7.Text = "Timer";
            // 
            // DisplayCountDownTimeTxtB
            // 
            this.DisplayCountDownTimeTxtB.Enabled = false;
            this.DisplayCountDownTimeTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCountDownTimeTxtB.ForeColor = System.Drawing.Color.Black;
            this.DisplayCountDownTimeTxtB.Location = new System.Drawing.Point(151, 37);
            this.DisplayCountDownTimeTxtB.Name = "DisplayCountDownTimeTxtB";
            this.DisplayCountDownTimeTxtB.Size = new System.Drawing.Size(281, 74);
            this.DisplayCountDownTimeTxtB.TabIndex = 18;
            this.DisplayCountDownTimeTxtB.Text = "00:00:00";
            this.DisplayCountDownTimeTxtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RequestToEnterChamberBtn
            // 
            this.RequestToEnterChamberBtn.Enabled = false;
            this.RequestToEnterChamberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestToEnterChamberBtn.Location = new System.Drawing.Point(771, 211);
            this.RequestToEnterChamberBtn.Name = "RequestToEnterChamberBtn";
            this.RequestToEnterChamberBtn.Size = new System.Drawing.Size(192, 137);
            this.RequestToEnterChamberBtn.TabIndex = 35;
            this.RequestToEnterChamberBtn.Text = "Enter chamber";
            this.RequestToEnterChamberBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DisplaySolenoid2StatusLabel);
            this.groupBox3.Controls.Add(this.DisplaySolenoid1StatusLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(365, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 153);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Door Status";
            // 
            // DisplaySolenoid2StatusLabel
            // 
            this.DisplaySolenoid2StatusLabel.AutoSize = true;
            this.DisplaySolenoid2StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplaySolenoid2StatusLabel.Location = new System.Drawing.Point(15, 53);
            this.DisplaySolenoid2StatusLabel.Name = "DisplaySolenoid2StatusLabel";
            this.DisplaySolenoid2StatusLabel.Size = new System.Drawing.Size(209, 36);
            this.DisplaySolenoid2StatusLabel.TabIndex = 5;
            this.DisplaySolenoid2StatusLabel.Text = "Door 2(Status)";
            // 
            // DisplaySolenoid1StatusLabel
            // 
            this.DisplaySolenoid1StatusLabel.AutoSize = true;
            this.DisplaySolenoid1StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplaySolenoid1StatusLabel.Location = new System.Drawing.Point(15, 93);
            this.DisplaySolenoid1StatusLabel.Name = "DisplaySolenoid1StatusLabel";
            this.DisplaySolenoid1StatusLabel.Size = new System.Drawing.Size(209, 36);
            this.DisplaySolenoid1StatusLabel.TabIndex = 4;
            this.DisplaySolenoid1StatusLabel.Text = "Door 1(Status)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.TestPressureTxtB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 153);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test pressure";
            // 
            // TestPressureTxtB
            // 
            this.TestPressureTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestPressureTxtB.Location = new System.Drawing.Point(6, 56);
            this.TestPressureTxtB.Name = "TestPressureTxtB";
            this.TestPressureTxtB.Size = new System.Drawing.Size(196, 74);
            this.TestPressureTxtB.TabIndex = 14;
            this.TestPressureTxtB.Leave += new System.EventHandler(this.TestPressureTxtB_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 67);
            this.label4.TabIndex = 12;
            this.label4.Text = "bar";
            // 
            // BeginSettleTestBtn
            // 
            this.BeginSettleTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginSettleTestBtn.Location = new System.Drawing.Point(365, 371);
            this.BeginSettleTestBtn.Name = "BeginSettleTestBtn";
            this.BeginSettleTestBtn.Size = new System.Drawing.Size(193, 149);
            this.BeginSettleTestBtn.TabIndex = 40;
            this.BeginSettleTestBtn.Text = "Settle";
            this.BeginSettleTestBtn.UseVisualStyleBackColor = true;
            this.BeginSettleTestBtn.Click += new System.EventHandler(this.BeginSettleTestBtn_Click_1);
            // 
            // CancelTestBtn
            // 
            this.CancelTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelTestBtn.Location = new System.Drawing.Point(969, 371);
            this.CancelTestBtn.Name = "CancelTestBtn";
            this.CancelTestBtn.Size = new System.Drawing.Size(192, 147);
            this.CancelTestBtn.TabIndex = 39;
            this.CancelTestBtn.Text = "Cancel";
            this.CancelTestBtn.UseVisualStyleBackColor = true;
            this.CancelTestBtn.Click += new System.EventHandler(this.CancelTestBtn_Click);
            // 
            // FinishTestBtn
            // 
            this.FinishTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishTestBtn.Location = new System.Drawing.Point(771, 371);
            this.FinishTestBtn.Name = "FinishTestBtn";
            this.FinishTestBtn.Size = new System.Drawing.Size(192, 147);
            this.FinishTestBtn.TabIndex = 38;
            this.FinishTestBtn.Text = "Finish";
            this.FinishTestBtn.UseVisualStyleBackColor = true;
            this.FinishTestBtn.Click += new System.EventHandler(this.FinishTestBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DisplayTotalPressureDropTxtB);
            this.groupBox1.Controls.Add(this.DisplayPassingLabel);
            this.groupBox1.Controls.Add(this.PressureSensorAbsoluteGaugeReading_barTxtB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 297);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gauge reading";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 67);
            this.label2.TabIndex = 17;
            this.label2.Text = "bar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "TotalPressureDrop";
            // 
            // DisplayTotalPressureDropTxtB
            // 
            this.DisplayTotalPressureDropTxtB.Enabled = false;
            this.DisplayTotalPressureDropTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTotalPressureDropTxtB.Location = new System.Drawing.Point(6, 176);
            this.DisplayTotalPressureDropTxtB.Name = "DisplayTotalPressureDropTxtB";
            this.DisplayTotalPressureDropTxtB.ReadOnly = true;
            this.DisplayTotalPressureDropTxtB.Size = new System.Drawing.Size(211, 74);
            this.DisplayTotalPressureDropTxtB.TabIndex = 16;
            this.DisplayTotalPressureDropTxtB.Text = "000.00";
            // 
            // DisplayPassingLabel
            // 
            this.DisplayPassingLabel.AutoSize = true;
            this.DisplayPassingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayPassingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayPassingLabel.Location = new System.Drawing.Point(22, 130);
            this.DisplayPassingLabel.Name = "DisplayPassingLabel";
            this.DisplayPassingLabel.Size = new System.Drawing.Size(0, 46);
            this.DisplayPassingLabel.TabIndex = 15;
            // 
            // PressureSensorAbsoluteGaugeReading_barTxtB
            // 
            this.PressureSensorAbsoluteGaugeReading_barTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureSensorAbsoluteGaugeReading_barTxtB.Location = new System.Drawing.Point(6, 53);
            this.PressureSensorAbsoluteGaugeReading_barTxtB.Name = "PressureSensorAbsoluteGaugeReading_barTxtB";
            this.PressureSensorAbsoluteGaugeReading_barTxtB.ReadOnly = true;
            this.PressureSensorAbsoluteGaugeReading_barTxtB.Size = new System.Drawing.Size(208, 74);
            this.PressureSensorAbsoluteGaugeReading_barTxtB.TabIndex = 14;
            this.PressureSensorAbsoluteGaugeReading_barTxtB.Text = "000.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 67);
            this.label5.TabIndex = 12;
            this.label5.Text = "bar";
            // 
            // BeginMainPressureTestBtn
            // 
            this.BeginMainPressureTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginMainPressureTestBtn.Location = new System.Drawing.Point(563, 371);
            this.BeginMainPressureTestBtn.Name = "BeginMainPressureTestBtn";
            this.BeginMainPressureTestBtn.Size = new System.Drawing.Size(202, 149);
            this.BeginMainPressureTestBtn.TabIndex = 36;
            this.BeginMainPressureTestBtn.Text = "Main";
            this.BeginMainPressureTestBtn.UseVisualStyleBackColor = true;
            this.BeginMainPressureTestBtn.Click += new System.EventHandler(this.BeginMainPressureTestBtn_Click);
            // 
            // InformationLargeLabel
            // 
            this.InformationLargeLabel.AutoSize = true;
            this.InformationLargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationLargeLabel.Location = new System.Drawing.Point(951, 638);
            this.InformationLargeLabel.Name = "InformationLargeLabel";
            this.InformationLargeLabel.Size = new System.Drawing.Size(0, 108);
            this.InformationLargeLabel.TabIndex = 42;
            // 
            // DisplayPressureGaugesTimer
            // 
            this.DisplayPressureGaugesTimer.Enabled = true;
            this.DisplayPressureGaugesTimer.Tick += new System.EventHandler(this.DisplayPressureGaugesTimer_Tick);
            // 
            // DisplayInformationTestTxtB
            // 
            this.DisplayInformationTestTxtB.AutoSize = true;
            this.DisplayInformationTestTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayInformationTestTxtB.ForeColor = System.Drawing.Color.Black;
            this.DisplayInformationTestTxtB.Location = new System.Drawing.Point(10, 654);
            this.DisplayInformationTestTxtB.Name = "DisplayInformationTestTxtB";
            this.DisplayInformationTestTxtB.Size = new System.Drawing.Size(368, 46);
            this.DisplayInformationTestTxtB.TabIndex = 43;
            this.DisplayInformationTestTxtB.Text = "Scan RFID to begin";
            // 
            // LogDataTimer
            // 
            this.LogDataTimer.Enabled = true;
            this.LogDataTimer.Interval = 12000;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(365, 524);
            this.trackBar1.Maximum = 700;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(796, 45);
            this.trackBar1.TabIndex = 44;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1087, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 67);
            this.label6.TabIndex = 45;
            this.label6.Text = "350 bar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 555);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 67);
            this.label8.TabIndex = 46;
            this.label8.Text = "0 bar";
            // 
            // DoPressureTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 759);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.DisplayInformationTestTxtB);
            this.Controls.Add(this.InformationLargeLabel);
            this.Controls.Add(this.BeginSettleTestBtn);
            this.Controls.Add(this.CancelTestBtn);
            this.Controls.Add(this.FinishTestBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BeginMainPressureTestBtn);
            this.Controls.Add(this.RequestToEnterChamberBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "DoPressureTest";
            this.Text = "DoPressureTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoPressureTest_FormClosed);
            this.Load += new System.EventHandler(this.DoPressureTest_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label LabelSensorOK;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label DisplayOperatorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TestTimeDropDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DisplayCountDownTimeTxtB;
        private System.Windows.Forms.Button RequestToEnterChamberBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label DisplaySolenoid2StatusLabel;
        private System.Windows.Forms.Label DisplaySolenoid1StatusLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TestPressureTxtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelTestBtn;
        private System.Windows.Forms.Button FinishTestBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DisplayTotalPressureDropTxtB;
        private System.Windows.Forms.Label DisplayPassingLabel;
        private System.Windows.Forms.TextBox PressureSensorAbsoluteGaugeReading_barTxtB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BeginMainPressureTestBtn;
        private System.Windows.Forms.Label InformationLargeLabel;
        private System.Windows.Forms.Button BeginSettleTestBtn;
        private System.Windows.Forms.Timer DisplayPressureGaugesTimer;
        private System.Windows.Forms.Label DisplayInformationTestTxtB;
        private System.Windows.Forms.Timer LogDataTimer;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}