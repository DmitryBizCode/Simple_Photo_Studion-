namespace PhotoStudio
{
    partial class Reports
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
            this.label2 = new System.Windows.Forms.Label();
            this.Summ = new System.Windows.Forms.Label();
            this.ClearSumm = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Countp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумарний дохід студії:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Чистий дохід:";
            // 
            // Summ
            // 
            this.Summ.AutoSize = true;
            this.Summ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Summ.Location = new System.Drawing.Point(255, 100);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(62, 25);
            this.Summ.TabIndex = 1;
            this.Summ.Text = "0 грн";
            // 
            // ClearSumm
            // 
            this.ClearSumm.AutoSize = true;
            this.ClearSumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearSumm.Location = new System.Drawing.Point(255, 172);
            this.ClearSumm.Name = "ClearSumm";
            this.ClearSumm.Size = new System.Drawing.Size(62, 25);
            this.ClearSumm.TabIndex = 1;
            this.ClearSumm.Text = "0 грн";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Кількість замовлень:";
            // 
            // Countp
            // 
            this.Countp.AutoSize = true;
            this.Countp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Countp.Location = new System.Drawing.Point(255, 235);
            this.Countp.Name = "Countp";
            this.Countp.Size = new System.Drawing.Size(24, 25);
            this.Countp.TabIndex = 1;
            this.Countp.Text = "0";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 402);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Countp);
            this.Controls.Add(this.ClearSumm);
            this.Controls.Add(this.Summ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reports";
            this.Text = "Фото-Студія";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Summ;
        private System.Windows.Forms.Label ClearSumm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Countp;
    }
}