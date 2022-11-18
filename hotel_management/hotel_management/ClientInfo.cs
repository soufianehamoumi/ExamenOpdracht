using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel_management
{
    public partial class ClientInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\soufiane hamoumi\OneDrive\Documenten\Hoteldb.mdf"";Integrated Security=True;Connect Timeout=30");
     
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        
        public ClientInfo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            populate();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client_tbl values('"+clientidtbl.Text+ "','"+clientnamelbl.Text+ "','"+clientnumlbl.Text+ "','"+clientcountrytb.SelectedItem.ToString()+"')",Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            Con.Close();
            populate();
        }

        

        private void Editbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Client_tbl set ClientName = '" + clientnamelbl.Text + "',ClientPhone = '" + clientnumlbl.Text + "',ClientCountry= '" + clientcountrytb.SelectedItem.ToString() + "'where ClientId = "+clientidtbl.Text+";";
            SqlCommand cmd = new SqlCommand(myquery,Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client successfully edited");

            Con.Close();
            populate();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Client_tbl where ClientId = " + clientidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("client successfully deleted");

            Con.Close();
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clientidtbl.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            clientnamelbl.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            clientnumlbl.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Client_tbl where ClientName = '"+ search.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
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
