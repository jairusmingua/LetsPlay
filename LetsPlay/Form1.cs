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
        bool choice = true;
        string[] prizes = { "Singko", "Dos", "Tres", "Shift", "Uno" };
        int[] rank;
        string [] doors;
        const int MAX_SIZE = 5;
        const int MAX_BARGAIN = 2;
        int winningDoor = 0;
        int tries;
        public Form1()
        {
            InitializeComponent();
            doors = new string[MAX_SIZE];
            rank = new int[MAX_SIZE];
            rank[0] = 0;
            rank[1] = 1;
            rank[2] = 2;
            rank[3] = 3;
            rank[4] = 4;
            randomize();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            tries = MAX_BARGAIN;
            randomize();
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
        private void bargain(int index)
        {
            msgLbl.Text = doors[index].ToString();
            tries--;
            if (tries == 1)
            {

            }
        }
        private void randomize()
        {
            Random rnd = new Random();
           

            rank = rank.OrderBy(x => rnd.Next()).ToArray();
            for (int i = 0; i < rank.Length; i++)
            {
                doors[rank[i]] = prizes[i];
            }
        }
        private void resetGame()
        {
            tries = MAX_BARGAIN;
            randomize();
        }

    }
}
