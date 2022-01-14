using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_mania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         
            InitializeComponent();
            label1.Visible = false;
            retry.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(Gamespeed);
            enemy(Gamespeed);
            gameover();
        }


        Random r = new Random();
        int x, y=0;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(6, 128);
                enemy1.Location = new Point(x, y);   
            }
            else
            { enemy1.Top += speed; }

            if (enemy2.Top >= 500)
            {
                x = r.Next(130, 301);
                enemy2.Location = new Point(x, y);
            }
            else
            { enemy2.Top += speed; }

            if (enemy3.Top >= 500)
            {
                x = r.Next(190, 301);
                enemy3.Location = new Point(x, y);
            }
            else
            { enemy3.Top += speed; }

        }

        void gameover()
        {
            if (Car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                retry.Visible = true;
               
            }
            if(Car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                retry.Visible = true;
            }
            if(Car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                retry.Visible = true;
            }
        }



        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else
            { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else
            { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else
            { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else
            { pictureBox4.Top += speed; }

            if (pictureBox5.Top >= 500)
            { pictureBox5.Top = 0; }
            else
            { pictureBox5.Top += speed; }

            if (pictureBox6.Top >= 500)
            { pictureBox6.Top = 0; }
            else
            { pictureBox6.Top += speed; }


        }
        
      

        //Key controls to left right and UP DOWN to increment and decrement speed   
        int Gamespeed = 5;

        private void retry_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            retry.Visible = false;
            label1.Visible = false;
            Car.Location = new Point(100,361);
            enemy1.Location = new Point(36, 52);
            enemy2.Location = new Point(299, 26);
            enemy3.Location = new Point(195, 237);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left )
            {
                if (Car.Left > 12)
                    Car.Left += -8;
            }
            if (e.KeyCode == Keys.A)
            {
                if (Car.Left > 12)
                    Car.Left += -8;
            }

            if (e.KeyCode == Keys.Right)
            {
                if (Car.Right<363)
                    Car.Left += 8;
            }
            if (e.KeyCode == Keys.D)
            {
                if (Car.Left <363)
                    Car.Left += 8;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (Gamespeed < 21)
                {
                    Gamespeed++;
                }
            }

            if (e.KeyCode == Keys.W)
            {
                if (Gamespeed < 21)
                {
                    Gamespeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (Gamespeed > 0)
                {
                    Gamespeed--;
                }
            }

            if (e.KeyCode == Keys.S)
            {
                if (Gamespeed > 0)
                {
                    Gamespeed--;
                }
            }

        }
    }
}
