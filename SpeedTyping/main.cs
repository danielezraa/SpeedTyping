using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedTyping
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        int wins = 0;
        int mistakes = 0;
        int clock = 0;
        int coinclock;
        double finalscore = 1.5F;
        double bestscore = 0;
        String[] wordarray = {
            "spring",
            "winter",
            "head",
            "court",
            "test",
            "wow",
            "daniel",
            "summer",
            "rebel",
            "bell",
            "youth",
            "coat",
            "orbit",
            "clap",
            "address",
            "well",
            "passion",
            "read",
            "attack",
            "greeting",
            "tell",
            "drown",
            "colorful",
            "congress",
            "remind",
            "whip",
            "polite",
            "build",
            "dose",
            "black",
            "boom",
            "coat",
            "notion",
            "lay",
            "strap",
            "flesh",
            "master",
            "rotten",
            "skate",
            "give",
            "convert",
            "jest",
            "pillow",
            "mobile",
            "salt",
            "glimpse",
            "pee",
            "eye",
            "cheat",
            "executive",
            "done",
        };
        public String[] arr = new String[20];        //size<<<<<<<<<
        
     
        private void main_Load(object sender, EventArgs e)
        {

        }

        //Buttons
        private void stopBN_Click(object sender, EventArgs e)
        {
            StopGame();
        }
        private void startBN_Click(object sender, EventArgs e)
        {
            if(usernameTB.Text == "")
            {
                MessageBox.Show("Please enter your name");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(usernameTB.Text, "^[a-zA-Z ]*$"))
            {
                MessageBox.Show("You may only enter letters", "Error");
                return;
            }
            highscoreBN.Visible = false;
            newLB.Visible = false;
            ArrayGenerator(6);
            compRTB.Text = CompSentence();
            wordscompletedTB.Text = "0";
            mistakesTB.Text = "0";

            StartGame();
        }

        //CheckBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        //TextBox
        private void userTB_KeyPress(object sender, KeyPressEventArgs e)   //user press space
        {

            if (e.KeyChar == ' ')
            {
                if (WordCheck(userTB.Text, arr[wins]))
                {
                    MarkWordGreen();
                    userTB.Text = "";
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                    if (deleteifincorrectCB.Checked)
                        userTB.Text = "";
                    MarkWordRed();
                }
            }
            if (e.KeyChar == (char)13)
            {
                if (WordCheck(userTB.Text, arr[wins]))
                {
                    MarkWordGreen();
                    userTB.Text = "";
                    e.Handled = true;
                }
                else
                {
                    if (deleteifincorrectCB.Checked)
                        userTB.Text = "";
                    MarkWordRed();
                    e.Handled = true;
                }
            }



        }
        private void compTB_TextChanged(object sender, EventArgs e)
        {

        }

        //Timer
        private void gametimer_Tick(object sender, EventArgs e)
        {
            ++clock;
            if (clock == 1)
            {
                timerBN.Text = "SET!";
            }
            if (clock == 2)
            {
                timerBN.Text = "GO!";
                userTB.Enabled = true;
                userTB.Select();
            }
            if (clock >= 3)
            {
                timerBN.Text = (18 - clock).ToString();
                if ((20 - clock) < 3)
                {
                    timerBN.Text = "Finished";
                    CalScore();
                    StopGame();
                }

            }


        }
        private void cointimer_Tick(object sender, EventArgs e)

        {
            //coinclock++;
            //if (coinclock == 0)
            //{
            //    Point temp = coin1.Location;
            //    Random rnd = new Random();
            //    int randomx;
            //    randomx = rnd.Next(12, 90);
            //    temp.X = randomx;
            //    temp.Y = -100;
            //    coin1.Location = temp;
            //}
            //else
            //{
            //    Point temp = coin1.Location;
            //    temp.Y += 10;
            //    coin1.Location = temp;
            //    if (temp.Y >= 60)
            //        cointimer.Stop();
            //}

        }

        //Methods
        private void StopGame()
        {
            gametimer.Stop();
            userTB.Text = "";
            userTB.Enabled = false;
        }
        private void CalScore()
        {
            
            float temp = wins / 15F;
            if (bestscore < temp)
            {
                bestscore = temp;
                HighScore();
            }
            finalscore = temp;
            lastsocrepersecTB.Visible = true;
            lastsocrepersecTB.Text = "Last game words per second = " + finalscore.ToString("0.##");
        }
        void RefreshScore(bool b)
        {
            if (b)  //true = win
            {
                wordscompletedTB.Text = "" + ++wins;
            }
            else
            {
                mistakesTB.Text = "" + ++mistakes;
            }
        }
        private string CompSentence()
        {
            int size = arr.Length;
            string tmp = null;
            for (int i = 0; i < size; i++)
            {
                tmp += arr[i] + " ";
            }
            return tmp;
        }
        private void MarkWordGreen()
        {
            int length = wins;
            for (int i = 0; i < wins; i++)
            {
                length += arr[i].Length;
            }

            compRTB.Select(0, length);
            compRTB.SelectionColor = Color.Green;
        }
        private void MarkWordRed()
        {
            int length = wins;
            for (int i = 0; i < wins; i++)
            {
                length += arr[i].Length;
            }

            compRTB.Select(length, arr[wins].Length);
            compRTB.SelectionColor = Color.Red;
        }
        void ArrayGenerator(int size)
        {
            Random rnd = new Random();
            int random;
            for (int i = 0; i < 20; i++)            //size<<<<<
            {
                random = rnd.Next(1, 50);
                arr[i] = wordarray[random];
            }
        }
        private void StartGame()
        {
            clock = 0;
            wins = 0;
            mistakes = 0;
            timerBN.Text = "Get Ready!";
            gametimer.Start();
            timerBN.Visible = true;
        }
        public string GetFirstWord(string s)
        {
            string firstWord = s.Split(new char[] { ' ' })[0];
            return firstWord;
        }
        public bool WordCheck(string user, string computer)
        {
            if (string.Compare(user, computer) == 0)
            {
                RefreshScore(true);
                if (wins == 20)
                    StopGame();
                cointimer.Start();
                return true;
            }
            RefreshScore(false);

            return false;

        }
        private void HighScore()
        {
            highscoreBN.Visible = true;
            newLB.Visible = true;
            highscoreBT.Visible = true;
            highscoreBT.Text = usernameTB.Text + ": " + bestscore.ToString("0.##") + " words per second!";
        }
        private void CoinDrop()
        {

        }

        
    }
}
