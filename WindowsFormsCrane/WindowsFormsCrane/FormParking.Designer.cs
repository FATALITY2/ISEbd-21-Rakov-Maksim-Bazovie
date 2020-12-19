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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSetCrane
            // 
            this.buttonSetCrane.Location = new System.Drawing.Point(497, 281);
            this.buttonSetCrane.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetCrane.Name = "buttonSetCrane";
            this.buttonSetCrane.Size = new System.Drawing.Size(104, 21);
            this.buttonSetCrane.TabIndex = 1;
            this.buttonSetCrane.Text = "Припарковать кран";
            this.buttonSetCrane.UseVisualStyleBackColor = true;
            this.buttonSetCrane.Click += new System.EventHandler(this.buttonSetCrane_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBoxNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonTakeCar);
            this.groupBox1.Location = new System.Drawing.Point(494, 306);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(104, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать кран";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Место :";
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(74, 39);
            this.maskedTextBoxNumber.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(26, 20);
            this.maskedTextBoxNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // buttonTakeCar
            // 
            this.buttonTakeCar.Location = new System.Drawing.Point(25, 62);
            this.buttonTakeCar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTakeCar.Name = "buttonTakeCar";
            this.buttonTakeCar.Size = new System.Drawing.Size(64, 19);
            this.buttonTakeCar.TabIndex = 0;
            this.buttonTakeCar.Text = "Забрать";
            this.buttonTakeCar.UseVisualStyleBackColor = true;
            this.buttonTakeCar.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 36);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(536, 361);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            this.pictureBoxParking.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // listBoxParking
            // 
            this.listBoxParking.FormattingEnabled = true;
            this.listBoxParking.Location = new System.Drawing.Point(496, 131);
            this.listBoxParking.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxParking.Name = "listBoxParking";
            this.listBoxParking.Size = new System.Drawing.Size(104, 69);
            this.listBoxParking.TabIndex = 4;
            this.listBoxParking.Click += new System.EventHandler(this.listBoxParking_SelectedIndexChanged);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(497, 63);
            this.textBoxNewLevelName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(97, 20);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // AddParking
            // 
            this.AddParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddParking.Location = new System.Drawing.Point(496, 85);
            this.AddParking.Name = "AddParking";
            this.AddParking.Size = new System.Drawing.Size(103, 33);
            this.AddParking.TabIndex = 6;
            this.AddParking.Text = "Добавить парковку";
            this.AddParking.UseVisualStyleBackColor = true;
            this.AddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // DelParking
            // 
            this.DelParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelParking.Location = new System.Drawing.Point(494, 204);
            this.DelParking.Name = "DelParking";
            this.DelParking.Size = new System.Drawing.Size(104, 37);
            this.DelParking.TabIndex = 7;
            this.DelParking.Text = "Удалить парковку";
            this.DelParking.UseVisualStyleBackColor = true;
            this.DelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Парковки:";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(598, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "Файл";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(494, 248);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(107, 23);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 405);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DelParking);
            this.Controls.Add(this.AddParking);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxParking);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetCrane);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormParking";
            this.Text = "Парковка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetCrane;
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
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}