using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Toc_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        int[,] XO = new int[3, 3];

        private void lblClick_Event(object sender, MouseEventArgs e)
        {
            int i, j;
            i = int.Parse(((Label)sender).Name[3].ToString());
            j = int.Parse(((Label)sender).Name[4].ToString());

            if(e.Button == MouseButtons.Left)
            {
                ((Label)sender).Text = "O";
                XO[i,j] = 1;
                label1.Text = "Player 1(O) For Start";
                check(i, j, 1);
            }
            else
            {
                ((Label)sender).Text = "X";
                XO[i, j] = 2;
                label1.Text = "Player 2(X) For Start";
                check(i, j, 2);
            }
        }

        public void check(int i,int j,int person)
        {
            rowCheck(i, j, person);
            colCheck(i, j, person);
            gotrAsliCheck(person);
            gotrFareeCheck(person);
        }

        public void rowCheck(int i,int j,int person)
        {
            if (XO[i,0] == person && XO[i, 1] == person && XO[i, 2] == person)
            {
                label1.Text = "Player "+person.ToString()+" Is Win";
                MessageBox.Show("Player "+person.ToString()+" Is Win");
            }
        }

        public void colCheck(int i, int j, int person)
        {
            if (XO[0, j] == person && XO[1, j] == person && XO[2, j] == person)
            {
                label1.Text = "Player " + person.ToString() + " Is Win";
                MessageBox.Show("Player " + person.ToString() + " Is Win");
            }
        }

        public void gotrAsliCheck(int person)
        {
            if (XO[0, 0] == person && XO[1, 1] == person && XO[2, 2] == person)
            {
                label1.Text = "Player " + person.ToString() + " Is Win";
                MessageBox.Show("Player " + person.ToString() + " Is Win");
            }
        }

        public void gotrFareeCheck(int person)
        {
            if (XO[0, 2] == person && XO[1, 1] == person && XO[2, 0] == person)
            {
                label1.Text = "Player " + person.ToString() + " Is Win";
                MessageBox.Show("Player " + person.ToString() + " Is Win");
            }
        }
    }
}
