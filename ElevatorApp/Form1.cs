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

        // if the animation of the doors is opening or closing
        // private bool isDoorsOpen = false;

        // if doors animation is running
        private bool isDoorsMoving = false;
        // Current state of the elevator doors
        private bool isDoorsOpen = false;
        private void openDoors()
        {
            if (!this.doorsTick.Enabled && !this.isDoorsOpen)
            {
                this.isDoorsOpen = true;
                this.isDoorsMoving = true;
                this.doorsTick.Enabled = true;
            }
        }
        private void closeDoors()
        {
            if (!this.doorsTick.Enabled && isDoorsOpen )
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
                } else
                {
                    this.picRightDoor.Location = new System.Drawing.Point(this.picRightDoor.Location.X - 1, this.picRightDoor.Location.Y);
                    this.picLeftDoor.Location = new System.Drawing.Point(this.picLeftDoor.Location.X + 1, this.picLeftDoor.Location.Y);
                }

            } else
            {
                this.isDoorsMoving = false;
                this.tempDoorPosition = 0;
                this.doorsTick.Enabled = false;
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
        private void elevator_tick_animation(object sender, EventArgs e)
        {
            if (!this.isDoorsOpen && !isDoorsMoving)
            {
                int elevator_position = this.picElevator.Location.Y;
                if (elevator_position != target_position && !isDoorsOpen)
                {
                    isMoving = true;
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
                    isMoving = false;
                    this.elevatorTick.Enabled = false;
                    this.openDoors();
                }
            }
        }
        private void moveElevatorTo(int level)
        {
            if (!isMoving)
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

    }
}
