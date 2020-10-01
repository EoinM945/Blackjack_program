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
    public partial class Form1 : Form
    {
        // Randomizer 
        Random randomizer = new Random();
        //variables for card and total score values
        int card1Val;
        int card2Val;
        int card3Val;
        int card4Val;
        int card5Val;
        int totalVal;
        int totalValDealer;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDeal_Click(object sender, EventArgs e)
        {

            //get random numbers

            card1Val = randomizer.Next(1, 52);

            //switch statement for the cases for each click 


            switch (card1Val)
            {
                case 1:
                    /*each images is in a certain order in the image list and i have 
                     * used the cardVal variable to declare the values for each of the specific
                     * cards
                     */
                    PicCard1.Image = ImageList1.Images[0];
                    card1Val = 2;
                    break;
                case 2:
                    PicCard1.Image = ImageList1.Images[1];
                    card1Val = 2;
                    break;
                case 3:
                    PicCard1.Image = ImageList1.Images[2];
                    card1Val = 2;
                    break;
                case 4:
                    PicCard1.Image = ImageList1.Images[3];
                    card1Val = 2;
                    break;
                case 5:
                    PicCard1.Image = ImageList1.Images[4];
                    card1Val = 3;
                    break;
                case 6:
                    PicCard1.Image = ImageList1.Images[5];
                    card1Val = 3;
                    break;
                case 7:
                    PicCard1.Image = ImageList1.Images[6];
                    card1Val = 3;
                    break;
                case 8:
                    PicCard1.Image = ImageList1.Images[7];
                    card1Val = 3;
                    break;
                case 9:
                    PicCard1.Image = ImageList1.Images[8];
                    card1Val = 4;
                    break;
                case 10:
                    PicCard1.Image = ImageList1.Images[9];
                    card1Val = 4;
                    break;
                case 11:
                    PicCard1.Image = ImageList1.Images[10];
                    card1Val = 4;
                    break;
                case 12:
                    PicCard1.Image = ImageList1.Images[11];
                    card1Val = 4;
                    break;
                case 13:
                    PicCard1.Image = ImageList1.Images[12];
                    card1Val = 5;
                    break;
                case 14:
                    PicCard1.Image = ImageList1.Images[13];
                    card1Val = 5;
                    break;
                case 15:
                    PicCard1.Image = ImageList1.Images[14];
                    card1Val = 5;
                    break;
                case 16:
                    PicCard1.Image = ImageList1.Images[15];
                    card1Val = 5;
                    break;
                case 17:
                    PicCard1.Image = ImageList1.Images[16];
                    card1Val = 6;
                    break;
                case 18:
                    PicCard1.Image = ImageList1.Images[17];
                    card1Val = 6;
                    break;
                case 19:
                    PicCard1.Image = ImageList1.Images[18];
                    card1Val = 6;
                    break;
                case 20:
                    PicCard1.Image = ImageList1.Images[19];
                    card1Val = 6;
                    break;
                case 21:
                    PicCard1.Image = ImageList1.Images[20];
                    card1Val = 7;
                    break;
                case 22:
                    PicCard1.Image = ImageList1.Images[21];
                    card1Val = 7;
                    break;
                case 23:
                    PicCard1.Image = ImageList1.Images[22];
                    card1Val = 7;
                    break;
                case 24:
                    PicCard1.Image = ImageList1.Images[23];
                    card1Val = 7;
                    break;
                case 25:
                    PicCard1.Image = ImageList1.Images[24];
                    card1Val = 8;
                    break;
                case 26:
                    PicCard1.Image = ImageList1.Images[25];
                    card1Val = 8;
                    break;
                case 27:
                    PicCard1.Image = ImageList1.Images[26];
                    card1Val = 8;
                    break;
                case 28:
                    PicCard1.Image = ImageList1.Images[27];
                    card1Val = 8;
                    break;
                case 29:
                    PicCard1.Image = ImageList1.Images[28];
                    card1Val = 9;
                    break;
                case 30:
                    PicCard1.Image = ImageList1.Images[29];
                    card1Val = 9;
                    break;
                case 31:
                    PicCard1.Image = ImageList1.Images[30];
                    card1Val = 9;
                    break;
                case 32:
                    PicCard1.Image = ImageList1.Images[31];
                    card1Val = 9;
                    break;
                case 33:
                    PicCard1.Image = ImageList1.Images[32];
                    card1Val = 10;
                    break;
                case 34:
                    PicCard1.Image = ImageList1.Images[33];
                    card1Val = 10;
                    break;
                case 35:
                    PicCard1.Image = ImageList1.Images[34];
                    card1Val = 10;
                    break;
                case 36:
                    PicCard1.Image = ImageList1.Images[35];
                    card1Val = 10;
                    break;
                case 37:
                    PicCard1.Image = ImageList1.Images[36];
                    card1Val = 11;
                    break;
                case 38:
                    PicCard1.Image = ImageList1.Images[37];
                    card1Val = 11;
                    break;
                case 39:
                    PicCard1.Image = ImageList1.Images[38];
                    card1Val = 11;
                    break;
                case 40:
                    PicCard1.Image = ImageList1.Images[39];
                    card1Val = 11;
                    break;
                case 41:
                    PicCard1.Image = ImageList1.Images[40];
                    card1Val = 10;
                    break;
                case 42:
                    PicCard1.Image = ImageList1.Images[41];
                    card1Val = 10;
                    break;
                case 43:
                    PicCard1.Image = ImageList1.Images[42];
                    card1Val = 10;
                    break;
                case 44:
                    PicCard1.Image = ImageList1.Images[43];
                    card1Val = 10;
                    break;
                case 45:
                    PicCard1.Image = ImageList1.Images[44];
                    card1Val = 10;
                    break;
                case 46:
                    PicCard1.Image = ImageList1.Images[45];
                    card1Val = 10;
                    break;
                case 47:
                    PicCard1.Image = ImageList1.Images[46];
                    card1Val = 10;
                    break;
                case 48:
                    PicCard1.Image = ImageList1.Images[47];
                    card1Val = 10;
                    break;
                case 49:
                    PicCard1.Image = ImageList1.Images[48];
                    card1Val = 10;
                    break;
                case 50:
                    PicCard1.Image = ImageList1.Images[49];
                    card1Val = 10;
                    break;
                case 51:
                    PicCard1.Image = ImageList1.Images[50];
                    card1Val = 10;
                    break;
                case 52:
                    PicCard1.Image = ImageList1.Images[51];
                    card1Val = 10;
                    break;


            }

            /*the total value of the cards will be displayed as user score*/
            totalVal = card1Val;
            LblPlayerTotal.Text = totalVal.ToString() + " Total Score";





            card2Val = randomizer.Next(1, 52);




            switch (card2Val)
            {
                case 1:
                    PicCard2.Image = ImageList1.Images[0];
                    card2Val = 2;
                    break;
                case 2:
                    PicCard2.Image = ImageList1.Images[1];
                    card2Val = 2;
                    break;
                case 3:
                    PicCard2.Image = ImageList1.Images[2];
                    card2Val = 2;
                    break;
                case 4:
                    PicCard2.Image = ImageList1.Images[3];
                    card2Val = 2;
                    break;
                case 5:
                    PicCard2.Image = ImageList1.Images[4];
                    card2Val = 3;
                    break;
                case 6:
                    PicCard2.Image = ImageList1.Images[5];
                    card2Val = 3;
                    break;
                case 7:
                    PicCard2.Image = ImageList1.Images[6];
                    card2Val = 3;
                    break;
                case 8:
                    PicCard2.Image = ImageList1.Images[7];
                    card2Val = 3;
                    break;
                case 9:
                    PicCard2.Image = ImageList1.Images[8];
                    card2Val = 4;
                    break;
                case 10:
                    PicCard2.Image = ImageList1.Images[9];
                    card2Val = 4;
                    break;
                case 11:
                    PicCard2.Image = ImageList1.Images[10];
                    card2Val = 4;
                    break;
                case 12:
                    PicCard2.Image = ImageList1.Images[11];
                    card2Val = 4;
                    break;
                case 13:
                    PicCard2.Image = ImageList1.Images[12];
                    card2Val = 5;
                    break;
                case 14:
                    PicCard2.Image = ImageList1.Images[13];
                    card2Val = 5;
                    break;
                case 15:
                    PicCard2.Image = ImageList1.Images[14];
                    card2Val = 5;
                    break;
                case 16:
                    PicCard2.Image = ImageList1.Images[15];
                    card2Val = 5;
                    break;
                case 17:
                    PicCard2.Image = ImageList1.Images[16];
                    card2Val = 6;
                    break;
                case 18:
                    PicCard2.Image = ImageList1.Images[17];
                    card2Val = 6;
                    break;
                case 19:
                    PicCard2.Image = ImageList1.Images[18];
                    card2Val = 6;
                    break;
                case 20:
                    PicCard2.Image = ImageList1.Images[19];
                    card2Val = 6;
                    break;
                case 21:
                    PicCard2.Image = ImageList1.Images[20];
                    card2Val = 7;
                    break;
                case 22:
                    PicCard2.Image = ImageList1.Images[21];
                    card2Val = 7;
                    break;
                case 23:
                    PicCard2.Image = ImageList1.Images[22];
                    card2Val = 7;
                    break;
                case 24:
                    PicCard2.Image = ImageList1.Images[23];
                    card2Val = 7;
                    break;
                case 25:
                    PicCard2.Image = ImageList1.Images[24];
                    card2Val = 8;
                    break;
                case 26:
                    PicCard2.Image = ImageList1.Images[25];
                    card2Val = 8;
                    break;
                case 27:
                    PicCard2.Image = ImageList1.Images[26];
                    card2Val = 8;
                    break;
                case 28:
                    PicCard2.Image = ImageList1.Images[27];
                    card2Val = 8;
                    break;
                case 29:
                    PicCard2.Image = ImageList1.Images[28];
                    card2Val = 9;
                    break;
                case 30:
                    PicCard2.Image = ImageList1.Images[29];
                    card2Val = 9;
                    break;
                case 31:
                    PicCard2.Image = ImageList1.Images[30];
                    card2Val = 9;
                    break;
                case 32:
                    PicCard2.Image = ImageList1.Images[31];
                    card2Val = 9;
                    break;
                case 33:
                    PicCard2.Image = ImageList1.Images[32];
                    card2Val = 10;
                    break;
                case 34:
                    PicCard2.Image = ImageList1.Images[33];
                    card2Val = 10;
                    break;
                case 35:
                    PicCard2.Image = ImageList1.Images[34];
                    card2Val = 10;
                    break;
                case 36:
                    PicCard2.Image = ImageList1.Images[35];
                    card2Val = 10;
                    break;
                case 37:
                    PicCard2.Image = ImageList1.Images[36];
                    card2Val = 11;
                    break;
                case 38:
                    PicCard2.Image = ImageList1.Images[37];
                    card2Val = 11;
                    break;
                case 39:
                    PicCard2.Image = ImageList1.Images[38];
                    card2Val = 11;
                    break;
                case 40:
                    PicCard2.Image = ImageList1.Images[39];
                    card2Val = 11;
                    break;
                case 41:
                    PicCard2.Image = ImageList1.Images[40];
                    card2Val = 10;
                    break;
                case 42:
                    PicCard2.Image = ImageList1.Images[41];
                    card2Val = 10;
                    break;
                case 43:
                    PicCard2.Image = ImageList1.Images[42];
                    card2Val = 10;
                    break;
                case 44:
                    PicCard2.Image = ImageList1.Images[43];
                    card2Val = 10;
                    break;
                case 45:
                    PicCard2.Image = ImageList1.Images[44];
                    card2Val = 10;
                    break;
                case 46:
                    PicCard2.Image = ImageList1.Images[45];
                    card2Val = 10;
                    break;
                case 47:
                    PicCard2.Image = ImageList1.Images[46];
                    card2Val = 10;
                    break;
                case 48:
                    PicCard2.Image = ImageList1.Images[47];
                    card2Val = 10;
                    break;
                case 49:
                    PicCard2.Image = ImageList1.Images[48];
                    card2Val = 10;
                    break;
                case 50:
                    PicCard2.Image = ImageList1.Images[49];
                    card2Val = 10;
                    break;
                case 51:
                    PicCard2.Image = ImageList1.Images[50];
                    card2Val = 10;
                    break;
                case 52:
                    PicCard2.Image = ImageList1.Images[51];
                    card2Val = 10;
                    break;


            }

            /*the total value will be the previous cards drawn and then added to the last card drawn
             * to get an updated total value , this continues on untill the final card
             */
            totalVal = totalVal + card2Val;
            LblPlayerTotal.Text = totalVal.ToString() + " Total Score";

            /*after the first card the total value will be generated and as more cards are 
             * drawn , if the score reaches 21 the user will be notified of a win, as soon as the 
             * score exceeds 21 user will be notified of a loss*/
            if (totalVal == 21)
            {
                MessageBox.Show("You Win");
                Application.Restart();
            }
            else if (totalVal > 21)
            {
                MessageBox.Show("You Lose");
                Application.Restart();
            }




















        }
        // button for resetting the game restarts the app 
        private void BtnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //button for exit exits the app 
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // button for picture box 3 that generates a random card 
        private void BtnHit1_Click(object sender, EventArgs e)
        {
            card3Val = randomizer.Next(1, 52);

            switch (card3Val)
            {
                case 1:
                    PicCard3.Image = ImageList1.Images[0];
                    card3Val = 2;
                    break;
                case 2:
                    PicCard3.Image = ImageList1.Images[1];
                    card3Val = 2;
                    break;
                case 3:
                    PicCard3.Image = ImageList1.Images[2];
                    card3Val = 2;
                    break;
                case 4:
                    PicCard3.Image = ImageList1.Images[3];
                    card3Val = 2;
                    break;
                case 5:
                    PicCard3.Image = ImageList1.Images[4];
                    card3Val = 3;
                    break;
                case 6:
                    PicCard3.Image = ImageList1.Images[5];
                    card3Val = 3;
                    break;
                case 7:
                    PicCard3.Image = ImageList1.Images[6];
                    card3Val = 3;
                    break;
                case 8:
                    PicCard3.Image = ImageList1.Images[7];
                    card3Val = 3;
                    break;
                case 9:
                    PicCard3.Image = ImageList1.Images[8];
                    card3Val = 4;
                    break;
                case 10:
                    PicCard3.Image = ImageList1.Images[9];
                    card3Val = 4;
                    break;
                case 11:
                    PicCard3.Image = ImageList1.Images[10];
                    card3Val = 4;
                    break;
                case 12:
                    PicCard3.Image = ImageList1.Images[11];
                    card3Val = 4;
                    break;
                case 13:
                    PicCard3.Image = ImageList1.Images[12];
                    card3Val = 5;
                    break;
                case 14:
                    PicCard3.Image = ImageList1.Images[13];
                    card3Val = 5;
                    break;
                case 15:
                    PicCard3.Image = ImageList1.Images[14];
                    card3Val = 5;
                    break;
                case 16:
                    PicCard3.Image = ImageList1.Images[15];
                    card3Val = 5;
                    break;
                case 17:
                    PicCard3.Image = ImageList1.Images[16];
                    card3Val = 6;
                    break;
                case 18:
                    PicCard3.Image = ImageList1.Images[17];
                    card3Val = 6;
                    break;
                case 19:
                    PicCard3.Image = ImageList1.Images[18];
                    card3Val = 6;
                    break;
                case 20:
                    PicCard3.Image = ImageList1.Images[19];
                    card3Val = 6;
                    break;
                case 21:
                    PicCard3.Image = ImageList1.Images[20];
                    card3Val = 7;
                    break;
                case 22:
                    PicCard3.Image = ImageList1.Images[21];
                    card3Val = 7;
                    break;
                case 23:
                    PicCard3.Image = ImageList1.Images[22];
                    card3Val = 7;
                    break;
                case 24:
                    PicCard3.Image = ImageList1.Images[23];
                    card3Val = 7;
                    break;
                case 25:
                    PicCard3.Image = ImageList1.Images[24];
                    card3Val = 8;
                    break;
                case 26:
                    PicCard3.Image = ImageList1.Images[25];
                    card3Val = 8;
                    break;
                case 27:
                    PicCard3.Image = ImageList1.Images[26];
                    card3Val = 8;
                    break;
                case 28:
                    PicCard3.Image = ImageList1.Images[27];
                    card3Val = 8;
                    break;
                case 29:
                    PicCard3.Image = ImageList1.Images[28];
                    card3Val = 9;
                    break;
                case 30:
                    PicCard3.Image = ImageList1.Images[29];
                    card3Val = 9;
                    break;
                case 31:
                    PicCard3.Image = ImageList1.Images[30];
                    card3Val = 9;
                    break;
                case 32:
                    PicCard3.Image = ImageList1.Images[31];
                    card3Val = 9;
                    break;
                case 33:
                    PicCard3.Image = ImageList1.Images[32];
                    card3Val = 10;
                    break;
                case 34:
                    PicCard3.Image = ImageList1.Images[33];
                    card3Val = 10;
                    break;
                case 35:
                    PicCard3.Image = ImageList1.Images[34];
                    card3Val = 10;
                    break;
                case 36:
                    PicCard3.Image = ImageList1.Images[35];
                    card3Val = 10;
                    break;
                case 37:
                    PicCard3.Image = ImageList1.Images[36];
                    card3Val = 11;
                    break;
                case 38:
                    PicCard3.Image = ImageList1.Images[37];
                    card3Val = 11;
                    break;
                case 39:
                    PicCard3.Image = ImageList1.Images[38];
                    card3Val = 11;
                    break;
                case 40:
                    PicCard3.Image = ImageList1.Images[39];
                    card3Val = 11;
                    break;
                case 41:
                    PicCard3.Image = ImageList1.Images[40];
                    card3Val = 10;
                    break;
                case 42:
                    PicCard3.Image = ImageList1.Images[41];
                    card3Val = 10;
                    break;
                case 43:
                    PicCard3.Image = ImageList1.Images[42];
                    card3Val = 10;
                    break;
                case 44:
                    PicCard3.Image = ImageList1.Images[43];
                    card3Val = 10;
                    break;
                case 45:
                    PicCard3.Image = ImageList1.Images[44];
                    card3Val = 10;
                    break;
                case 46:
                    PicCard3.Image = ImageList1.Images[45];
                    card3Val = 10;
                    break;
                case 47:
                    PicCard3.Image = ImageList1.Images[46];
                    card3Val = 10;
                    break;
                case 48:
                    PicCard3.Image = ImageList1.Images[47];
                    card3Val = 10;
                    break;
                case 49:
                    PicCard3.Image = ImageList1.Images[48];
                    card3Val = 10;
                    break;
                case 50:
                    PicCard3.Image = ImageList1.Images[49];
                    card3Val = 10;
                    break;
                case 51:
                    PicCard3.Image = ImageList1.Images[50];
                    card3Val = 10;
                    break;
                case 52:
                    PicCard3.Image = ImageList1.Images[51];
                    card3Val = 10;
                    break;


            }


            totalVal = totalVal + card3Val;
            LblPlayerTotal.Text = totalVal.ToString() + " Total Score";


            if (totalVal == 21)
            {
                MessageBox.Show("You Win");
                Application.Restart();
            }
            // if value is greater than 21 it is a loss
            else if (totalVal > 21 )
            {
                MessageBox.Show("You Lose");
                Application.Restart();
            }

        }

        private void BtnHit2_Click(object sender, EventArgs e)
        {
            card4Val = randomizer.Next(1, 52);

            switch (card4Val)
            {
                case 1:
                    PicCard4.Image = ImageList1.Images[0];
                    card4Val = 2;
                    break;
                case 2:
                    PicCard4.Image = ImageList1.Images[1];
                    card4Val = 2;
                    break;
                case 3:
                    PicCard4.Image = ImageList1.Images[2];
                    card4Val = 2;
                    break;
                case 4:
                    PicCard4.Image = ImageList1.Images[3];
                    card4Val = 2;
                    break;
                case 5:
                    PicCard4.Image = ImageList1.Images[4];
                    card4Val = 3;
                    break;
                case 6:
                    PicCard4.Image = ImageList1.Images[5];
                    card4Val = 3;
                    break;
                case 7:
                    PicCard4.Image = ImageList1.Images[6];
                    card4Val = 3;
                    break;
                case 8:
                    PicCard4.Image = ImageList1.Images[7];
                    card4Val = 3;
                    break;
                case 9:
                    PicCard4.Image = ImageList1.Images[8];
                    card4Val = 4;
                    break;
                case 10:
                    PicCard4.Image = ImageList1.Images[9];
                    card4Val = 4;
                    break;
                case 11:
                    PicCard4.Image = ImageList1.Images[10];
                    card4Val = 4;
                    break;
                case 12:
                    PicCard4.Image = ImageList1.Images[11];
                    card4Val = 4;
                    break;
                case 13:
                    PicCard4.Image = ImageList1.Images[12];
                    card4Val = 5;
                    break;
                case 14:
                    PicCard4.Image = ImageList1.Images[13];
                    card4Val = 5;
                    break;
                case 15:
                    PicCard4.Image = ImageList1.Images[14];
                    card4Val = 5;
                    break;
                case 16:
                    PicCard4.Image = ImageList1.Images[15];
                    card4Val = 5;
                    break;
                case 17:
                    PicCard4.Image = ImageList1.Images[16];
                    card4Val = 6;
                    break;
                case 18:
                    PicCard4.Image = ImageList1.Images[17];
                    card4Val = 6;
                    break;
                case 19:
                    PicCard4.Image = ImageList1.Images[18];
                    card4Val = 6;
                    break;
                case 20:
                    PicCard4.Image = ImageList1.Images[19];
                    card4Val = 6;
                    break;
                case 21:
                    PicCard4.Image = ImageList1.Images[20];
                    card4Val = 7;
                    break;
                case 22:
                    PicCard4.Image = ImageList1.Images[21];
                    card4Val = 7;
                    break;
                case 23:
                    PicCard4.Image = ImageList1.Images[22];
                    card4Val = 7;
                    break;
                case 24:
                    PicCard4.Image = ImageList1.Images[23];
                    card4Val = 7;
                    break;
                case 25:
                    PicCard4.Image = ImageList1.Images[24];
                    card4Val = 8;
                    break;
                case 26:
                    PicCard4.Image = ImageList1.Images[25];
                    card4Val = 8;
                    break;
                case 27:
                    PicCard4.Image = ImageList1.Images[26];
                    card4Val = 8;
                    break;
                case 28:
                    PicCard4.Image = ImageList1.Images[27];
                    card4Val = 8;
                    break;
                case 29:
                    PicCard4.Image = ImageList1.Images[28];
                    card4Val = 9;
                    break;
                case 30:
                    PicCard4.Image = ImageList1.Images[29];
                    card4Val = 9;
                    break;
                case 31:
                    PicCard4.Image = ImageList1.Images[30];
                    card4Val = 9;
                    break;
                case 32:
                    PicCard4.Image = ImageList1.Images[31];
                    card4Val = 9;
                    break;
                case 33:
                    PicCard4.Image = ImageList1.Images[32];
                    card4Val = 10;
                    break;
                case 34:
                    PicCard4.Image = ImageList1.Images[33];
                    card4Val = 10;
                    break;
                case 35:
                    PicCard4.Image = ImageList1.Images[34];
                    card4Val = 10;
                    break;
                case 36:
                    PicCard4.Image = ImageList1.Images[35];
                    card4Val = 10;
                    break;
                case 37:
                    PicCard4.Image = ImageList1.Images[36];
                    card4Val = 11;
                    break;
                case 38:
                    PicCard4.Image = ImageList1.Images[37];
                    card4Val = 11;
                    break;
                case 39:
                    PicCard4.Image = ImageList1.Images[38];
                    card4Val = 11;
                    break;
                case 40:
                    PicCard4.Image = ImageList1.Images[39];
                    card4Val = 11;
                    break;
                case 41:
                    PicCard4.Image = ImageList1.Images[40];
                    card4Val = 10;
                    break;
                case 42:
                    PicCard4.Image = ImageList1.Images[41];
                    card4Val = 10;
                    break;
                case 43:
                    PicCard4.Image = ImageList1.Images[42];
                    card4Val = 10;
                    break;
                case 44:
                    PicCard4.Image = ImageList1.Images[43];
                    card4Val = 10;
                    break;
                case 45:
                    PicCard4.Image = ImageList1.Images[44];
                    card4Val = 10;
                    break;
                case 46:
                    PicCard4.Image = ImageList1.Images[45];
                    card4Val = 10;
                    break;
                case 47:
                    PicCard4.Image = ImageList1.Images[46];
                    card4Val = 10;
                    break;
                case 48:
                    PicCard4.Image = ImageList1.Images[47];
                    card4Val = 10;
                    break;
                case 49:
                    PicCard4.Image = ImageList1.Images[48];
                    card4Val = 10;
                    break;
                case 50:
                    PicCard4.Image = ImageList1.Images[49];
                    card4Val = 10;
                    break;
                case 51:
                    PicCard4.Image = ImageList1.Images[50];
                    card4Val = 10;
                    break;
                case 52:
                    PicCard4.Image = ImageList1.Images[51];
                    card4Val = 10;
                    break;


            }

            totalVal = totalVal + card4Val;
            LblPlayerTotal.Text = totalVal.ToString() + " Total Score";
            //generates a random score for dealer between 17 - 25
            totalValDealer = randomizer.Next(17, 25);
            //prints out dealers random generated score
            LblDealerTotal.Text = totalValDealer.ToString() + "Dealer Score ";

            // if 21 achieved you win 
            if (totalVal == 21)
            {
                MessageBox.Show("You Win");
                Application.Restart();
            }
            // if value is greater than 21 you lose
            else if (totalVal > 21)
            {
                MessageBox.Show("You Lose");
                Application.Restart();
            }

        }

        private void BtnHit3_Click(object sender, EventArgs e)
        {
            card5Val = randomizer.Next(1, 52);

            switch (card5Val)
            {
                case 1:
                    PicCard5.Image = ImageList1.Images[0];
                    card5Val = 2;
                    break;
                case 2:
                    PicCard5.Image = ImageList1.Images[1];
                    card5Val = 2;
                    break;
                case 3:
                    PicCard5.Image = ImageList1.Images[2];
                    card5Val = 2;
                    break;
                case 4:
                    PicCard5.Image = ImageList1.Images[3];
                    card5Val = 2;
                    break;
                case 5:
                    PicCard5.Image = ImageList1.Images[4];
                    card5Val = 3;
                    break;
                case 6:
                    PicCard5.Image = ImageList1.Images[5];
                    card5Val = 3;
                    break;
                case 7:
                    PicCard5.Image = ImageList1.Images[6];
                    card5Val = 3;
                    break;
                case 8:
                    PicCard5.Image = ImageList1.Images[7];
                    card5Val = 3;
                    break;
                case 9:
                    PicCard5.Image = ImageList1.Images[8];
                    card5Val = 4;
                    break;
                case 10:
                    PicCard5.Image = ImageList1.Images[9];
                    card5Val = 4;
                    break;
                case 11:
                    PicCard5.Image = ImageList1.Images[10];
                    card5Val = 4;
                    break;
                case 12:
                    PicCard5.Image = ImageList1.Images[11];
                    card5Val = 4;
                    break;
                case 13:
                    PicCard5.Image = ImageList1.Images[12];
                    card5Val = 5;
                    break;
                case 14:
                    PicCard5.Image = ImageList1.Images[13];
                    card5Val = 5;
                    break;
                case 15:
                    PicCard5.Image = ImageList1.Images[14];
                    card5Val = 5;
                    break;
                case 16:
                    PicCard5.Image = ImageList1.Images[15];
                    card5Val = 5;
                    break;
                case 17:
                    PicCard5.Image = ImageList1.Images[16];
                    card5Val = 6;
                    break;
                case 18:
                    PicCard5.Image = ImageList1.Images[17];
                    card5Val = 6;
                    break;
                case 19:
                    PicCard5.Image = ImageList1.Images[18];
                    card5Val = 6;
                    break;
                case 20:
                    PicCard5.Image = ImageList1.Images[19];
                    card5Val = 6;
                    break;
                case 21:
                    PicCard5.Image = ImageList1.Images[20];
                    card5Val = 7;
                    break;
                case 22:
                    PicCard5.Image = ImageList1.Images[21];
                    card5Val = 7;
                    break;
                case 23:
                    PicCard5.Image = ImageList1.Images[22];
                    card5Val = 7;
                    break;
                case 24:
                    PicCard5.Image = ImageList1.Images[23];
                    card5Val = 7;
                    break;
                case 25:
                    PicCard5.Image = ImageList1.Images[24];
                    card5Val = 8;
                    break;
                case 26:
                    PicCard5.Image = ImageList1.Images[25];
                    card5Val = 8;
                    break;
                case 27:
                    PicCard5.Image = ImageList1.Images[26];
                    card5Val = 8;
                    break;
                case 28:
                    PicCard5.Image = ImageList1.Images[27];
                    card5Val = 8;
                    break;
                case 29:
                    PicCard5.Image = ImageList1.Images[28];
                    card5Val = 9;
                    break;
                case 30:
                    PicCard5.Image = ImageList1.Images[29];
                    card5Val = 9;
                    break;
                case 31:
                    PicCard5.Image = ImageList1.Images[30];
                    card5Val = 9;
                    break;
                case 32:
                    PicCard5.Image = ImageList1.Images[31];
                    card5Val = 9;
                    break;
                case 33:
                    PicCard5.Image = ImageList1.Images[32];
                    card5Val = 10;
                    break;
                case 34:
                    PicCard5.Image = ImageList1.Images[33];
                    card5Val = 10;
                    break;
                case 35:
                    PicCard5.Image = ImageList1.Images[34];
                    card5Val = 10;
                    break;
                case 36:
                    PicCard5.Image = ImageList1.Images[35];
                    card5Val = 10;
                    break;
                case 37:
                    PicCard5.Image = ImageList1.Images[36];
                    card5Val = 11;
                    break;
                case 38:
                    PicCard5.Image = ImageList1.Images[37];
                    card5Val = 11;
                    break;
                case 39:
                    PicCard5.Image = ImageList1.Images[38];
                    card5Val = 11;
                    break;
                case 40:
                    PicCard5.Image = ImageList1.Images[39];
                    card5Val = 11;
                    break;
                case 41:
                    PicCard5.Image = ImageList1.Images[40];
                    card5Val = 10;
                    break;
                case 42:
                    PicCard5.Image = ImageList1.Images[41];
                    card5Val = 10;
                    break;
                case 43:
                    PicCard5.Image = ImageList1.Images[42];
                    card5Val = 10;
                    break;
                case 44:
                    PicCard5.Image = ImageList1.Images[43];
                    card5Val = 10;
                    break;
                case 45:
                    PicCard5.Image = ImageList1.Images[44];
                    card5Val = 10;
                    break;
                case 46:
                    PicCard5.Image = ImageList1.Images[45];
                    card5Val = 10;
                    break;
                case 47:
                    PicCard5.Image = ImageList1.Images[46];
                    card5Val = 10;
                    break;
                case 48:
                    PicCard5.Image = ImageList1.Images[47];
                    card5Val = 10;
                    break;
                case 49:
                    PicCard5.Image = ImageList1.Images[48];
                    card5Val = 10;
                    break;
                case 50:
                    PicCard5.Image = ImageList1.Images[49];
                    card5Val = 10;
                    break;
                case 51:
                    PicCard5.Image = ImageList1.Images[50];
                    card5Val = 10;
                    break;
                case 52:
                    PicCard5.Image = ImageList1.Images[51];
                    card5Val = 10;
                    break;


            }

            totalVal = totalVal + card5Val;
            LblPlayerTotal.Text = totalVal.ToString() + " Total Score";
            totalValDealer = randomizer.Next(17, 25);
            LblDealerTotal.Text = totalValDealer.ToString() + "Dealer Score ";

            if (totalVal == 21)
            {
                MessageBox.Show("You Win");
                Application.Restart();
            }
            // if dealer score is 21 dealer wins
            else if(totalValDealer == 21)
            {
                MessageBox.Show("Dealer Wins");
                Application.Restart();
            }
            // if dealer and user both achieve 21 its a draw
            else if(totalVal == 21&&totalValDealer ==21)
            {
                MessageBox.Show("Draw!!!");
                Application.Restart();
                
            }
            //if final value is above or below 21 its a loss 
            else if (totalVal > 21 || totalVal < 21)
            {
                MessageBox.Show("You Lose");
                Application.Restart();
            }


        }

        // help button to show message box with all the rules of the game if needed
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Each card is drawn from a full standard pack of 52." + "\n" +
               "Assume that an Ace is worth 11 all the time. “2” is worth 2, “3” is worth 3" + "\n" +
               "and so on until 10. Jack, Queen and King are also worth 10." + "\n" +
               "The player draws 2 cards.If the total of the 2 cards is 21," + "\n" +
               "Blackjack is achieved and the player immediately wins the game." + "\n" +
               "Otherwise the player can Hold or continue to Draw up to 3 more cards." + "\n" +
               "If the score exceeds 21 the player is deemed bust and the Dealer wins." + "\n" +
               "Once the player holds or draws a 5th Card, the Dealer’s score is randomly generated and displayed." + "\n" +
               "Possible Dealer values are in the range 17 - 25." + "\n" +
               "The nearest hand scoring up to and including 21 is considered the winner.It is also possible to draw.");
        }

        private void BtnHelp_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Each card is drawn from a full standard pack of 52." + "\n" +
   "Assume that an Ace is worth 11 all the time. “2” is worth 2, “3” is worth 3" + "\n" +
   "and so on until 10. Jack, Queen and King are also worth 10." + "\n" +
   "The player draws 2 cards.If the total of the 2 cards is 21," + "\n" +
   "Blackjack is achieved and the player immediately wins the game." + "\n" +
   "Otherwise the player can Hold or continue to Draw up to 3 more cards." + "\n" +
   "If the score exceeds 21 the player is deemed bust and the Dealer wins." + "\n" +
   "Once the player holds or draws a 5th Card, the Dealer’s score is randomly generated and displayed." + "\n" +
   "Possible Dealer values are in the range 17 - 25." + "\n" +
   "The nearest hand scoring up to and including 21 is considered the winner.It is also possible to draw.");
        }
    }
}
