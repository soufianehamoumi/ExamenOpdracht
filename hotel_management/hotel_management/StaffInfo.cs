using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel_management
{
    public partial class StaffInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\soufiane hamoumi\OneDrive\Documenten\Hoteldb.mdf"";Integrated Security=True;Connect Timeout=30");


        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        public StaffInfo()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff_tbl values('" + Staffidtbl.Text + "','" + Staffnamelbl.Text + "','" + Staffnumlbl.Text + "','" + Staffcountrytb.SelectedItem.ToString() + "','"+passwordlbl+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            Con.Close();
            populate();
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Staffbtn_Click(object sender, EventArgs e)
        {

            Con.Open();
            string myquery = "UPDATE Staff_tbl set Staffname = '" + Staffnamelbl.Text + "',Staffphone = '" + Staffnumlbl.Text + "',gender= '" + Staffcountrytb.SelectedItem.ToString() + "', Staffpassword ='"+passwordlbl.Text+"' where StaffId = " + Staffidtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff successfully edited");

            Con.Close();
            populate();
        }

        private void StaffGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Staffidtbl.Text = StaffGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Staffnamelbl.Text = StaffGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Staffnumlbl.Text = StaffGridView1.SelectedRows[0].Cells[2].Value.ToString();
            passwordlbl.Text = StaffGridView1.SelectedRows[0].Cells[3].Value.ToString();
  
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Staff_tbl where StaffId = " + Staffidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff successfully deleted");

            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Staff_tbl where Staffname = '" + searchStaff.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void fresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Form menu = new Main_Form();
            menu.Show();
            this.Hide();
        }
    }
}
