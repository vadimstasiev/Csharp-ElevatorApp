namespace ElevatorApp
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lvl1 = new System.Windows.Forms.GroupBox();
            this.lvl0 = new System.Windows.Forms.GroupBox();
            this.btnCall1 = new System.Windows.Forms.Button();
            this.btnCall0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lvl2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCloseDoors = new System.Windows.Forms.Button();
            this.btnOpenDoors = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnLevel0 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.lvl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(632, 12);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(303, 310);
            this.textBox3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ElevatorApp.Properties.Resources.door;
            this.pictureBox2.Location = new System.Drawing.Point(15, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 165);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ElevatorApp.Properties.Resources.elevator;
            this.pictureBox1.Location = new System.Drawing.Point(15, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 165);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ElevatorApp.Properties.Resources.door;
            this.pictureBox3.Location = new System.Drawing.Point(74, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 165);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // lvl1
            // 
            this.lvl1.Controls.Add(this.pictureBox2);
            this.lvl1.Controls.Add(this.pictureBox3);
            this.lvl1.Controls.Add(this.pictureBox1);
            this.lvl1.Location = new System.Drawing.Point(55, 219);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(151, 201);
            this.lvl1.TabIndex = 6;
            this.lvl1.TabStop = false;
            this.lvl1.Text = "level 1";
            // 
            // lvl0
            // 
            this.lvl0.Location = new System.Drawing.Point(55, 426);
            this.lvl0.Name = "lvl0";
            this.lvl0.Size = new System.Drawing.Size(151, 201);
            this.lvl0.TabIndex = 7;
            this.lvl0.TabStop = false;
            this.lvl0.Text = "level 0";
            this.lvl0.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnCall1
            // 
            this.btnCall1.Location = new System.Drawing.Point(14, 315);
            this.btnCall1.Name = "btnCall1";
            this.btnCall1.Size = new System.Drawing.Size(35, 23);
            this.btnCall1.TabIndex = 8;
            this.btnCall1.Text = "Call";
            this.btnCall1.UseVisualStyleBackColor = true;
            this.btnCall1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCall0
            // 
            this.btnCall0.Location = new System.Drawing.Point(14, 515);
            this.btnCall0.Name = "btnCall0";
            this.btnCall0.Size = new System.Drawing.Size(35, 23);
            this.btnCall0.TabIndex = 9;
            this.btnCall0.Text = "Call";
            this.btnCall0.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Call";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lvl2
            // 
            this.lvl2.Location = new System.Drawing.Point(55, 12);
            this.lvl2.Name = "lvl2";
            this.lvl2.Size = new System.Drawing.Size(151, 201);
            this.lvl2.TabIndex = 10;
            this.lvl2.TabStop = false;
            this.lvl2.Text = "level 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCloseDoors);
            this.groupBox1.Controls.Add(this.btnOpenDoors);
            this.groupBox1.Controls.Add(this.btnLevel3);
            this.groupBox1.Controls.Add(this.btnLevel1);
            this.groupBox1.Controls.Add(this.btnLevel0);
            this.groupBox1.Location = new System.Drawing.Point(290, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 176);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Internal Elevator Buttons";
            // 
            // btnCloseDoors
            // 
            this.btnCloseDoors.Location = new System.Drawing.Point(134, 105);
            this.btnCloseDoors.Name = "btnCloseDoors";
            this.btnCloseDoors.Size = new System.Drawing.Size(73, 33);
            this.btnCloseDoors.TabIndex = 4;
            this.btnCloseDoors.Text = "Close Doors";
            this.btnCloseDoors.UseVisualStyleBackColor = true;
            // 
            // btnOpenDoors
            // 
            this.btnOpenDoors.Location = new System.Drawing.Point(55, 105);
            this.btnOpenDoors.Name = "btnOpenDoors";
            this.btnOpenDoors.Size = new System.Drawing.Size(73, 33);
            this.btnOpenDoors.TabIndex = 3;
            this.btnOpenDoors.Text = "Open Doors";
            this.btnOpenDoors.UseVisualStyleBackColor = true;
            // 
            // btnLevel3
            // 
            this.btnLevel3.Location = new System.Drawing.Point(170, 66);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(64, 33);
            this.btnLevel3.TabIndex = 2;
            this.btnLevel3.Text = "Level 2";
            this.btnLevel3.UseVisualStyleBackColor = true;
            // 
            // btnLevel1
            // 
            this.btnLevel1.Location = new System.Drawing.Point(100, 66);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(64, 33);
            this.btnLevel1.TabIndex = 1;
            this.btnLevel1.Text = "Level 1";
            this.btnLevel1.UseVisualStyleBackColor = true;
            // 
            // btnLevel0
            // 
            this.btnLevel0.Location = new System.Drawing.Point(30, 66);
            this.btnLevel0.Name = "btnLevel0";
            this.btnLevel0.Size = new System.Drawing.Size(64, 33);
            this.btnLevel0.TabIndex = 0;
            this.btnLevel0.Text = "Level 0";
            this.btnLevel0.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 659);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvl2);
            this.Controls.Add(this.btnCall0);
            this.Controls.Add(this.btnCall1);
            this.Controls.Add(this.lvl0);
            this.Controls.Add(this.lvl1);
            this.Controls.Add(this.textBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.lvl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox lvl1;
        private System.Windows.Forms.GroupBox lvl0;
        private System.Windows.Forms.Button btnCall1;
        private System.Windows.Forms.Button btnCall0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox lvl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnLevel0;
        private System.Windows.Forms.Button btnCloseDoors;
        private System.Windows.Forms.Button btnOpenDoors;
    }
}

