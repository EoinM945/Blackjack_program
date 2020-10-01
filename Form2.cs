using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_EoinMcDonaldSD6_2018
{

    

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // declaring second form object
             Form1 secondForm = new Form1();
            int txtAgeVal = 0;
            String txtName;
            //parameters for user input

            txtName = TxtName.Text;
            txtAgeVal = int.Parse(TxtAge.Text);

            if (txtAgeVal <= 21)
            {
                MessageBox.Show("You Must Be 21 Or Over To Play");
                Application.Restart();
            }

            else if (RadTerms.Checked == false)
            {
                MessageBox.Show("You Must Agree To The Terms And Conditions");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("User Is: " + txtName  +"\n"  + " User Age Is: " + txtAgeVal + "\n"+ " User Has Agreed To Terms ");
                secondForm.Show();
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TxtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadTerms_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
