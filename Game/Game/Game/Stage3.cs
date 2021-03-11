using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Game
{
    public partial class Stage3 : Form
    {
        public Stage3()
        {
            InitializeComponent();
        }

        private void pb_stg3_red_Click(object sender, EventArgs e)
        {
            ts3.Enabled = true;
        }

        private void ts3_Tick(object sender, EventArgs e)
        {
            pb_stg3_red.Location = Control.MousePosition;
            pb_stg3_red.Top = pb_stg3_red.Top - 46;
            if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_1.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_2.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_3.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_4.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_5.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_6.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_7.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_8.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_9.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_10.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_11.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_12.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_13.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_14.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_15.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_16.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_17.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_18.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg3_red.Bounds.IntersectsWith(pb_stg3_win.Bounds))
            {
                pb_stg3_red.Top = 45;
                pb_stg3_red.Left = 45;
                ts3.Enabled = false;
                DialogResult stg1 = MessageBox.Show("You win");
                if (stg1.ToString() == "OK")
                {
                    Form form = new Form1();
                    form.Show();
                    this.Hide();
                }
            }
        }
    }
}
