using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Project1_Game
{
    public partial class Mainform : Form
    {
        int inputPlayer, cpuPlayer;
        int cpuScore = 0;
        int plyerScore = 0;

        public Mainform()
        {
            InitializeComponent();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
             this.player_text.Clear();
                this.cpu_text.Clear();
                this.player_score_txt.Clear();
                this.cpu_score_txt.Clear();
            this.result_text.Clear();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
          
           if (plyerScore < 3 && cpuScore < 3)
            {
                

                inputPlayer = int.Parse(this.player_text.Text); //GET USER INPUT



                Random rmd = new Random();
                int cpuInput = rmd.Next(1, 4);

                this.cpu_text.Text = cpuInput.ToString();


                switch (cpuInput)
                {

                    case 1:
                        cpuPlayer = 1;//No 1=Rock
                        if (inputPlayer == 1)
                        {

                            this.result_text.Text = "Match draw";
                        }
                        else if (inputPlayer ==2) //NO 2=SCISSOR
                        {
                            this.result_text.Text = "Match won other Team";
                            cpuScore++;
                        }
                        else if (inputPlayer == 3) //no 3=PAPER
                        {
                            this.result_text.Text = "Match won Our Team";
                            plyerScore++;
                        }
                        else
                        {
                            this.result_text.Text = "Invalid";
                        }
                        break;
                    case 2:
                        cpuPlayer = 2; //cpu player paper
                        if (inputPlayer == 1)//No 1=Rock
                        {


                            this.result_text.Text = "Match won other Team";
                            cpuScore++;
                        }
                        else if (inputPlayer == 2) //NO 2=SCISSOR
                        {
                            this.result_text.Text = "Match won Our Team";
                            plyerScore++;
                        }
                        else if (inputPlayer == 3) //no 3=PAPER
                        {

                            this.result_text.Text = "Match draw";
                        }
                        else
                        {
                            this.result_text.Text = "Invalid";
                        }
                        break;
                    case 3:
                        cpuPlayer = 3; //No3 SCISSOR
                        if (inputPlayer ==1)//No 1=Rock
                        {

                            this.result_text.Text = "Match won Our Team";
                            plyerScore++;

                        }
                        else if (inputPlayer == 2) //NO 2=SCISSOR
                        {

                            this.result_text.Text = "Match draw";
                        }
                        else if (inputPlayer ==3) //no 3=PAPER
                        {
                            this.result_text.Text = "Match won other Team";
                            cpuScore++;
                        }
                        else
                        {
                            this.result_text.Text = "Invalid";
                        }
                        break;


                        

                        // cpu_text.Clear();
                        // player_text.Clear();




                }
              

                

            }
           else if(plyerScore==3)
            {
                MessageBox.Show("Game Won Our Team","MessageBox",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.cpu_score_txt.Text = cpuScore.ToString();
                this.player_score_txt.Text = plyerScore.ToString();

            }
            else
            {
                MessageBox.Show("Game Won Opposite Team", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cpu_score_txt.Text = cpuScore.ToString();
                this.player_score_txt.Text = plyerScore.ToString();
            }


        }
    }
}
