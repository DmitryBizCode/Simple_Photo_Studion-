namespace PhotoStudio
{
    partial class AddnewOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Package = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeOfPackege = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Employer = new System.Windows.Forms.ComboBox();
            this.District = new System.Windows.Forms.TextBox();
            this.Datetime = new System.Windows.Forms.DateTimePicker();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.TimeCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Піб клієнта";
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(217, 108);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(100, 26);
            this.ClientName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Місце";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Пакет послуг";
            // 
            // Package
            // 
            this.Package.FormattingEnabled = true;
            this.Package.Location = new System.Drawing.Point(217, 258);
            this.Package.Name = "Package";
            this.Package.Size = new System.Drawing.Size(121, 28);
            this.Package.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Тип послуги";
            // 
            // TypeOfPackege
            // 
            this.TypeOfPackege.FormattingEnabled = true;
            this.TypeOfPackege.Location = new System.Drawing.Point(217, 344);
            this.TypeOfPackege.Name = "TypeOfPackege";
            this.TypeOfPackege.Size = new System.Drawing.Size(121, 28);
            this.TypeOfPackege.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Дата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Час";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Кількість/години";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 665);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Працівник";
            // 
            // Employer
            // 
            this.Employer.FormattingEnabled = true;
            this.Employer.Location = new System.Drawing.Point(217, 656);
            this.Employer.Name = "Employer";
            this.Employer.Size = new System.Drawing.Size(121, 28);
            this.Employer.TabIndex = 2;
            // 
            // District
            // 
            this.District.Location = new System.Drawing.Point(217, 185);
            this.District.Name = "District";
            this.District.Size = new System.Drawing.Size(100, 26);
            this.District.TabIndex = 1;
            // 
            // Datetime
            // 
            this.Datetime.Location = new System.Drawing.Point(185, 450);
            this.Datetime.Name = "Datetime";
            this.Datetime.Size = new System.Drawing.Size(200, 26);
            this.Datetime.TabIndex = 5;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(185, 530);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(200, 26);
            this.Time.TabIndex = 6;
            // 
            // TimeCount
            // 
            this.TimeCount.Location = new System.Drawing.Point(217, 602);
            this.TimeCount.Name = "TimeCount";
            this.TimeCount.Size = new System.Drawing.Size(100, 26);
            this.TimeCount.TabIndex = 1;
            // 
            // AddnewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 708);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Datetime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Employer);
            this.Controls.Add(this.TypeOfPackege);
            this.Controls.Add(this.Package);
            this.Controls.Add(this.TimeCount);
            this.Controls.Add(this.District);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddnewOrder";
            this.Text = "AddnewOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Package;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypeOfPackege;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Employer;
        private System.Windows.Forms.TextBox District;
        private System.Windows.Forms.DateTimePicker Datetime;
        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.TextBox TimeCount;
    }
}