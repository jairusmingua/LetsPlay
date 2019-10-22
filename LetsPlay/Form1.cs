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
using System.Security.Cryptography;

namespace LetsPlay
{
    public partial class Form1 : Form
    {
        int choice;
        string[] prizes = { "Singko", "Dos", "Tres", "Shift", "Uno" };
        int[] rank;
        string [] doors;
        Button[] d;
        Label[] l;
        const int MAX_SIZE = 5;
        const int MAX_BARGAIN = 2;
        int winningDoor = 0;
        int tries;
        public Form1()
        {
            InitializeComponent();
            doors = new string[MAX_SIZE];
            d = new Button[MAX_SIZE];
            rank = new int[MAX_SIZE];
            l = new Label[MAX_SIZE];
            rank[0] = 0;
            rank[1] = 1;
            rank[2] = 2;
            rank[3] = 3;
            rank[4] = 4;
            l[0] = label0;
            l[1] = label1;
            l[2] = label2;
            l[3] = label3;
            l[4] = label4;
            d[0] = door1btn;
            d[1] = door2btn;
            d[2] = door3btn;
            d[3] = door4btn;
            d[4] = door5btn;
            choice = 0;
            randomize();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hidePrompt();
            tries = MAX_BARGAIN;
            randomize();
        }
        private void hidePrompt()
        {
            yesBtn.Visible = false;
            noBtn.Visible = false;
        }
        private void showPrompt()
        {
            yesBtn.Visible = true;
            noBtn.Visible = true;
        }
        private void Door1btn_Click(object sender, EventArgs e)
        {
            bargain(0);

        }

        private void Door2btn_Click(object sender, EventArgs e)
        {
            bargain(1);
        }

        private void Door3btn_Click(object sender, EventArgs e)
        {
            bargain(2);
        }

        private void Door4btn_Click(object sender, EventArgs e)
        {
            bargain(3);
        }
        private void Door5btn_Click(object sender, EventArgs e)
        {
            bargain(4);
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {

            resetGame();
        }
        private void changeBtnState(bool state)
        {
           for(int i = 0; i<doors.Length; i++)
            {
                
               
                
                    d[i].Enabled = state;
                
            }
        }
        private void bargain(int index)
        {
            string m ="";
            choice = index;
            changeBtnState(false);
            tries--;
            if (tries == 1)
            {
                int r;
                for(; ; )
                {
                    r = new Random().Next(0, MAX_SIZE - 1);
                    if(r != index && doors[r]!="Uno")
                    {
                        break;
                    }
                }
                m = String.Format("Door {0} has {1}.\nDo you want to change your choice???", r+1, doors[r]);

                showPrompt();
                   
            }else if (tries == 0)
            {
                l[index].Text = doors[index];
                d[index].Visible = false;
                showPrompt();
                m = String.Format("Congratulations you won a {0}!!!\nReset Game?", doors[index]);
            }
            msgLbl.Text = m;
        }
        private void randomize()
        {
            Random rnd = new Random();
           

            rank = rank.OrderBy(x => rnd.Next()).ToArray();
            for (int i = 0; i < rank.Length; i++)
            {
                doors[rank[i]] = prizes[i];
                
                
            }
            winningDoor = rank[MAX_SIZE - 1];
        }
        private void resetGame()
        {
            tries = MAX_BARGAIN;
            randomize();
            changeBtnState(true);
            showButtons();
            hidePrompt();
            msgLbl.Text = "Let's play the door challenge.\nChoose one of the doors and win your school grade!!!";
        }
        private void showButtons()
        {
            for(int i = 0; i < doors.Length; i++)
            {
                d[i].Visible = true;
            }
        }
        private void YesBtn_Click(object sender, EventArgs e)
        {
            string m = "";
            if (tries == 1)
            {
                m = String.Format("Choose another door...");
                msgLbl.Text = m;
                changeBtnState(true);
                hidePrompt();
            }
            else if (tries == 0)
            {
                resetGame();
            }
            
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            bargain(choice);
        }

        private void Label0_Click(object sender, EventArgs e)
        {

        }
    }
}
