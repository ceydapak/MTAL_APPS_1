namespace MTAL_APPS_1
{
    partial class Form3
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
            this.hesapla = new System.Windows.Forms.Button();
            this.ort = new System.Windows.Forms.TextBox();
            this.per = new System.Windows.Forms.TextBox();
            this.ikinciNot = new System.Windows.Forms.TextBox();
            this.ilkNot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(28, 100);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(238, 23);
            this.hesapla.TabIndex = 17;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // ort
            // 
            this.ort.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ort.Enabled = false;
            this.ort.Location = new System.Drawing.Point(166, 172);
            this.ort.Name = "ort";
            this.ort.Size = new System.Drawing.Size(100, 20);
            this.ort.TabIndex = 16;
            // 
            // per
            // 
            this.per.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.per.Location = new System.Drawing.Point(166, 141);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(100, 20);
            this.per.TabIndex = 15;
            // 
            // ikinciNot
            // 
            this.ikinciNot.Location = new System.Drawing.Point(166, 61);
            this.ikinciNot.Name = "ikinciNot";
            this.ikinciNot.Size = new System.Drawing.Size(100, 20);
            this.ikinciNot.TabIndex = 14;
            // 
            // ilkNot
            // 
            this.ilkNot.Location = new System.Drawing.Point(166, 27);
            this.ilkNot.Name = "ilkNot";
            this.ilkNot.Size = new System.Drawing.Size(100, 20);
            this.ilkNot.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ortalama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Performans";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "2. Yazılı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "1. Yazılı";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.ort);
            this.Controls.Add(this.per);
            this.Controls.Add(this.ikinciNot);
            this.Controls.Add(this.ilkNot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.TextBox ort;
        private System.Windows.Forms.TextBox per;
        private System.Windows.Forms.TextBox ikinciNot;
        private System.Windows.Forms.TextBox ilkNot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}