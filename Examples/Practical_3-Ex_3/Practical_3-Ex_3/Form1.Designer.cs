namespace Practical_3_Ex_3
{
    partial class Form1
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
            this.LblLocalTime = new System.Windows.Forms.Label();
            this.LblUTCTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblLocalTime
            // 
            this.LblLocalTime.AutoSize = true;
            this.LblLocalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocalTime.Location = new System.Drawing.Point(70, 60);
            this.LblLocalTime.Name = "LblLocalTime";
            this.LblLocalTime.Size = new System.Drawing.Size(0, 25);
            this.LblLocalTime.TabIndex = 0;
            // 
            // LblUTCTime
            // 
            this.LblUTCTime.AutoSize = true;
            this.LblUTCTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUTCTime.Location = new System.Drawing.Point(70, 174);
            this.LblUTCTime.Name = "LblUTCTime";
            this.LblUTCTime.Size = new System.Drawing.Size(0, 25);
            this.LblUTCTime.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 288);
            this.Controls.Add(this.LblUTCTime);
            this.Controls.Add(this.LblLocalTime);
            this.Name = "Form1";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label LblLocalTime;
        private System.Windows.Forms.Label LblUTCTime;
    }
}

