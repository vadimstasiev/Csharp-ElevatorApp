﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorApp
{
    public partial class Form1 : Form
    {
        private DatabaseInterface dbInterface;
        public Form1()
        {
            InitializeComponent();
            this.updateDisplayElevatorPosition();
            this.dbInterface = new DatabaseInterface();
        }

        // if the animation of the doors is opening or closing
        // private bool isDoorsOpen = false;

        // if doors animation is running
        private bool isElevatorMoving = false;
        // if doors animation is running
        private bool isDoorsMoving = false;
        // Current state of the elevator doors
        private bool isDoorsOpen = false;
        private void openDoors()
        {
            if (!this.doorsTick.Enabled && !this.isDoorsOpen && !this.isElevatorMoving)
            {
                updateDisplayElevatorPosition();
                this.isDoorsOpen = true;
                this.isDoorsMoving = true;
                this.doorsTick.Enabled = true;
            }
        }
        private void closeDoors()
        {
            if (!this.doorsTick.Enabled && isDoorsOpen)
            {
                this.isDoorsOpen = false;
                this.isDoorsMoving = true;
                this.doorsTick.Enabled = true;
            }
        }

        private int tempDoorPosition = 0;
        private void doors_tick_animation(object sender, EventArgs e)
        {
            int doorTravelDistance = 58;
            if (tempDoorPosition != doorTravelDistance)
            {
                this.tempDoorPosition++;
                if (this.isDoorsOpen)
                {
                    this.picRightDoor.Location = new System.Drawing.Point(this.picRightDoor.Location.X + 1, this.picRightDoor.Location.Y);
                    this.picLeftDoor.Location = new System.Drawing.Point(this.picLeftDoor.Location.X - 1, this.picLeftDoor.Location.Y);
                }
                else
                {
                    this.picRightDoor.Location = new System.Drawing.Point(this.picRightDoor.Location.X - 1, this.picRightDoor.Location.Y);
                    this.picLeftDoor.Location = new System.Drawing.Point(this.picLeftDoor.Location.X + 1, this.picLeftDoor.Location.Y);
                }

            }
            else
            {
                this.isDoorsMoving = false;
                this.tempDoorPosition = 0;
                this.doorsTick.Enabled = false;
                this.dbInterface.AddEntry(getCurrentFloor(), isDoorsOpen ? "Doors Open" : "Doors Closed");
            }
        }

        private void btnOpenDoors_Click(object sender, EventArgs e)
        {
            openDoors();
        }

        private void btnCloseDoors_Click(object sender, EventArgs e)
        {
            closeDoors();
        }

        private int target_position = 1;
        private int LEVEL_2 = 35;
        private int LEVEL_1 = 245;
        private int LEVEL_0 = 455;
        private void elevator_tick_animation(object sender, EventArgs e)
        {
            if (!this.isDoorsOpen && !isDoorsMoving)
            {
                int elevator_position = this.picElevator.Location.Y;
                if (elevator_position != target_position && !isDoorsOpen)
                {
                    isElevatorMoving = true;
                    if (elevator_position < target_position)
                    {
                        this.picElevator.Location = new System.Drawing.Point(this.picElevator.Location.X, this.picElevator.Location.Y + 1);
                        this.picRightDoor.Location = new System.Drawing.Point(this.picRightDoor.Location.X, this.picRightDoor.Location.Y + 1);
                        this.picLeftDoor.Location = new System.Drawing.Point(this.picLeftDoor.Location.X, this.picLeftDoor.Location.Y + 1);
                    }
                    else
                    {
                        this.picElevator.Location = new System.Drawing.Point(this.picElevator.Location.X, this.picElevator.Location.Y - 1);
                        this.picRightDoor.Location = new System.Drawing.Point(this.picRightDoor.Location.X, this.picRightDoor.Location.Y - 1);
                        this.picLeftDoor.Location = new System.Drawing.Point(this.picLeftDoor.Location.X, this.picLeftDoor.Location.Y - 1);
                    }
                }
                else
                {
                    isElevatorMoving = false;
                    this.elevatorTick.Enabled = false;
                    this.openDoors();
                    this.dbInterface.AddEntry(getCurrentFloor(), "Elevator Changed Floor");
                }
            }
        }

        public String getCurrentFloor()
        {

            if (this.target_position == LEVEL_2)
            {
                return "2";
            }else if (this.target_position == LEVEL_1)
            {
                return "1";
            }else if (this.target_position == LEVEL_0)
            {
                return "0";
            }
            return "1";
        }

        public void updateDisplayElevatorPosition()
        {
            String currentFloor = getCurrentFloor();
            this.lblCurrentFloor2.Text = currentFloor;
            this.lblCurrentFloor1.Text = currentFloor;
            this.lblCurrentFloor0.Text = currentFloor;
            this.lblCurrentFloor.Text = currentFloor;
        }
        private void moveElevatorTo(int level)
        {
            if (!isElevatorMoving)
            {
                this.closeDoors();
                this.target_position = level;
                this.elevatorTick.Enabled = true;
            }
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            this.moveElevatorTo(LEVEL_2);
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            this.moveElevatorTo(LEVEL_1);
        }

        private void btnLevel0_Click(object sender, EventArgs e)
        {
            this.moveElevatorTo(LEVEL_0);
        }
        private void tabControlClick(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == this.tabPage2)
                this.loadLogs();
        }
        private void loadLogs()
        {
            this.txtBoxLogs.Text = "";
            ArrayList list = dbInterface.GetLogs();
            Console.WriteLine(list.ToString());
            foreach (String log in list)
            {
                this.txtBoxLogs.Text+=(log);
            }
        }

    }

}
