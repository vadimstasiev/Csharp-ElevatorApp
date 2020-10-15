namespace Practical_3_Ex_2
{
    partial class frmListBox_Exercise
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
            this.lblListBox_Exercise = new System.Windows.Forms.Label();
            this.lblListLetter = new System.Windows.Forms.Label();
            this.lblListNumber = new System.Windows.Forms.Label();
            this.lstLetter = new System.Windows.Forms.ListBox();
            this.lstNumber = new System.Windows.Forms.ListBox();
            this.btnRightShift = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLeftShift = new System.Windows.Forms.Button();
            this.txtAddLetter = new System.Windows.Forms.TextBox();
            this.txtAddNumber = new System.Windows.Forms.TextBox();
            this.lblAddLetter = new System.Windows.Forms.Label();
            this.lblAddNumber = new System.Windows.Forms.Label();
            this.btnAddLetter = new System.Windows.Forms.Button();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.btnSortLetters = new System.Windows.Forms.Button();
            this.btnSortNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblListBox_Exercise
            // 
            this.lblListBox_Exercise.AutoSize = true;
            this.lblListBox_Exercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblListBox_Exercise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListBox_Exercise.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListBox_Exercise.Location = new System.Drawing.Point(22, 22);
            this.lblListBox_Exercise.Name = "lblListBox_Exercise";
            this.lblListBox_Exercise.Size = new System.Drawing.Size(156, 21);
            this.lblListBox_Exercise.TabIndex = 0;
            this.lblListBox_Exercise.Text = "List Box Exercise";
            // 
            // lblListLetter
            // 
            this.lblListLetter.AutoSize = true;
            this.lblListLetter.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListLetter.Location = new System.Drawing.Point(22, 64);
            this.lblListLetter.Name = "lblListLetter";
            this.lblListLetter.Size = new System.Drawing.Size(102, 15);
            this.lblListLetter.TabIndex = 1;
            this.lblListLetter.Text = "List of Letters";
            // 
            // lblListNumber
            // 
            this.lblListNumber.AutoSize = true;
            this.lblListNumber.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListNumber.Location = new System.Drawing.Point(179, 64);
            this.lblListNumber.Name = "lblListNumber";
            this.lblListNumber.Size = new System.Drawing.Size(118, 15);
            this.lblListNumber.TabIndex = 2;
            this.lblListNumber.Text = "List of Numbers";
            // 
            // lstLetter
            // 
            this.lstLetter.FormattingEnabled = true;
            this.lstLetter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.lstLetter.Location = new System.Drawing.Point(25, 93);
            this.lstLetter.Name = "lstLetter";
            this.lstLetter.Size = new System.Drawing.Size(120, 95);
            this.lstLetter.TabIndex = 3;
            // 
            // lstNumber
            // 
            this.lstNumber.FormattingEnabled = true;
            this.lstNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lstNumber.Location = new System.Drawing.Point(182, 93);
            this.lstNumber.Name = "lstNumber";
            this.lstNumber.Size = new System.Drawing.Size(120, 95);
            this.lstNumber.TabIndex = 4;
            // 
            // btnRightShift
            // 
            this.btnRightShift.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightShift.Location = new System.Drawing.Point(25, 215);
            this.btnRightShift.Name = "btnRightShift";
            this.btnRightShift.Size = new System.Drawing.Size(89, 23);
            this.btnRightShift.TabIndex = 5;
            this.btnRightShift.Text = "Right Shift";
            this.btnRightShift.UseVisualStyleBackColor = true;
            this.btnRightShift.Click += new System.EventHandler(this.btnRightShift_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(24, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLeftShift
            // 
            this.btnLeftShift.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftShift.Location = new System.Drawing.Point(182, 215);
            this.btnLeftShift.Name = "btnLeftShift";
            this.btnLeftShift.Size = new System.Drawing.Size(89, 23);
            this.btnLeftShift.TabIndex = 8;
            this.btnLeftShift.Text = "Left Shift";
            this.btnLeftShift.UseVisualStyleBackColor = true;
            this.btnLeftShift.Click += new System.EventHandler(this.btnLeftShift_Click);
            // 
            // txtAddLetter
            // 
            this.txtAddLetter.Location = new System.Drawing.Point(24, 293);
            this.txtAddLetter.Name = "txtAddLetter";
            this.txtAddLetter.Size = new System.Drawing.Size(100, 20);
            this.txtAddLetter.TabIndex = 9;
            // 
            // txtAddNumber
            // 
            this.txtAddNumber.Location = new System.Drawing.Point(182, 293);
            this.txtAddNumber.Name = "txtAddNumber";
            this.txtAddNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAddNumber.TabIndex = 10;
            // 
            // lblAddLetter
            // 
            this.lblAddLetter.AutoSize = true;
            this.lblAddLetter.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLetter.Location = new System.Drawing.Point(12, 262);
            this.lblAddLetter.Name = "lblAddLetter";
            this.lblAddLetter.Size = new System.Drawing.Size(159, 15);
            this.lblAddLetter.TabIndex = 11;
            this.lblAddLetter.Text = "Enter Letter to Add...";
            // 
            // lblAddNumber
            // 
            this.lblAddNumber.AutoSize = true;
            this.lblAddNumber.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNumber.Location = new System.Drawing.Point(179, 262);
            this.lblAddNumber.Name = "lblAddNumber";
            this.lblAddNumber.Size = new System.Drawing.Size(175, 15);
            this.lblAddNumber.TabIndex = 12;
            this.lblAddNumber.Text = "Enter Number to Add...";
            this.lblAddNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddLetter
            // 
            this.btnAddLetter.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLetter.Location = new System.Drawing.Point(25, 329);
            this.btnAddLetter.Name = "btnAddLetter";
            this.btnAddLetter.Size = new System.Drawing.Size(99, 21);
            this.btnAddLetter.TabIndex = 13;
            this.btnAddLetter.Text = "Add Letter";
            this.btnAddLetter.UseVisualStyleBackColor = true;
            this.btnAddLetter.Click += new System.EventHandler(this.btnAddLetter_Click);
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNumber.Location = new System.Drawing.Point(182, 329);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(100, 21);
            this.btnAddNumber.TabIndex = 14;
            this.btnAddNumber.Text = "Add Number";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // btnSortLetters
            // 
            this.btnSortLetters.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortLetters.Location = new System.Drawing.Point(25, 371);
            this.btnSortLetters.Name = "btnSortLetters";
            this.btnSortLetters.Size = new System.Drawing.Size(114, 21);
            this.btnSortLetters.TabIndex = 15;
            this.btnSortLetters.Text = "Sort Letters";
            this.btnSortLetters.UseVisualStyleBackColor = true;
            this.btnSortLetters.Click += new System.EventHandler(this.btnSortLetters_Click);
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNumbers.Location = new System.Drawing.Point(182, 371);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(115, 21);
            this.btnSortNumbers.TabIndex = 16;
            this.btnSortNumbers.Text = "Sort Numbers";
            this.btnSortNumbers.UseVisualStyleBackColor = true;
            this.btnSortNumbers.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmListBox_Exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 445);
            this.Controls.Add(this.btnSortNumbers);
            this.Controls.Add(this.btnSortLetters);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.btnAddLetter);
            this.Controls.Add(this.lblAddNumber);
            this.Controls.Add(this.lblAddLetter);
            this.Controls.Add(this.txtAddNumber);
            this.Controls.Add(this.txtAddLetter);
            this.Controls.Add(this.btnLeftShift);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRightShift);
            this.Controls.Add(this.lstNumber);
            this.Controls.Add(this.lstLetter);
            this.Controls.Add(this.lblListNumber);
            this.Controls.Add(this.lblListLetter);
            this.Controls.Add(this.lblListBox_Exercise);
            this.Name = "frmListBox_Exercise";
            this.Text = "List Boc Exercise";
            this.Load += new System.EventHandler(this.frmListBox_Exercise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListBox_Exercise;
        private System.Windows.Forms.Label lblListLetter;
        private System.Windows.Forms.Label lblListNumber;
        private System.Windows.Forms.ListBox lstLetter;
        private System.Windows.Forms.ListBox lstNumber;
        private System.Windows.Forms.Button btnRightShift;
        // private System.Windows.Forms.Button btnLeftShift;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLeftShift;
        private System.Windows.Forms.TextBox txtAddLetter;
        private System.Windows.Forms.TextBox txtAddNumber;
        private System.Windows.Forms.Label lblAddLetter;
        private System.Windows.Forms.Label lblAddNumber;
        private System.Windows.Forms.Button btnAddLetter;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Button btnSortLetters;
        private System.Windows.Forms.Button btnSortNumbers;
    }
}

