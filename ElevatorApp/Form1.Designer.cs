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
            this.doorsTick = new System.Windows.Forms.Timer(this.components);
            this.elevatorTick = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picRightDoor = new System.Windows.Forms.PictureBox();
            this.picLeftDoor = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCurrentFloor = new System.Windows.Forms.Label();
            this.btnCloseDoors = new System.Windows.Forms.Button();
            this.btnOpenDoors = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnLevel0 = new System.Windows.Forms.Button();
            this.picElevator = new System.Windows.Forms.PictureBox();
            this.btnCall2 = new System.Windows.Forms.Button();
            this.lvl2 = new System.Windows.Forms.GroupBox();
            this.btnCall0 = new System.Windows.Forms.Button();
            this.btnCall1 = new System.Windows.Forms.Button();
            this.lvl0 = new System.Windows.Forms.GroupBox();
            this.lvl1 = new System.Windows.Forms.GroupBox();
            this.lblCurrentFloor0 = new System.Windows.Forms.Label();
            this.lblCurrentFloor1 = new System.Windows.Forms.Label();
            this.lblCurrentFloor2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblLogsTitle = new System.Windows.Forms.Label();
            this.txtBoxLogs = new System.Windows.Forms.TextBox();
            this.lblCurrentTxt0 = new System.Windows.Forms.Label();
            this.lblCurrentTxt1 = new System.Windows.Forms.Label();
            this.lblCurrentTxt2 = new System.Windows.Forms.Label();
            this.lblCurrentTxt3 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRightDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftDoor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picElevator)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(996, 739);
            this.tabControl.TabIndex = 13;
            this.tabControl.Click += new System.EventHandler(this.tabControlClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picRightDoor);
            this.tabPage1.Controls.Add(this.picLeftDoor);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.picElevator);
            this.tabPage1.Controls.Add(this.btnCall2);
            this.tabPage1.Controls.Add(this.lvl2);
            this.tabPage1.Controls.Add(this.btnCall0);
            this.tabPage1.Controls.Add(this.btnCall1);
            this.tabPage1.Controls.Add(this.lvl0);
            this.tabPage1.Controls.Add(this.lvl1);
            this.tabPage1.Controls.Add(this.lblCurrentFloor0);
            this.tabPage1.Controls.Add(this.lblCurrentFloor1);
            this.tabPage1.Controls.Add(this.lblCurrentFloor2);
            this.tabPage1.Controls.Add(this.lblCurrentTxt3);
            this.tabPage1.Controls.Add(this.lblCurrentTxt2);
            this.tabPage1.Controls.Add(this.lblCurrentTxt1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(988, 713);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Elevator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // picRightDoor
            // 
            this.picRightDoor.BackgroundImage = global::ElevatorApp.Properties.Resources.door;
            this.picRightDoor.Location = new System.Drawing.Point(155, 251);
            this.picRightDoor.Name = "picRightDoor";
            this.picRightDoor.Size = new System.Drawing.Size(61, 165);
            this.picRightDoor.TabIndex = 15;
            this.picRightDoor.TabStop = false;
            // 
            // picLeftDoor
            // 
            this.picLeftDoor.BackgroundImage = global::ElevatorApp.Properties.Resources.door;
            this.picLeftDoor.Location = new System.Drawing.Point(95, 251);
            this.picLeftDoor.Name = "picLeftDoor";
            this.picLeftDoor.Size = new System.Drawing.Size(61, 165);
            this.picLeftDoor.TabIndex = 14;
            this.picLeftDoor.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCurrentTxt0);
            this.groupBox1.Controls.Add(this.lblCurrentFloor);
            this.groupBox1.Controls.Add(this.btnCloseDoors);
            this.groupBox1.Controls.Add(this.btnOpenDoors);
            this.groupBox1.Controls.Add(this.btnLevel2);
            this.groupBox1.Controls.Add(this.btnLevel1);
            this.groupBox1.Controls.Add(this.btnLevel0);
            this.groupBox1.Location = new System.Drawing.Point(295, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 176);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Internal Elevator Buttons";
            // 
            // lblCurrentFloor
            // 
            this.lblCurrentFloor.AutoSize = true;
            this.lblCurrentFloor.Location = new System.Drawing.Point(124, 33);
            this.lblCurrentFloor.Name = "lblCurrentFloor";
            this.lblCurrentFloor.Size = new System.Drawing.Size(12, 13);
            this.lblCurrentFloor.TabIndex = 5;
            this.lblCurrentFloor.Text = "/";
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
            // picElevator
            // 
            this.picElevator.BackgroundImage = global::ElevatorApp.Properties.Resources.elevator;
            this.picElevator.Location = new System.Drawing.Point(95, 251);
            this.picElevator.Name = "picElevator";
            this.picElevator.Size = new System.Drawing.Size(120, 165);
            this.picElevator.TabIndex = 13;
            this.picElevator.TabStop = false;
            // 
            // lvl2
            // 
            this.lvl2.Location = new System.Drawing.Point(80, 18);
            this.lvl2.Name = "lvl2";
            this.lvl2.Size = new System.Drawing.Size(151, 201);
            this.lvl2.TabIndex = 20;
            this.lvl2.TabStop = false;
            this.lvl2.Text = "level 2";
            // 
            // btnCall0
            // 
            this.btnCall0.Location = new System.Drawing.Point(39, 521);
            this.btnCall0.Name = "btnCall0";
            this.btnCall0.Size = new System.Drawing.Size(35, 23);
            this.btnCall0.TabIndex = 19;
            this.btnCall0.Text = "Call";
            this.btnCall0.UseVisualStyleBackColor = true;
            this.btnCall0.Click += new System.EventHandler(this.btnLevel0_Click);
            // 
            // btnCall1
            // 
            this.btnCall1.Location = new System.Drawing.Point(39, 321);
            this.btnCall1.Name = "btnCall1";
            this.btnCall1.Size = new System.Drawing.Size(35, 23);
            this.btnCall1.TabIndex = 18;
            this.btnCall1.Text = "Call";
            this.btnCall1.UseVisualStyleBackColor = true;
            this.btnCall1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // btnCall2
            // 
            this.btnCall2.Location = new System.Drawing.Point(39, 114);
            this.btnCall2.Name = "btnCall2";
            this.btnCall2.Size = new System.Drawing.Size(35, 23);
            this.btnCall2.TabIndex = 21;
            this.btnCall2.Text = "Call";
            this.btnCall2.UseVisualStyleBackColor = true;
            this.btnCall2.Click += new System.EventHandler(this.btnLevel2_Click);
            // 
            // lvl0
            // 
            this.lvl0.Location = new System.Drawing.Point(80, 432);
            this.lvl0.Name = "lvl0";
            this.lvl0.Size = new System.Drawing.Size(151, 201);
            this.lvl0.TabIndex = 17;
            this.lvl0.TabStop = false;
            this.lvl0.Text = "level 0";
            // 
            // lvl1
            // 
            this.lvl1.Location = new System.Drawing.Point(80, 225);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(151, 201);
            this.lvl1.TabIndex = 16;
            this.lvl1.TabStop = false;
            this.lvl1.Text = "level 1";
            // 
            // lblCurrentFloor0
            // 
            this.lblCurrentFloor0.AutoSize = true;
            this.lblCurrentFloor0.Location = new System.Drawing.Point(48, 495);
            this.lblCurrentFloor0.Name = "lblCurrentFloor0";
            this.lblCurrentFloor0.Size = new System.Drawing.Size(12, 13);
            this.lblCurrentFloor0.TabIndex = 25;
            this.lblCurrentFloor0.Text = "\\";
            // 
            // lblCurrentFloor1
            // 
            this.lblCurrentFloor1.AutoSize = true;
            this.lblCurrentFloor1.Location = new System.Drawing.Point(48, 294);
            this.lblCurrentFloor1.Name = "lblCurrentFloor1";
            this.lblCurrentFloor1.Size = new System.Drawing.Size(12, 13);
            this.lblCurrentFloor1.TabIndex = 24;
            this.lblCurrentFloor1.Text = "\\";
            // 
            // lblCurrentFloor2
            // 
            this.lblCurrentFloor2.AutoSize = true;
            this.lblCurrentFloor2.Location = new System.Drawing.Point(48, 89);
            this.lblCurrentFloor2.Name = "lblCurrentFloor2";
            this.lblCurrentFloor2.Size = new System.Drawing.Size(12, 13);
            this.lblCurrentFloor2.TabIndex = 23;
            this.lblCurrentFloor2.Text = "\\";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblLogsTitle);
            this.tabPage2.Controls.Add(this.txtBoxLogs);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(988, 713);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblLogsTitle
            // 
            this.lblLogsTitle.AutoSize = true;
            this.lblLogsTitle.Location = new System.Drawing.Point(254, 6);
            this.lblLogsTitle.Name = "lblLogsTitle";
            this.lblLogsTitle.Size = new System.Drawing.Size(33, 13);
            this.lblLogsTitle.TabIndex = 1;
            this.lblLogsTitle.Text = "Logs:";
            // 
            // txtBoxLogs
            // 
            this.txtBoxLogs.Location = new System.Drawing.Point(290, 6);
            this.txtBoxLogs.Multiline = true;
            this.txtBoxLogs.Name = "txtBoxLogs";
            this.txtBoxLogs.Size = new System.Drawing.Size(374, 701);
            this.txtBoxLogs.TabIndex = 0;
            // 
            // lblCurrentTxt0
            // 
            this.lblCurrentTxt0.AutoSize = true;
            this.lblCurrentTxt0.Location = new System.Drawing.Point(48, 33);
            this.lblCurrentTxt0.Name = "lblCurrentTxt0";
            this.lblCurrentTxt0.Size = new System.Drawing.Size(70, 13);
            this.lblCurrentTxt0.TabIndex = 6;
            this.lblCurrentTxt0.Text = "Current Floor:";
            // 
            // lblCurrentTxt1
            // 
            this.lblCurrentTxt1.AutoSize = true;
            this.lblCurrentTxt1.Location = new System.Drawing.Point(6, 66);
            this.lblCurrentTxt1.Name = "lblCurrentTxt1";
            this.lblCurrentTxt1.Size = new System.Drawing.Size(70, 13);
            this.lblCurrentTxt1.TabIndex = 26;
            this.lblCurrentTxt1.Text = "Current Floor:";
            // 
            // lblCurrentTxt2
            // 
            this.lblCurrentTxt2.AutoSize = true;
            this.lblCurrentTxt2.Location = new System.Drawing.Point(4, 272);
            this.lblCurrentTxt2.Name = "lblCurrentTxt2";
            this.lblCurrentTxt2.Size = new System.Drawing.Size(70, 13);
            this.lblCurrentTxt2.TabIndex = 27;
            this.lblCurrentTxt2.Text = "Current Floor:";
            // 
            // lblCurrentTxt3
            // 
            this.lblCurrentTxt3.AutoSize = true;
            this.lblCurrentTxt3.Location = new System.Drawing.Point(4, 465);
            this.lblCurrentTxt3.Name = "lblCurrentTxt3";
            this.lblCurrentTxt3.Size = new System.Drawing.Size(70, 13);
            this.lblCurrentTxt3.TabIndex = 28;
            this.lblCurrentTxt3.Text = "Current Floor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 763);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRightDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftDoor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picElevator)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer doorsTick;
        private System.Windows.Forms.Timer elevatorTick;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox picRightDoor;
        private System.Windows.Forms.PictureBox picLeftDoor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCloseDoors;
        private System.Windows.Forms.Button btnOpenDoors;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnLevel0;
        private System.Windows.Forms.PictureBox picElevator;
        private System.Windows.Forms.Button btnCall2;
        private System.Windows.Forms.GroupBox lvl2;
        private System.Windows.Forms.Button btnCall0;
        private System.Windows.Forms.Button btnCall1;
        private System.Windows.Forms.GroupBox lvl0;
        private System.Windows.Forms.GroupBox lvl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCurrentFloor2;
        private System.Windows.Forms.Label lblCurrentFloor0;
        private System.Windows.Forms.Label lblCurrentFloor1;
        private System.Windows.Forms.Label lblCurrentFloor;
        private System.Windows.Forms.Label lblLogsTitle;
        private System.Windows.Forms.TextBox txtBoxLogs;
        private System.Windows.Forms.Label lblCurrentTxt3;
        private System.Windows.Forms.Label lblCurrentTxt2;
        private System.Windows.Forms.Label lblCurrentTxt1;
        private System.Windows.Forms.Label lblCurrentTxt0;
    }
}

