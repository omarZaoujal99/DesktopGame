using Game.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void t1_Tick(object sender, EventArgs e)
        {
            this.pb1.Increment(1);
            pb1.PerformStep();
            if(pb1.Value == 100)
            {
                t1.Enabled = false;
                Form stg1 = new Stage1();
                stg1.Show();
                this.Hide();
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            pb1.Maximum = 100;
            pb1.Minimum = 0;
            pb1.Step = 1;
            t1.Start();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure ?","" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            t1.Start();
        }
    }
}
