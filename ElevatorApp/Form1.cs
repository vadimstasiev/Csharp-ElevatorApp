using System;
using System.Collections.Generic;
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
        public Form1()
        {
            InitializeComponent();
        }


        private bool isDoorsOpening = false;
        private bool isDoorsOpen = false;
        private void openDoors()
        {
            if (!this.doorsTick.Enabled && !isDoorsOpen)
            {
                this.isDoorsOpening = true;
                this.doorsTick.Enabled = true;
            }
        }
        private void closeDoors()
        {
            if (!this.doorsTick.Enabled && isDoorsOpen )
            {
                this.isDoorsOpening = false;
                this.doorsTick.Enabled = true;
            }
        }

        private int tempDoorPosition = 0;
        private void doorsTick_Tick(object sender, EventArgs e)
        {
            int doorTravelDistance = 50;
            if (tempDoorPosition != doorTravelDistance)
            {
                tempDoorPosition++;
                if (isDoorsOpening)
                {
                    this.picRightDoor.Location = new System.Drawing.Point(this.picRightDoor.Location.X + 1, this.picRightDoor.Location.Y);
                    this.picLeftDoor.Location = new System.Drawing.Point(this.picLeftDoor.Location.X - 1, this.picLeftDoor.Location.Y);
                    isDoorsOpen = true;
                } else
                {
                    this.picRightDoor.Location = new System.Drawing.Point(this.picRightDoor.Location.X - 1, this.picRightDoor.Location.Y);
                    this.picLeftDoor.Location = new System.Drawing.Point(this.picLeftDoor.Location.X + 1, this.picLeftDoor.Location.Y);
                    isDoorsOpen = false;
                }

            } else
            {
                this.doorsTick.Enabled = false;
                tempDoorPosition = 0;
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

        private int target_position;
        private int LEVEL_2 = 35;
        private int LEVEL_1 = 245;
        private int LEVEL_0 = 455;
        private bool isMoving = false;
        private void elevatorTick_Tick(object sender, EventArgs e)
        {
            int elevator_position = this.picElevator.Location.Y;
            if (elevator_position != target_position)
            {
                isMoving = true;
                if (elevator_position<target_position)
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
                isMoving = false;
                this.elevatorTick.Enabled = false;
            }
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            this.target_position = LEVEL_2;
            this.elevatorTick.Enabled = true;
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            this.target_position = LEVEL_1;
            this.elevatorTick.Enabled = true;
        }

        private void btnLevel0_Click(object sender, EventArgs e)
        {
            this.target_position = LEVEL_0;
            this.elevatorTick.Enabled = true;
        }
    }
}
