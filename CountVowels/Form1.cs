using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class frmMain : Form
    {
        //variable declaration
        String text;
        int vowels;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowVowels_Click(object sender, EventArgs e)
        {
            //convert txtbox to string
            text = txtInput.Text;

            //convert text to lowercase
            text = text.ToLower();

            for (int x = 0; x < text.Length; x++)
            {
                //if character is a vowel, increment vowel var
                if (text[x].Equals('a') || text[x].Equals('e')
                    || text[x].Equals('i') || text[x].Equals('o')
                    || text[x].Equals('u'))
                {
                    vowels++;
                }
            }
            //Console.WriteLine(vowels);
            txtVowels.Text = Convert.ToString(vowels);
            vowels = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear text for user
            vowels = 0;
            txtVowels.Text = "";
            txtInput.Text = "";
        }
    }
}
