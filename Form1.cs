using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureButtonPassword
{
    
    public partial class Form1 : Form
    {
        const string MALENIA = "3649";
        const string MALIKITH = "1702";
        const string RADAHN = "8581";
        const string RENNALA = "5289";
        const string RADAGON = "6430";
        const string GODFREY = "9757";
        const string MESSMER = "0421";
        const string RYKARD = "2640";
        const string RANNI = "4015";
        const string RELLANA = "7323";
        string passWord = "";
        int Counter = 0;
        string textbox_string = "";
        public Form1()
        {
            InitializeComponent();
        }


      
        private void maleniaPictureBox_Click(object sender, EventArgs e)
        {
            Counter++;
            passWord += MALENIA;
            textbox_string += "*";
            passwordLabel.Text = textbox_string;
        }

        private void rennalaPictureBox_Click(object sender, EventArgs e)
        {
            Counter++;
            passWord += RENNALA;
            textbox_string += "*";
            passwordLabel.Text = textbox_string;
        }

        private void malekithPictureBox_Click(object sender, EventArgs e)
        {
            Counter++;
            passWord += MALIKITH;
            textbox_string += "*";
            passwordLabel.Text = textbox_string;
        }

        private void radahnPictuerBox_Click(object sender, EventArgs e)
        {
            Counter++;
            passWord += RADAHN;
            textbox_string += "*";
            passwordLabel.Text = textbox_string;
        }

        private void messmerPictureBox_Click(object sender, EventArgs e)
        {
            Counter++;
            passWord += MESSMER;
            textbox_string += "*";
            passwordLabel.Text = textbox_string;
        }

        private void rellanaPictureBox_Click(object sender, EventArgs e)
        {
            Counter++;
            passWord += RELLANA;
            textbox_string += "*";
            passwordLabel.Text = textbox_string;
        }

        private void ranniPictureBox_Click(object sender, EventArgs e)
        {
            Counter++;
            passWord += RANNI;
            textbox_string += "*";
            passwordLabel.Text = textbox_string;
        }

        private void godfreyPictureBox_Click(object sender, EventArgs e)
        {
            Counter++;
            passWord += GODFREY;
            textbox_string += "*";
            passwordLabel.Text = textbox_string;
        }

        private void rykardPictureBox_Click(object sender, EventArgs e)
        {
            Counter++;
            passWord += RYKARD;
            textbox_string += "*";
            passwordLabel.Text = textbox_string;
        }

        private void radagonPictureBox_Click(object sender, EventArgs e)
        {
            Counter++; 
            passWord += RADAGON;
          
            passwordLabel.Text = textbox_string;
            textbox_string += "*";
        }
    }
}
