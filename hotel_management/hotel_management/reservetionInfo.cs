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
    public partial class reservetionInfo : Form
    {
        public reservetionInfo()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\soufiane hamoumi\OneDrive\Documenten\Hoteldb.mdf"";Integrated Security=True;Connect Timeout=30");

        DateTime today;

        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            reservGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        public void fillRoomcombo()
        {

            Con.Open();
            string roomstate = "free";
            SqlCommand cmd = new SqlCommand("select RoomId from Room_tbl where RoomFree ='"+roomstate+"' ",Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomId", typeof(int));
            dt.Load(rdr);
            Roomnumber.ValueMember = "RoomId";
            Roomnumber.DataSource = dt;
            Con.Close();
        }

        public void fillClientcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ClientName from Client_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName", typeof(string));
            dt.Load(rdr);
            clientname.ValueMember = "ClientName";
            clientname.DataSource = dt;
            Con.Close();
        }
        private void reservetionInfo_Load(object sender, EventArgs e)
        {
            today = dateTimePicker1.Value;
            fillRoomcombo();
            fillClientcombo();
            populate();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int res =DateTime.Compare(dateTimePicker1.Value, today);
            if (res < 0)
                MessageBox.Show("Wrong Date For Reservation ");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateTimePicker2.Value,dateTimePicker1.Value);
            if (res < 0)
                MessageBox.Show("Wrong DateOut , check once more ");
        }

        public void updateroomstate()
        {

            Con.Open();
            string newstate = "busy ";
            string myquery = "UPDATE Room_tbl set RoomFree = '" +newstate  + "', where RoomId = " + Convert.ToInt32(Roomnumber.SelectedValue.ToString()) + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Reservation successfully edited");

            Con.Close();
            fillRoomcombo();
            populate();
        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values('" + reservidtbl.Text + "','" + clientname.SelectedValue.ToString() + "','" + Roomnumber.SelectedValue.ToString() + "','" + dateTimePicker1.Value + "',,'" + dateTimePicker2.Value + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Successfully Added");
            Con.Close();
            updateroomstate();
            populate();
            
        }

        private void reservGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reservidtbl.Text = reservGridView1.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void DeleteRoombtn_Click(object sender, EventArgs e)
        {

            if (DeleteRoombtn.Text == "")
            {
                MessageBox.Show("Enter the reservation to be deleted");

            }else
            {
                Con.Open();
                string query = "delete from Reservation_tbl where ResId = " + DeleteRoombtn.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("reservation successfully deleted");

                Con.Close();
                populate();

            }
           
        }

        private void Roombtn_Click(object sender, EventArgs e)
        {
            if(reservationid.Text == "")
            {
                MessageBox.Show("Empty ResId, Enter The Reservation Id");

            }
            else
            {
                Con.Open();
                string myquery = "UPDATE Reservation_tbl set Client = '" + clientname.SelectedValue.ToString() + "',Room = '" + Roomnumber.SelectedValue.ToString() + "',DateIn=  '" + dateTimePicker1.Value.ToString() + "',DateOut = " + dateTimePicker2.Value.ToString() + "' where ResId = " + reservationid.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation successfully edited");

                Con.Close();
                populate();
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Reservation_tbl where ResId = '" + button4.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
           reservGridView1.DataSource = ds.Tables[0];
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
