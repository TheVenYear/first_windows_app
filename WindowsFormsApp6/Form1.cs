using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Image p1 = Image.FromFile(Environment.CurrentDirectory + @"\" + "enter_hover.png");
            pictureBox1.BackgroundImage = p1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Image p1 = Image.FromFile(Environment.CurrentDirectory + @"\" + "enter.png");
            pictureBox1.BackgroundImage = p1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            Image p1 = Image.FromFile(Environment.CurrentDirectory + @"\" + "slideSEL.png");
            pictureBox3.BackgroundImage = p1;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Image p1 = Image.FromFile(Environment.CurrentDirectory + @"\" + "slide.png");
            pictureBox3.BackgroundImage = p1;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {

            Image p1 = Image.FromFile(Environment.CurrentDirectory + @"\" + "ButtonNETsel.png");
            pictureBox5.BackgroundImage = p1;
        }
        private void pictureBox5_Mouseleave(object sender, EventArgs e)
        {

            Image p1 = Image.FromFile(Environment.CurrentDirectory + @"\" + "ButtonNET.png");
            pictureBox5.BackgroundImage = p1;
        }
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {

            Image p1 = Image.FromFile(Environment.CurrentDirectory + @"\" + "ButtonDAsel.png");
            pictureBox4.BackgroundImage = p1;
        }
        private void pictureBox4_Mouseleave(object sender, EventArgs e)
        {

            Image p1 = Image.FromFile(Environment.CurrentDirectory + @"\" + "ButtonDA.png");
            pictureBox4.BackgroundImage = p1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}