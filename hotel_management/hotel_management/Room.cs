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
    public partial class Room : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\soufiane hamoumi\OneDrive\Documenten\Hoteldb.mdf"";Integrated Security=True;Connect Timeout=30");

        public Room()
        {
            InitializeComponent();
        }

        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (Yes.Checked == true)
                isfree = "free";
            else isfree = "busy";

            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Room_tbl values('" + roomidtbl.Text + "','" + roomphonelbl.Text + "','" + isfree+ "' )", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Added");
            Con.Close();
            populate();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void RoomGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomidtbl.Text = RoomGridView1.SelectedRows[0].Cells[0].Value.ToString();
            roomphonelbl.Text = RoomGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void DeleteRoombtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Room_tbl where RoomId = " + roomidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("room successfully deleted");

            Con.Close();
            populate();
        }

        private void Roombtn_Click(object sender, EventArgs e)
        {

            string isfree;
            if (Yes.Checked == true)
                isfree = "free";
            else isfree = "busy";

            Con.Open();
            string myquery = "UPDATE Room_tbl set RoomPhone = '" + roomphonelbl.Text + "',RoomFree = '" +isfree + "'where RoomId = " + roomidtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room successfully edited");

            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Room_tbl where ClientName = '" + searchRoom.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView1.DataSource = ds.Tables[0];
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
