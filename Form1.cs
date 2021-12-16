using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameGrigorjev
{
    public partial class Form1 : Form
    {

        TreeView tree;
        PictureBox pctBox, pctBox2,pctGm,pctGm1,pctGm2,pctGm3;
        RadioButton rdBut, rdBut2, rdBut3;
        Button btn, btn1, btn2, btn3;
        Label lbl1,lbl2;
        string playerChoice;
        string playerChoice2;
        string command;
        string playerChoice3;


        Random rnd = new Random();


        public Form1()
        {
            this.Height = 1000;
            this.Width = 1000;
            this.Text = "Game";
            
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("KamenNozBumaga");
            MessageBox.Show("                                   Palun minu sõber tee esimene lahti\n\n                      Settings sest Regglid , kui sa tehksid seda sina saad                                                             lahti mängi teha            \n");
            
            tn.Nodes.Add(new TreeNode("Game"));
            
            tn.Nodes.Add(new TreeNode("Settings"));

            tn.Nodes.Add(new TreeNode("Mängu reeglid"));






            //PICTURES 
            pctBox = new PictureBox();
            pctBox.Size = new Size(120, 110);
            pctBox.Location = new Point(300, 100);
            //pctBox.DoubleClick += PctBox_DoubleClick;
            pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBox.Image = Image.FromFile(@"..\..\Images\player1.png");



            //random
            

           

            pctBox2 = new PictureBox();
            pctBox2.Size = new Size(120, 110);
            pctBox2.Location = new Point(600, 100);
            //pctBox.DoubleClick += PctBox_DoubleClick;
            pctBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBox2.Image = Image.FromFile(@"..\..\Images\player2.png");

          

            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void PctBox3_DoubleClick(object sender, EventArgs e)
        {
            
        }



        // private void Btn_Click(object sender, EventArgs e)
        //{

        // }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Game")
            {


                MessageBox.Show("Tere, sõber see on mäng kivi-paber-käärid");

                this.Controls.Add(pctBox);
                this.Controls.Add(pctBox2);
                rdBut.Visible = false;
                rdBut2.Visible = false;
                rdBut3.Visible = false;
               
                lbl1.Visible = false;
                lbl2.Visible = false;


                btn = new Button();
                btn.Text = "Alustama mängi";
                btn.Location = new Point(500, 50);
                btn.Height = 150;
                btn.Width = 200;

                btn1 = new Button();
                btn1.Text = "Käärid";
                btn1.Location = new Point(230, 260);
                btn1.Height = 25;
                btn1.Width = 75;
                btn1.Click += Btn1_Click;
                this.Controls.Add(btn1);

                btn2 = new Button();
                btn2.Text = "Kivi";
                btn2.Location = new Point(310, 260);
                btn2.Height = 25;
                btn2.Width = 75;
                btn2.Click += Btn2_Click; ;
                this.Controls.Add(btn2);

                btn3 = new Button();
                btn3.Text = "Paber";
                btn3.Location = new Point(390, 260);
                btn3.Height = 25;
                btn3.Width = 75;
                btn3.Click += Btn3_Click;
                this.Controls.Add(btn3);


            }
            else if (e.Node.Text == "Settings")
            {
                rdBut = new RadioButton();
                rdBut.Text = "Esimene fon";
                rdBut.Location = new Point(150, 10);

                rdBut2 = new RadioButton();
                rdBut2.Location = new Point(300, 10);
                rdBut2.Text = "Teine fon";


                rdBut3 = new RadioButton();
                rdBut3.Text = "Kustuta Fon";
                rdBut3.Location = new Point(450, 10);

                
                




                this.Controls.Add(rdBut);
                this.Controls.Add(rdBut2);
               
                this.Controls.Add(rdBut3);
                


                rdBut.CheckedChanged += new EventHandler(rdBut_Checked);
                rdBut2.CheckedChanged += new EventHandler(rdBut_Checked);
                rdBut3.CheckedChanged += new EventHandler(rdBut_Checked);

                

            }
            else if (e.Node.Text == "Mängu reeglid")
            {
                lbl1 = new Label();
                lbl1.Text = "Botiga mängimine.Valite kolme pildi vahel, ühe pildi, samal ajal kui võitlete juhusliku pildi viskava robotiga.";
                

                lbl1.Size = new Size(600, 30);
                lbl1.Location = new Point(150, 300);

                lbl2 = new Label();
                lbl2.Text = "Mängige seltsimehe / sõbra / või vaenlase vastu.Kivist paberikääride standardreeglid.";
                lbl2.Size = new Size(600, 30);
                lbl2.Location = new Point(150, 350);

                this.Controls.Add(lbl1);
                this.Controls.Add(lbl2);
            }

        }
        private void nextRound()
        {
            playerChoice = "mitte";
            command = "mitte";
            pctBox1.Image = Properties.Resources.;
            pb_bot.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_user.Image = Properties.Resources.vopros;
            pb_user.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Btn2_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            playerChoice = "kivi";
            pb_.Image = Properties.Resources.Kivi;
            pb_user.SizeMode = PictureBoxSizeMode.StretchImage;
            if (playerChoice == "kivi" || playerChoice == "paber" || playerChoice == "käärid")
            {
                randomNumber = rnd.Next(0, 3);
                command = AIchoice[randomNumber];
                switch (command)
                {
                    case "kivi":
                        pb_bot.Image = Properties.Resources.Kivi;
                        pb_bot.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case "paber":
                        pb_bot.Image = Properties.Resources.Paber;
                        pb_bot.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case "käärid":
                        pb_bot.Image = Properties.Resources.Käärid;
                        pb_bot.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;

                    default:
                        break;
                }
            
        }

        

        private void rdBut_Checked(object sender, EventArgs e)
        {
            if (rdBut.Checked)
            {
                this.BackColor = Color.Blue;

            }
            else if (rdBut2.Checked)
            {
                this.BackColor = Color.Purple;

            }
            else if (rdBut3.Checked)
            {

                this.BackColor = Color.White;
                this.BackgroundImage = null;


            }
            
        }
    }
}
