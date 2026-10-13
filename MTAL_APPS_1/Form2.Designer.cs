namespace MTAL_APPS_1
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yaricap = new System.Windows.Forms.TextBox();
            this.cvr = new System.Windows.Forms.TextBox();
            this.aln = new System.Windows.Forms.TextBox();
            this.hesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yarıçap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çevre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alan";
            // 
            // yaricap
            // 
            this.yaricap.Location = new System.Drawing.Point(187, 33);
            this.yaricap.Name = "yaricap";
            this.yaricap.Size = new System.Drawing.Size(100, 20);
            this.yaricap.TabIndex = 4;
            // 
            // cvr
            // 
            this.cvr.Enabled = false;
            this.cvr.Location = new System.Drawing.Point(187, 117);
            this.cvr.Name = "cvr";
            this.cvr.Size = new System.Drawing.Size(100, 20);
            this.cvr.TabIndex = 6;
            // 
            // aln
            // 
            this.aln.Enabled = false;
            this.aln.Location = new System.Drawing.Point(187, 148);
            this.aln.Name = "aln";
            this.aln.Size = new System.Drawing.Size(100, 20);
            this.aln.TabIndex = 7;
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(49, 72);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(238, 23);
            this.hesapla.TabIndex = 8;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.aln);
            this.Controls.Add(this.cvr);
            this.Controls.Add(this.yaricap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yaricap;
        private System.Windows.Forms.TextBox cvr;
        private System.Windows.Forms.TextBox aln;
        private System.Windows.Forms.Button hesapla;
    }
}