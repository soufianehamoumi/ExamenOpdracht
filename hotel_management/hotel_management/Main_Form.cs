using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientInfo clinfo = new ClientInfo();
            clinfo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffInfo Slinfo = new StaffInfo();
            Slinfo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Room rlinfo = new Room();
            rlinfo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reservetionInfo relinfo = new reservetionInfo();
            relinfo.Show();
            this.Hide();
        }
    }
}
