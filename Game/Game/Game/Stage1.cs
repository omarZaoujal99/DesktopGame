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
    public partial class Stage1 : Form
    {
        public Stage1()
        {
            InitializeComponent();
        }


        private void ts1_Tick(object sender, EventArgs e)
        {
            s1_pbc1.Location = Control.MousePosition;
            s1_pbc1.Top = s1_pbc1.Top - 37;
            if (s1_pbc1.Bounds.IntersectsWith(s1_pb2.Bounds))
            {
                s1_pbc1.Top = 38;
                s1_pbc1.Left = 38;
                ts1.Enabled = false;
                MessageBox.Show("You lost");

            }
            else if (s1_pbc1.Bounds.IntersectsWith(s1_pb3.Bounds))
            {
                s1_pbc1.Top = 38;
                s1_pbc1.Left = 38;
                ts1.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (s1_pbc1.Bounds.IntersectsWith(s1_pb4.Bounds))
            {
                s1_pbc1.Top = 38;
                s1_pbc1.Left = 38;
                ts1.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (s1_pbc1.Bounds.IntersectsWith(s1_pb5.Bounds))
            {
                s1_pbc1.Top = 38;
                s1_pbc1.Left = 38;
                ts1.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (s1_pbc1.Bounds.IntersectsWith(s1_pb6.Bounds))
            {
                s1_pbc1.Top = 38;
                s1_pbc1.Left = 38;
                ts1.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (s1_pbc1.Bounds.IntersectsWith(s1_pb7.Bounds))
            {
                s1_pbc1.Top = 38;
                s1_pbc1.Left = 38;
                ts1.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (s1_pbc1.Bounds.IntersectsWith(s1_pb8.Bounds))
            {
                s1_pbc1.Top = 38;
                s1_pbc1.Left = 38;
                ts1.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (s1_pbc1.Bounds.IntersectsWith(s1_pb9.Bounds))
            {
                s1_pbc1.Top = 38;
                s1_pbc1.Left = 38;
                ts1.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (s1_pbc1.Bounds.IntersectsWith(s1_pb10.Bounds))
            {
                s1_pbc1.Top = 38;
                s1_pbc1.Left = 38;
                ts1.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (s1_pbc1.Bounds.IntersectsWith(s1_pb11.Bounds))
            {
                s1_pbc1.Top = 38;
                s1_pbc1.Left = 38;
                ts1.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (s1_pbc1.Bounds.IntersectsWith(s1_pb13.Bounds))
            {
                s1_pbc1.Top = 38;
                s1_pbc1.Left = 38;
                ts1.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (s1_pbc1.Bounds.IntersectsWith(s1_pb14.Bounds))
            {
                s1_pbc1.Top = 38;
                s1_pbc1.Left = 38;
                ts1.Enabled = false;
                MessageBox.Show("You lost");
            }
            else if (s1_pbc1.Bounds.IntersectsWith(s1_pbw1.Bounds))
            {
                s1_pbc1.Top = 38;
                s1_pbc1.Left = 38;
                ts1.Enabled = false;
                DialogResult stg1 = MessageBox.Show("You win");
                if(stg1.ToString() == "OK")
                {
                    Form stg2 = new Stage2();
                    stg2.Show();
                    this.Hide();
                }

            }

        }

        private void s1_pbc1_Click(object sender, EventArgs e)
        {
            ts1.Enabled = true;
        }
    }
}
