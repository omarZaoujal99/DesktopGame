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
    public partial class Stage2 : Form
    {
        public Stage2()
        {
            InitializeComponent();
        }

        private void ts2_Tick(object sender, EventArgs e)
        {
            pb_stg2_red.Location = Control.MousePosition;
            pb_stg2_red.Top = pb_stg2_red.Top - 52;
            if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_1.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_2.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_3.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_4.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_5.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_6.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_7.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_8.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_9.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_10.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_11.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_12.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_13.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_14.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_15.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_16.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_17.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_18.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_19.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_20.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (pb_stg2_red.Bounds.IntersectsWith(pb_stg2_win.Bounds))
            {
                pb_stg2_red.Top = 52;
                pb_stg2_red.Left = 52;
                ts2.Enabled = false;
                DialogResult stg1 = MessageBox.Show("You win");
                if (stg1.ToString() == "OK")
                {
                    Form stg3 = new Stage3();
                    stg3.Show();
                    this.Hide();
                }
            }
        }

        private void pb_stg2_red_Click(object sender, EventArgs e)
        {
            ts2.Enabled = true;
        }
    }
}
