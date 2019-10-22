using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace LetsPlay
{
    public partial class Form1 : Form
    {
        string[] prizes = { "goat", "big-screen tv", "car" };
        Button [] door = new Button[3];
        int winningDoor;
        int secondprize;
        int thirdprize;
        int tries;
        public Form1()
        {
            InitializeComponent();
            door[0] = door1btn;
            door[1] = door2btn;
            door[2] = door3btn;
            tries = 2; 
            winningDoor = 0;
            secondprize = 0;
            thirdprize = 0;

            randomizePrize();
            Thread.Sleep(400);
            randomizePrize();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Door1btn_Click(object sender, EventArgs e)
        {
            bargainPrompt(1);
        }

        private void Door2btn_Click(object sender, EventArgs e)
        {
            bargainPrompt(2);
        }

        private void Door3btn_Click(object sender, EventArgs e)
        {
            bargainPrompt(3);
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {

            randomizePrize();
            Thread.Sleep(400);
            randomizePrize();

        }
        public void bargainPrompt(int index)
        {
            tries--;
            if (tries != 0)
            {
                string msg = "";
                if (index == winningDoor)
                {
                    int randomHint = new Random().Next(0,1);
                    
                    if(randomHint==0)
                        msg = String.Format("Door {0} has a {1} in it, are you sure with your answer?", thirdprize, prizes[0]);
                    else if(randomHint==1)
                        msg = String.Format("Door {0} has a {1} in it, are you sure with your answer?", secondprize, prizes[1]);
                }
                else if (index == secondprize)
                {
                    msg = String.Format("Door {0} has a {1} in it, are you sure with your answer?", thirdprize, prizes[0]);
                }
                else if (index == thirdprize)
                {
                    msg = String.Format("Door {0} has a {1} in it, are you sure with your answer?", secondprize, prizes[1]);
                }
                msgLbl.Text = msg;
            }
            else
            {
                showPrice(index);
            }
        }
        public void showPrice(int index)
        {
            msgLbl.Text = String.Format("Congratulations, you won a {0}", door[index-1].Tag);
        }
        public void randomizePrize()
        {
            
            winningDoor = new Random().Next(1, 3);
            door[winningDoor - 1].Tag = prizes[2];
            
            for (; ; ){
                secondprize = new Random().Next(1, 3);
                if(secondprize != winningDoor)
                {
                    break;
                }
            }
            door[secondprize - 1].Tag = prizes[1];
            
            if (winningDoor - secondprize < 0)
            {
                thirdprize = secondprize + winningDoor;
            }
            else if (winningDoor - secondprize > 0)
            {
                thirdprize = winningDoor + secondprize;
            }
            door[thirdprize - 1].Tag = prizes[0];

            tries = 2;


        }

        private void MsgLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
