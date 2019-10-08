using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_Game_Ashu
{
    public partial class Form1 : Form
    {
        //object of the random classes that is used to generate the random no and move the dog according to that no 
        Random rd = new Random();

         // Array object of the details class that is used to save the details of the player with the name bet amount etc
        details[] obj_details =new details[3];
        // store the value of the winner in the variable to compare and generate the result 
        int indx = 0,winner=0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Players_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Details_Click(object sender, EventArgs e)
        {
             //this is the exception handling format that is used to check the error from the code if there is an error the code is automaticlally move to the ctach block 
            try {
            
                // split the value of the list box and pass to the variable the name using the split function with help of index method
                String Name = Players.SelectedItem.ToString().Substring(0, Players.SelectedItem.ToString().IndexOf(" "));


                int cnt = 0;
                //this code is used to compare the value and store the details in the listbox if there is an duplicacy then the error will be generated 
                for (int x = 0; x < BetDetails.Items.Count; x++)
                {
                    // condiition is  there that is used to compare the name with the list box using the containe method 
                    if (BetDetails.Items[x].ToString().Contains(Name))
                    {
                        MessageBox.Show("Player is Already Selected ");
                        cnt++;
                    }

                }
                 // if the player is unique then the record will save to the list box with relevent details like dog no and bet amount 
                String[] data = Players.SelectedItem.ToString().Split(' ');

                if (cnt == 0 && Convert.ToInt32(data[2]) >= Amount.Value)
                {
                    BetDetails.Items.Add(Name + " has set bet of " + Amount.Value + " on this Dog in Dog Race: " + Contestant.Value);
                    btnStart.Visible = true;


                    obj_details[indx] = new details(Name, Convert.ToInt32(Contestant.Value), Convert.ToInt32(Amount.Value), Convert.ToInt32(data[2]));


                    indx++;

                }
                else {
                    MessageBox.Show("Amount is greater than the budget");
                }
                }
                catch (Exception es) {
                    MessageBox.Show("Select the player first ");
                    }
           

            }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // this is the timer start that is used to start the game 
            timer1.Start();
        }

        // userdefine method that is used to find the winner of the game and also increase his account or decrease his account value according to the condition 
        public void victory() {

            //with the help of loop we can update the account of the details 
            for (int x=0;x<indx;x++) {

                
                int balance=obj_details[x].Playerbalance(winner);

                // also update the list box with the relevant balance 
                for (int j=0;j<3;j++) {
                    if (Players.Items[j].ToString().Contains(obj_details[x].Name))
                    {
                        Players.Items[j] = obj_details[x].Name + " Balance  " + balance + " Betting Amount  in his Account";
                    }
                }
                
            }
            // reset the game with after finishing the game 
            BetDetails.Items.Clear();
            Amount.Value = 1;
            Contestant.Value = 1;
            FirstContestant.Left = 0;
            secndContestant.Left = 0;
            thrdContestant.Left = 0;
            ForthContestant.Left = 0;
            indx = 0;
            winner = 0;
            btnStart.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // timer is used to move the dog image from one location to another and display the name of the winner dog
            if (FirstContestant.Left > 680)
            {
                timer1.Stop();
                MessageBox.Show("Winner of this Betting Race is: Dog1");
                
                winner = 1;
                victory();
            }
            else {
                // move the dog from one location to another 
                FirstContestant.Left += rd.Next(1, rd.Next(1, 23));
            }


            // this code is same as working above 
            if (secndContestant.Left > 680)
            {
                timer1.Stop();
                winner = 2;
                MessageBox.Show("Winner of this Betting Race is: Dog2");
                victory();
            }
            else {
                secndContestant.Left += rd.Next(1, rd.Next(1, 23));
            }


            if (thrdContestant.Left>680) {
                timer1.Stop();
                winner = 3;
                MessageBox.Show("Winner of this Betting Race is: Dog3");
                victory();
            }
            else {

                thrdContestant.Left += rd.Next(1, rd.Next(1, 23));
            }

            if (ForthContestant.Left>680)
            {
                timer1.Stop();
                winner = 4;
                MessageBox.Show("Winner of this Betting Race is: Dog4");
                victory();
            }
            else {
                ForthContestant.Left += rd.Next(1, rd.Next(1, 23));
            }

        }
    }
}
