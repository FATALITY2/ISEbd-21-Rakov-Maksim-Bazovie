namespace WindowsFormsCrane
{
    partial class FormParking
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
            this.buttonSetCrane = new System.Windows.Forms.Button();
            this.buttonSetSuperCrane = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTakeCar = new System.Windows.Forms.Button();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.listBoxParking = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.AddParking = new System.Windows.Forms.Button();
            this.DelParking = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetCrane
            // 
            this.buttonSetCrane.Location = new System.Drawing.Point(655, 215);
            this.buttonSetCrane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetCrane.Name = "buttonSetCrane";
            this.buttonSetCrane.Size = new System.Drawing.Size(139, 48);
            this.buttonSetCrane.TabIndex = 1;
            this.buttonSetCrane.Text = "Припарковать кран";
            this.buttonSetCrane.UseVisualStyleBackColor = true;
            this.buttonSetCrane.Click += new System.EventHandler(this.buttonSetCrane_Click);
            // 
            // buttonSetSuperCrane
            // 
            this.buttonSetSuperCrane.Location = new System.Drawing.Point(655, 268);
            this.buttonSetSuperCrane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetSuperCrane.Name = "buttonSetSuperCrane";
            this.buttonSetSuperCrane.Size = new System.Drawing.Size(139, 52);
            this.buttonSetSuperCrane.TabIndex = 2;
            this.buttonSetSuperCrane.Text = "Припарковать Суперкран";
            this.buttonSetSuperCrane.UseVisualStyleBackColor = true;
            this.buttonSetSuperCrane.Click += new System.EventHandler(this.buttonSetSuperCrane_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBoxNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonTakeCar);
            this.groupBox1.Location = new System.Drawing.Point(655, 326);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(139, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать кран";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Место :";
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(99, 48);
            this.maskedTextBoxNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(33, 22);
            this.maskedTextBoxNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // buttonTakeCar
            // 
            this.buttonTakeCar.Location = new System.Drawing.Point(33, 76);
            this.buttonTakeCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTakeCar.Name = "buttonTakeCar";
            this.buttonTakeCar.Size = new System.Drawing.Size(85, 23);
            this.buttonTakeCar.TabIndex = 0;
            this.buttonTakeCar.Text = "Забрать";
            this.buttonTakeCar.UseVisualStyleBackColor = true;
            this.buttonTakeCar.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(1, 2);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(716, 444);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // listBoxParking
            // 
            this.listBoxParking.FormattingEnabled = true;
            this.listBoxParking.ItemHeight = 16;
            this.listBoxParking.Location = new System.Drawing.Point(655, 94);
            this.listBoxParking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxParking.Name = "listBoxParking";
            this.listBoxParking.Size = new System.Drawing.Size(137, 84);
            this.listBoxParking.TabIndex = 4;
            this.listBoxParking.Click += new System.EventHandler(this.listBoxParking_SelectedIndexChanged);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(659, 25);
            this.textBoxNewLevelName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(128, 22);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // AddParking
            // 
            this.AddParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddParking.Location = new System.Drawing.Point(659, 55);
            this.AddParking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddParking.Name = "AddParking";
            this.AddParking.Size = new System.Drawing.Size(129, 32);
            this.AddParking.TabIndex = 6;
            this.AddParking.Text = "Добавить парковку";
            this.AddParking.UseVisualStyleBackColor = true;
            this.AddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // DelParking
            // 
            this.DelParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelParking.Location = new System.Drawing.Point(656, 181);
            this.DelParking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DelParking.Name = "DelParking";
            this.DelParking.Size = new System.Drawing.Size(129, 28);
            this.DelParking.TabIndex = 7;
            this.DelParking.Text = "Удалить парковку";
            this.DelParking.UseVisualStyleBackColor = true;
            this.DelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Парковки:";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DelParking);
            this.Controls.Add(this.AddParking);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxParking);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetSuperCrane);
            this.Controls.Add(this.buttonSetCrane);
            this.Controls.Add(this.pictureBoxParking);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormParking";
            this.Text = "Парковка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetCrane;
        private System.Windows.Forms.Button buttonSetSuperCrane;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.ListBox listBoxParking;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button AddParking;
        private System.Windows.Forms.Button DelParking;
        private System.Windows.Forms.Label label3;
    }
}