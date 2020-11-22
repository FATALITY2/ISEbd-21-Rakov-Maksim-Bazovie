namespace WindowsFormsCrane
{
    partial class FormCraneConfig
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
			this.pictureBoxCrane = new System.Windows.Forms.PictureBox();
			this.groupBoxType = new System.Windows.Forms.GroupBox();
			this.labelCrane = new System.Windows.Forms.Label();
			this.labelSuperCrane = new System.Windows.Forms.Label();
			this.groupBoxParam = new System.Windows.Forms.GroupBox();
			this.checkBoxCounterWeight = new System.Windows.Forms.CheckBox();
			this.checkBoxLiftingDevice = new System.Windows.Forms.CheckBox();
			this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
			this.labelWeight = new System.Windows.Forms.Label();
			this.labelSpeed = new System.Windows.Forms.Label();
			this.panelCrane = new System.Windows.Forms.Panel();
			this.groupBoxColor = new System.Windows.Forms.GroupBox();
			this.panelBlue = new System.Windows.Forms.Panel();
			this.panelWhite = new System.Windows.Forms.Panel();
			this.panelGreen = new System.Windows.Forms.Panel();
			this.panelBlack = new System.Windows.Forms.Panel();
			this.panelGray = new System.Windows.Forms.Panel();
			this.panelOrange = new System.Windows.Forms.Panel();
			this.panelYellow = new System.Windows.Forms.Panel();
			this.panelRed = new System.Windows.Forms.Panel();
			this.labelDopColor = new System.Windows.Forms.Label();
			this.labelMainColor = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrane)).BeginInit();
			this.groupBoxType.SuspendLayout();
			this.groupBoxParam.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
			this.panelCrane.SuspendLayout();
			this.groupBoxColor.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxCrane
			// 
			this.pictureBoxCrane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxCrane.Location = new System.Drawing.Point(22, 12);
			this.pictureBoxCrane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBoxCrane.Name = "pictureBoxCrane";
			this.pictureBoxCrane.Size = new System.Drawing.Size(203, 157);
			this.pictureBoxCrane.TabIndex = 0;
			this.pictureBoxCrane.TabStop = false;
			// 
			// groupBoxType
			// 
			this.groupBoxType.Controls.Add(this.labelCrane);
			this.groupBoxType.Controls.Add(this.labelSuperCrane);
			this.groupBoxType.Location = new System.Drawing.Point(9, 10);
			this.groupBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxType.Name = "groupBoxType";
			this.groupBoxType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxType.Size = new System.Drawing.Size(150, 125);
			this.groupBoxType.TabIndex = 1;
			this.groupBoxType.TabStop = false;
			this.groupBoxType.Text = "Тип кузова";
			// 
			// labelCrane
			// 
			this.labelCrane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelCrane.Location = new System.Drawing.Point(7, 24);
			this.labelCrane.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCrane.Name = "labelCrane";
			this.labelCrane.Size = new System.Drawing.Size(130, 44);
			this.labelCrane.TabIndex = 0;
			this.labelCrane.Text = "Кран";
			this.labelCrane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelCrane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCrane_MouseDown);
			// 
			// labelSuperCrane
			// 
			this.labelSuperCrane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelSuperCrane.Location = new System.Drawing.Point(7, 74);
			this.labelSuperCrane.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelSuperCrane.Name = "labelSuperCrane";
			this.labelSuperCrane.Size = new System.Drawing.Size(130, 43);
			this.labelSuperCrane.TabIndex = 1;
			this.labelSuperCrane.Text = "Супер Кран";
			this.labelSuperCrane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelSuperCrane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSuperCrane_MouseDown);
			// 
			// groupBoxParam
			// 
			this.groupBoxParam.Controls.Add(this.checkBoxCounterWeight);
			this.groupBoxParam.Controls.Add(this.checkBoxLiftingDevice);
			this.groupBoxParam.Controls.Add(this.numericUpDownWeight);
			this.groupBoxParam.Controls.Add(this.numericUpDownSpeed);
			this.groupBoxParam.Controls.Add(this.labelWeight);
			this.groupBoxParam.Controls.Add(this.labelSpeed);
			this.groupBoxParam.Location = new System.Drawing.Point(16, 197);
			this.groupBoxParam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxParam.Name = "groupBoxParam";
			this.groupBoxParam.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxParam.Size = new System.Drawing.Size(292, 119);
			this.groupBoxParam.TabIndex = 2;
			this.groupBoxParam.TabStop = false;
			this.groupBoxParam.Text = "Параметры";
			// 
			// checkBoxCounterWeight
			// 
			this.checkBoxCounterWeight.Checked = true;
			this.checkBoxCounterWeight.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxCounterWeight.Location = new System.Drawing.Point(171, 70);
			this.checkBoxCounterWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.checkBoxCounterWeight.Name = "checkBoxCounterWeight";
			this.checkBoxCounterWeight.Size = new System.Drawing.Size(110, 45);
			this.checkBoxCounterWeight.TabIndex = 5;
			this.checkBoxCounterWeight.Text = "Противовес";
			this.checkBoxCounterWeight.UseVisualStyleBackColor = true;
			// 
			// checkBoxLiftingDevice
			// 
			this.checkBoxLiftingDevice.Checked = true;
			this.checkBoxLiftingDevice.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxLiftingDevice.Location = new System.Drawing.Point(171, 17);
			this.checkBoxLiftingDevice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.checkBoxLiftingDevice.Name = "checkBoxLiftingDevice";
			this.checkBoxLiftingDevice.Size = new System.Drawing.Size(117, 41);
			this.checkBoxLiftingDevice.TabIndex = 4;
			this.checkBoxLiftingDevice.Text = "Подъемная устройство";
			this.checkBoxLiftingDevice.UseVisualStyleBackColor = true;
			// 
			// numericUpDownWeight
			// 
			this.numericUpDownWeight.Location = new System.Drawing.Point(63, 85);
			this.numericUpDownWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownWeight.Name = "numericUpDownWeight";
			this.numericUpDownWeight.Size = new System.Drawing.Size(42, 20);
			this.numericUpDownWeight.TabIndex = 3;
			this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numericUpDownSpeed
			// 
			this.numericUpDownSpeed.Location = new System.Drawing.Point(63, 41);
			this.numericUpDownSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownSpeed.Name = "numericUpDownSpeed";
			this.numericUpDownSpeed.Size = new System.Drawing.Size(42, 20);
			this.numericUpDownSpeed.TabIndex = 2;
			this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// labelWeight
			// 
			this.labelWeight.Location = new System.Drawing.Point(4, 70);
			this.labelWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelWeight.Name = "labelWeight";
			this.labelWeight.Size = new System.Drawing.Size(88, 24);
			this.labelWeight.TabIndex = 1;
			this.labelWeight.Text = "Вес крана";
			// 
			// labelSpeed
			// 
			this.labelSpeed.Location = new System.Drawing.Point(4, 23);
			this.labelSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelSpeed.Name = "labelSpeed";
			this.labelSpeed.Size = new System.Drawing.Size(100, 28);
			this.labelSpeed.TabIndex = 0;
			this.labelSpeed.Text = "Макс. скорость";
			// 
			// panelCrane
			// 
			this.panelCrane.AllowDrop = true;
			this.panelCrane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCrane.Controls.Add(this.pictureBoxCrane);
			this.panelCrane.Location = new System.Drawing.Point(164, 10);
			this.panelCrane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelCrane.Name = "panelCrane";
			this.panelCrane.Size = new System.Drawing.Size(246, 183);
			this.panelCrane.TabIndex = 3;
			this.panelCrane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCrane_DragDrop);
			this.panelCrane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCrane_DragEnter);
			// 
			// groupBoxColor
			// 
			this.groupBoxColor.Controls.Add(this.panelBlue);
			this.groupBoxColor.Controls.Add(this.panelWhite);
			this.groupBoxColor.Controls.Add(this.panelGreen);
			this.groupBoxColor.Controls.Add(this.panelBlack);
			this.groupBoxColor.Controls.Add(this.panelGray);
			this.groupBoxColor.Controls.Add(this.panelOrange);
			this.groupBoxColor.Controls.Add(this.panelYellow);
			this.groupBoxColor.Controls.Add(this.panelRed);
			this.groupBoxColor.Controls.Add(this.labelDopColor);
			this.groupBoxColor.Controls.Add(this.labelMainColor);
			this.groupBoxColor.Location = new System.Drawing.Point(436, 10);
			this.groupBoxColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxColor.Name = "groupBoxColor";
			this.groupBoxColor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxColor.Size = new System.Drawing.Size(202, 170);
			this.groupBoxColor.TabIndex = 4;
			this.groupBoxColor.TabStop = false;
			this.groupBoxColor.Text = "Цвета";
			// 
			// panelBlue
			// 
			this.panelBlue.BackColor = System.Drawing.Color.Blue;
			this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBlue.Location = new System.Drawing.Point(150, 111);
			this.panelBlue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelBlue.Name = "panelBlue";
			this.panelBlue.Size = new System.Drawing.Size(24, 29);
			this.panelBlue.TabIndex = 9;
			this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelWhite
			// 
			this.panelWhite.BackColor = System.Drawing.Color.White;
			this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelWhite.Location = new System.Drawing.Point(150, 77);
			this.panelWhite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelWhite.Name = "panelWhite";
			this.panelWhite.Size = new System.Drawing.Size(24, 30);
			this.panelWhite.TabIndex = 8;
			this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelGreen
			// 
			this.panelGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelGreen.Location = new System.Drawing.Point(104, 111);
			this.panelGreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelGreen.Name = "panelGreen";
			this.panelGreen.Size = new System.Drawing.Size(24, 29);
			this.panelGreen.TabIndex = 7;
			this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelBlack
			// 
			this.panelBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBlack.Location = new System.Drawing.Point(104, 77);
			this.panelBlack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelBlack.Name = "panelBlack";
			this.panelBlack.Size = new System.Drawing.Size(24, 30);
			this.panelBlack.TabIndex = 6;
			this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelGray
			// 
			this.panelGray.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelGray.Location = new System.Drawing.Point(20, 111);
			this.panelGray.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelGray.Name = "panelGray";
			this.panelGray.Size = new System.Drawing.Size(24, 29);
			this.panelGray.TabIndex = 5;
			this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelOrange
			// 
			this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelOrange.Location = new System.Drawing.Point(62, 111);
			this.panelOrange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelOrange.Name = "panelOrange";
			this.panelOrange.Size = new System.Drawing.Size(24, 29);
			this.panelOrange.TabIndex = 4;
			this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelYellow
			// 
			this.panelYellow.BackColor = System.Drawing.Color.Yellow;
			this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelYellow.Location = new System.Drawing.Point(62, 77);
			this.panelYellow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelYellow.Name = "panelYellow";
			this.panelYellow.Size = new System.Drawing.Size(24, 30);
			this.panelYellow.TabIndex = 3;
			this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelRed
			// 
			this.panelRed.BackColor = System.Drawing.Color.Red;
			this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelRed.Location = new System.Drawing.Point(20, 77);
			this.panelRed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelRed.Name = "panelRed";
			this.panelRed.Size = new System.Drawing.Size(24, 30);
			this.panelRed.TabIndex = 2;
			this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// labelDopColor
			// 
			this.labelDopColor.AllowDrop = true;
			this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopColor.Location = new System.Drawing.Point(104, 26);
			this.labelDopColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDopColor.Name = "labelDopColor";
			this.labelDopColor.Size = new System.Drawing.Size(87, 32);
			this.labelDopColor.TabIndex = 1;
			this.labelDopColor.Text = "Доп цвет";
			this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// labelMainColor
			// 
			this.labelMainColor.AllowDrop = true;
			this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelMainColor.Location = new System.Drawing.Point(4, 26);
			this.labelMainColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMainColor.Name = "labelMainColor";
			this.labelMainColor.Size = new System.Drawing.Size(88, 32);
			this.labelMainColor.TabIndex = 0;
			this.labelMainColor.Text = "Осн. цвет";
			this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
			this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(549, 184);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(88, 24);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(549, 213);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 24);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FormCraneConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 327);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.groupBoxColor);
			this.Controls.Add(this.panelCrane);
			this.Controls.Add(this.groupBoxParam);
			this.Controls.Add(this.groupBoxType);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FormCraneConfig";
			this.Text = "FormCraneConfig";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrane)).EndInit();
			this.groupBoxType.ResumeLayout(false);
			this.groupBoxParam.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
			this.panelCrane.ResumeLayout(false);
			this.groupBoxColor.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCrane;
        private System.Windows.Forms.GroupBox groupBoxType;
       
        private System.Windows.Forms.Label labelSuperCrane;
        private System.Windows.Forms.GroupBox groupBoxParam;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.CheckBox checkBoxCounterWeight;
        private System.Windows.Forms.CheckBox checkBoxLiftingDevice;
        private System.Windows.Forms.Panel panelCrane;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Label labelCrane;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelGray;
    }
}