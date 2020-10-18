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
            this.components = new System.ComponentModel.Container();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.picLeftDoor = new System.Windows.Forms.PictureBox();
            this.picElevator = new System.Windows.Forms.PictureBox();
            this.picRightDoor = new System.Windows.Forms.PictureBox();
            this.lvl1 = new System.Windows.Forms.GroupBox();
            this.lvl0 = new System.Windows.Forms.GroupBox();
            this.btnCall1 = new System.Windows.Forms.Button();
            this.btnCall0 = new System.Windows.Forms.Button();
            this.btnCall2 = new System.Windows.Forms.Button();
            this.lvl2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCloseDoors = new System.Windows.Forms.Button();
            this.btnOpenDoors = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnLevel0 = new System.Windows.Forms.Button();
            this.doorsTick = new System.Windows.Forms.Timer(this.components);
            this.elevatorTick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLeftDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightDoor)).BeginInit();
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
            // picLeftDoor
            // 
            this.picLeftDoor.BackgroundImage = global::ElevatorApp.Properties.Resources.door;
            this.picLeftDoor.Location = new System.Drawing.Point(70, 245);
            this.picLeftDoor.Name = "picLeftDoor";
            this.picLeftDoor.Size = new System.Drawing.Size(61, 165);
            this.picLeftDoor.TabIndex = 4;
            this.picLeftDoor.TabStop = false;
            // 
            // picElevator
            // 
            this.picElevator.BackgroundImage = global::ElevatorApp.Properties.Resources.elevator;
            this.picElevator.Location = new System.Drawing.Point(70, 245);
            this.picElevator.Name = "picElevator";
            this.picElevator.Size = new System.Drawing.Size(120, 165);
            this.picElevator.TabIndex = 3;
            this.picElevator.TabStop = false;
            // 
            // picRightDoor
            // 
            this.picRightDoor.BackgroundImage = global::ElevatorApp.Properties.Resources.door;
            this.picRightDoor.Location = new System.Drawing.Point(130, 245);
            this.picRightDoor.Name = "picRightDoor";
            this.picRightDoor.Size = new System.Drawing.Size(61, 165);
            this.picRightDoor.TabIndex = 5;
            this.picRightDoor.TabStop = false;
            // 
            // lvl1
            // 
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
            // 
            // btnCall1
            // 
            this.btnCall1.Location = new System.Drawing.Point(14, 315);
            this.btnCall1.Name = "btnCall1";
            this.btnCall1.Size = new System.Drawing.Size(35, 23);
            this.btnCall1.TabIndex = 8;
            this.btnCall1.Text = "Call";
            this.btnCall1.UseVisualStyleBackColor = true;
            this.btnCall1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // btnCall0
            // 
            this.btnCall0.Location = new System.Drawing.Point(14, 515);
            this.btnCall0.Name = "btnCall0";
            this.btnCall0.Size = new System.Drawing.Size(35, 23);
            this.btnCall0.TabIndex = 9;
            this.btnCall0.Text = "Call";
            this.btnCall0.UseVisualStyleBackColor = true;
            this.btnCall0.Click += new System.EventHandler(this.btnLevel0_Click);
            // 
            // btnCall2
            // 
            this.btnCall2.Location = new System.Drawing.Point(14, 108);
            this.btnCall2.Name = "btnCall2";
            this.btnCall2.Size = new System.Drawing.Size(35, 23);
            this.btnCall2.TabIndex = 11;
            this.btnCall2.Text = "Call";
            this.btnCall2.UseVisualStyleBackColor = true;
            this.btnCall2.Click += new System.EventHandler(this.btnLevel2_Click);
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
            this.groupBox1.Controls.Add(this.btnLevel2);
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
            this.btnCloseDoors.Click += new System.EventHandler(this.btnCloseDoors_Click);
            // 
            // btnOpenDoors
            // 
            this.btnOpenDoors.Location = new System.Drawing.Point(55, 105);
            this.btnOpenDoors.Name = "btnOpenDoors";
            this.btnOpenDoors.Size = new System.Drawing.Size(73, 33);
            this.btnOpenDoors.TabIndex = 3;
            this.btnOpenDoors.Text = "Open Doors";
            this.btnOpenDoors.UseVisualStyleBackColor = true;
            this.btnOpenDoors.Click += new System.EventHandler(this.btnOpenDoors_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.Location = new System.Drawing.Point(170, 66);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(64, 33);
            this.btnLevel2.TabIndex = 2;
            this.btnLevel2.Text = "Level 2";
            this.btnLevel2.UseVisualStyleBackColor = true;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
            // 
            // btnLevel1
            // 
            this.btnLevel1.Location = new System.Drawing.Point(100, 66);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(64, 33);
            this.btnLevel1.TabIndex = 1;
            this.btnLevel1.Text = "Level 1";
            this.btnLevel1.UseVisualStyleBackColor = true;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // btnLevel0
            // 
            this.btnLevel0.Location = new System.Drawing.Point(30, 66);
            this.btnLevel0.Name = "btnLevel0";
            this.btnLevel0.Size = new System.Drawing.Size(64, 33);
            this.btnLevel0.TabIndex = 0;
            this.btnLevel0.Text = "Level 0";
            this.btnLevel0.UseVisualStyleBackColor = true;
            this.btnLevel0.Click += new System.EventHandler(this.btnLevel0_Click);
            // 
            // doorsTick
            // 
            this.doorsTick.Interval = 1;
            this.doorsTick.Tick += new System.EventHandler(this.doors_tick_animation);
            // 
            // elevatorTick
            // 
            this.elevatorTick.Interval = 1;
            this.elevatorTick.Tick += new System.EventHandler(this.elevator_tick_animation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 659);
            this.Controls.Add(this.picRightDoor);
            this.Controls.Add(this.picLeftDoor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picElevator);
            this.Controls.Add(this.btnCall2);
            this.Controls.Add(this.lvl2);
            this.Controls.Add(this.btnCall0);
            this.Controls.Add(this.btnCall1);
            this.Controls.Add(this.lvl0);
            this.Controls.Add(this.lvl1);
            this.Controls.Add(this.textBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLeftDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightDoor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox picElevator;
        private System.Windows.Forms.PictureBox picLeftDoor;
        private System.Windows.Forms.PictureBox picRightDoor;
        private System.Windows.Forms.GroupBox lvl1;
        private System.Windows.Forms.GroupBox lvl0;
        private System.Windows.Forms.Button btnCall1;
        private System.Windows.Forms.Button btnCall0;
        private System.Windows.Forms.Button btnCall2;
        private System.Windows.Forms.GroupBox lvl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnLevel0;
        private System.Windows.Forms.Button btnCloseDoors;
        private System.Windows.Forms.Button btnOpenDoors;
        private System.Windows.Forms.Timer doorsTick;
        private System.Windows.Forms.Timer elevatorTick;
    }
}

