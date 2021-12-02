﻿using System;
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
        PictureBox pctBox, pctBox2;
        RadioButton rdBut, rdBut2,rdBut3;
        Button btn;





        public Form1()
        {
            this.Height = 1000;
            this.Width = 1000;
            this.Text = "Game";
            
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("KamenNozBumaga");
            tn.Nodes.Add(new TreeNode("Game"));
            tn.Nodes.Add(new TreeNode("Settings"));



          


            //PICTURES 
            pctBox = new PictureBox();
            pctBox.Size = new Size(120, 110);
            pctBox.Location = new Point(300, 100);
            //pctBox.DoubleClick += PctBox_DoubleClick;
            pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBox.Image = Image.FromFile(@"..\..\Images\player1.png");

            pctBox2 = new PictureBox();
            pctBox2.Size = new Size(120, 110);
            pctBox2.Location = new Point(600, 100);
            //pctBox.DoubleClick += PctBox_DoubleClick;
            pctBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBox2.Image = Image.FromFile(@"..\..\Images\player2.png");

            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

       // private void Btn_Click(object sender, EventArgs e)
        //{
            
       // }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Game")
            {
                this.Controls.Add(pctBox);
                this.Controls.Add(pctBox2);
                rdBut.Visible = false;
                rdBut2.Visible = false;
                rdBut3.Visible = false;

                btn = new Button();
                btn.Text = "Alustama mängi";
                btn.Location = new Point(500, 50);
                btn.Height = 150;
                btn.Width = 200;
                

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


        }   }
    }   
}