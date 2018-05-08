namespace PTMA
{
    partial class ScanVE
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DisplayDailyOutputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VECodeTXT = new System.Windows.Forms.TextBox();
            this.DisplayFlangeInfolabel = new System.Windows.Forms.Label();
            this.NextFormBtn = new System.Windows.Forms.Button();
            this.FormInformationLabel = new System.Windows.Forms.Label();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EngineerModeGrpBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Door1AvailableChkBx = new System.Windows.Forms.CheckBox();
            this.Door2AvailableChkBx = new System.Windows.Forms.CheckBox();
            this.Solenoid1LockTestBtn = new System.Windows.Forms.Button();
            this.CloseEngineerOptionsBtn = new System.Windows.Forms.Button();
            this.Solenoid1UnlockTestBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Solenoid2UnlockTestBtn = new System.Windows.Forms.Button();
            this.Solenoid2LockTestBtn = new System.Windows.Forms.Button();
            this.SerialPortDropdownList = new System.Windows.Forms.ComboBox();
            this.ValveOpenBtn = new System.Windows.Forms.Button();
            this.CloseValveBtn = new System.Windows.Forms.Button();
            this.checkStatusofTextBoxesTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.EngineerModeGrpBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DisplayDailyOutputLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(930, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 195);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Production Stats";
            this.groupBox2.Visible = false;
            // 
            // DisplayDailyOutputLabel
            // 
            this.DisplayDailyOutputLabel.AutoSize = true;
            this.DisplayDailyOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayDailyOutputLabel.Location = new System.Drawing.Point(6, 69);
            this.DisplayDailyOutputLabel.Name = "DisplayDailyOutputLabel";
            this.DisplayDailyOutputLabel.Size = new System.Drawing.Size(135, 44);
            this.DisplayDailyOutputLabel.TabIndex = 15;
            this.DisplayDailyOutputLabel.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 44);
            this.label2.TabIndex = 14;
            this.label2.Text = "Daily Output";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VECodeTXT);
            this.groupBox1.Controls.Add(this.DisplayFlangeInfolabel);
            this.groupBox1.Controls.Add(this.NextFormBtn);
            this.groupBox1.Controls.Add(this.FormInformationLabel);
            this.groupBox1.Controls.Add(this.SerialNumberTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 322);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // VECodeTXT
            // 
            this.VECodeTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VECodeTXT.Location = new System.Drawing.Point(6, 83);
            this.VECodeTXT.Name = "VECodeTXT";
            this.VECodeTXT.Size = new System.Drawing.Size(724, 50);
            this.VECodeTXT.TabIndex = 10;
            // 
            // DisplayFlangeInfolabel
            // 
            this.DisplayFlangeInfolabel.AutoSize = true;
            this.DisplayFlangeInfolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayFlangeInfolabel.Location = new System.Drawing.Point(6, 16);
            this.DisplayFlangeInfolabel.Name = "DisplayFlangeInfolabel";
            this.DisplayFlangeInfolabel.Size = new System.Drawing.Size(337, 44);
            this.DisplayFlangeInfolabel.TabIndex = 5;
            this.DisplayFlangeInfolabel.Text = "Flange information";
            // 
            // NextFormBtn
            // 
            this.NextFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextFormBtn.Location = new System.Drawing.Point(620, 195);
            this.NextFormBtn.Name = "NextFormBtn";
            this.NextFormBtn.Size = new System.Drawing.Size(286, 119);
            this.NextFormBtn.TabIndex = 2;
            this.NextFormBtn.Text = "Next";
            this.NextFormBtn.UseVisualStyleBackColor = true;
            this.NextFormBtn.Click += new System.EventHandler(this.NextFormBtn_Click);
            // 
            // FormInformationLabel
            // 
            this.FormInformationLabel.AutoSize = true;
            this.FormInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormInformationLabel.Location = new System.Drawing.Point(6, 192);
            this.FormInformationLabel.Name = "FormInformationLabel";
            this.FormInformationLabel.Size = new System.Drawing.Size(258, 44);
            this.FormInformationLabel.TabIndex = 13;
            this.FormInformationLabel.Text = "Scan VE code";
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberTextBox.Location = new System.Drawing.Point(6, 139);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(724, 50);
            this.SerialNumberTextBox.TabIndex = 11;
            this.SerialNumberTextBox.TextChanged += new System.EventHandler(this.SerialNumberTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(736, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "VE code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(736, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 44);
            this.label5.TabIndex = 12;
            this.label5.Text = "Serial no";
            // 
            // EngineerModeGrpBox
            // 
            this.EngineerModeGrpBox.Controls.Add(this.groupBox3);
            this.EngineerModeGrpBox.Controls.Add(this.Solenoid1LockTestBtn);
            this.EngineerModeGrpBox.Controls.Add(this.CloseEngineerOptionsBtn);
            this.EngineerModeGrpBox.Controls.Add(this.Solenoid1UnlockTestBtn);
            this.EngineerModeGrpBox.Controls.Add(this.label1);
            this.EngineerModeGrpBox.Controls.Add(this.Solenoid2UnlockTestBtn);
            this.EngineerModeGrpBox.Controls.Add(this.Solenoid2LockTestBtn);
            this.EngineerModeGrpBox.Controls.Add(this.SerialPortDropdownList);
            this.EngineerModeGrpBox.Controls.Add(this.ValveOpenBtn);
            this.EngineerModeGrpBox.Controls.Add(this.CloseValveBtn);
            this.EngineerModeGrpBox.Location = new System.Drawing.Point(12, 340);
            this.EngineerModeGrpBox.Name = "EngineerModeGrpBox";
            this.EngineerModeGrpBox.Size = new System.Drawing.Size(665, 95);
            this.EngineerModeGrpBox.TabIndex = 38;
            this.EngineerModeGrpBox.TabStop = false;
            this.EngineerModeGrpBox.Text = "Engineer Settings";
            this.EngineerModeGrpBox.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Door1AvailableChkBx);
            this.groupBox3.Controls.Add(this.Door2AvailableChkBx);
            this.groupBox3.Location = new System.Drawing.Point(403, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 56);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pressure Test Bay Settings";
            // 
            // Door1AvailableChkBx
            // 
            this.Door1AvailableChkBx.AutoSize = true;
            this.Door1AvailableChkBx.Location = new System.Drawing.Point(67, 27);
            this.Door1AvailableChkBx.Name = "Door1AvailableChkBx";
            this.Door1AvailableChkBx.Size = new System.Drawing.Size(55, 17);
            this.Door1AvailableChkBx.TabIndex = 33;
            this.Door1AvailableChkBx.Text = "Door1";
            this.Door1AvailableChkBx.UseVisualStyleBackColor = true;
            // 
            // Door2AvailableChkBx
            // 
            this.Door2AvailableChkBx.AutoSize = true;
            this.Door2AvailableChkBx.Location = new System.Drawing.Point(6, 27);
            this.Door2AvailableChkBx.Name = "Door2AvailableChkBx";
            this.Door2AvailableChkBx.Size = new System.Drawing.Size(55, 17);
            this.Door2AvailableChkBx.TabIndex = 32;
            this.Door2AvailableChkBx.Text = "Door2";
            this.Door2AvailableChkBx.UseVisualStyleBackColor = true;
            // 
            // Solenoid1LockTestBtn
            // 
            this.Solenoid1LockTestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Solenoid1LockTestBtn.Location = new System.Drawing.Point(6, 19);
            this.Solenoid1LockTestBtn.Name = "Solenoid1LockTestBtn";
            this.Solenoid1LockTestBtn.Size = new System.Drawing.Size(84, 31);
            this.Solenoid1LockTestBtn.TabIndex = 25;
            this.Solenoid1LockTestBtn.Text = "Door1Lock";
            this.Solenoid1LockTestBtn.UseVisualStyleBackColor = true;
            this.Solenoid1LockTestBtn.Click += new System.EventHandler(this.Solenoid1LockTestBtn_Click);
            // 
            // CloseEngineerOptionsBtn
            // 
            this.CloseEngineerOptionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseEngineerOptionsBtn.Location = new System.Drawing.Point(569, 18);
            this.CloseEngineerOptionsBtn.Name = "CloseEngineerOptionsBtn";
            this.CloseEngineerOptionsBtn.Size = new System.Drawing.Size(84, 66);
            this.CloseEngineerOptionsBtn.TabIndex = 30;
            this.CloseEngineerOptionsBtn.Text = "Close";
            this.CloseEngineerOptionsBtn.UseVisualStyleBackColor = true;
            this.CloseEngineerOptionsBtn.Click += new System.EventHandler(this.CloseEngineerOptionsBtn_Click);
            // 
            // Solenoid1UnlockTestBtn
            // 
            this.Solenoid1UnlockTestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Solenoid1UnlockTestBtn.Location = new System.Drawing.Point(6, 54);
            this.Solenoid1UnlockTestBtn.Name = "Solenoid1UnlockTestBtn";
            this.Solenoid1UnlockTestBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Solenoid1UnlockTestBtn.Size = new System.Drawing.Size(84, 31);
            this.Solenoid1UnlockTestBtn.TabIndex = 23;
            this.Solenoid1UnlockTestBtn.Text = "Door1Unlock";
            this.Solenoid1UnlockTestBtn.UseVisualStyleBackColor = true;
            this.Solenoid1UnlockTestBtn.Click += new System.EventHandler(this.Solenoid1UnlockTestBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "COM Ports";
            this.label1.Visible = false;
            // 
            // Solenoid2UnlockTestBtn
            // 
            this.Solenoid2UnlockTestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Solenoid2UnlockTestBtn.Location = new System.Drawing.Point(96, 54);
            this.Solenoid2UnlockTestBtn.Name = "Solenoid2UnlockTestBtn";
            this.Solenoid2UnlockTestBtn.Size = new System.Drawing.Size(84, 31);
            this.Solenoid2UnlockTestBtn.TabIndex = 26;
            this.Solenoid2UnlockTestBtn.Text = "Door2Unlock";
            this.Solenoid2UnlockTestBtn.UseVisualStyleBackColor = true;
            // 
            // Solenoid2LockTestBtn
            // 
            this.Solenoid2LockTestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Solenoid2LockTestBtn.Location = new System.Drawing.Point(96, 19);
            this.Solenoid2LockTestBtn.Name = "Solenoid2LockTestBtn";
            this.Solenoid2LockTestBtn.Size = new System.Drawing.Size(84, 31);
            this.Solenoid2LockTestBtn.TabIndex = 27;
            this.Solenoid2LockTestBtn.Text = "Door2Lock";
            this.Solenoid2LockTestBtn.UseVisualStyleBackColor = true;
            // 
            // SerialPortDropdownList
            // 
            this.SerialPortDropdownList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialPortDropdownList.FormattingEnabled = true;
            this.SerialPortDropdownList.Location = new System.Drawing.Point(276, 51);
            this.SerialPortDropdownList.Name = "SerialPortDropdownList";
            this.SerialPortDropdownList.Size = new System.Drawing.Size(121, 33);
            this.SerialPortDropdownList.TabIndex = 24;
            this.SerialPortDropdownList.DropDownClosed += new System.EventHandler(this.SerialPortDropdownList_DropDownClosed);
            // 
            // ValveOpenBtn
            // 
            this.ValveOpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValveOpenBtn.Location = new System.Drawing.Point(186, 54);
            this.ValveOpenBtn.Name = "ValveOpenBtn";
            this.ValveOpenBtn.Size = new System.Drawing.Size(84, 31);
            this.ValveOpenBtn.TabIndex = 28;
            this.ValveOpenBtn.Text = "ValveOpen";
            this.ValveOpenBtn.UseVisualStyleBackColor = true;
            // 
            // CloseValveBtn
            // 
            this.CloseValveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseValveBtn.Location = new System.Drawing.Point(186, 19);
            this.CloseValveBtn.Name = "CloseValveBtn";
            this.CloseValveBtn.Size = new System.Drawing.Size(84, 31);
            this.CloseValveBtn.TabIndex = 29;
            this.CloseValveBtn.Text = "ValveClosed";
            this.CloseValveBtn.UseVisualStyleBackColor = true;
            // 
            // checkStatusofTextBoxesTimer
            // 
            this.checkStatusofTextBoxesTimer.Enabled = true;
            this.checkStatusofTextBoxesTimer.Tick += new System.EventHandler(this.checkStatusofTextBoxesTimer_Tick);
            // 
            // ScanVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 439);
            this.Controls.Add(this.EngineerModeGrpBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScanVE";
            this.Text = "ScanVE";
            this.Load += new System.EventHandler(this.ScanVE_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.EngineerModeGrpBox.ResumeLayout(false);
            this.EngineerModeGrpBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label DisplayDailyOutputLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox VECodeTXT;
        private System.Windows.Forms.Label DisplayFlangeInfolabel;
        private System.Windows.Forms.Button NextFormBtn;
        private System.Windows.Forms.Label FormInformationLabel;
        private System.Windows.Forms.TextBox SerialNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox EngineerModeGrpBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Door1AvailableChkBx;
        private System.Windows.Forms.CheckBox Door2AvailableChkBx;
        private System.Windows.Forms.Button Solenoid1LockTestBtn;
        private System.Windows.Forms.Button CloseEngineerOptionsBtn;
        private System.Windows.Forms.Button Solenoid1UnlockTestBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Solenoid2UnlockTestBtn;
        private System.Windows.Forms.Button Solenoid2LockTestBtn;
        private System.Windows.Forms.ComboBox SerialPortDropdownList;
        private System.Windows.Forms.Button ValveOpenBtn;
        private System.Windows.Forms.Button CloseValveBtn;
        private System.Windows.Forms.Timer checkStatusofTextBoxesTimer;
    }
}