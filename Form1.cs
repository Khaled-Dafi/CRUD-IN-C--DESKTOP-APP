//CRUD in Desktop APP with MYphpadmin database 
//please make sure to download the Nuget database Libary in you project reffrance 
//Khaled Dafi 
using MySql.Data.MySqlClient;
using System.Data;

namespace testD2
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            //string mysqlCon = "server=127.0.0.1;user=root; database=employeerecord; password=";

        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //CREATE 
            // to Insert name 
            string connecrtion = "server=127.0.0.1;user=root; database=employeerecord; password=";
            string query = "INSERT INTO tbl_employee (FIRSTNAME, MI, LASTNAME, GENDER, POSITION) " +
            "VALUES ('" + this.FIRSTNAME.Text + "', '" + this.MI.Text + "', '" + this.LASTNAME.Text + "', '" + this.GENDER.Text + "', '" + this.POSITION.Text + "')";
            MySqlConnection conn = new MySqlConnection(connecrtion);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;

            conn.Open();

            dr = cmd.ExecuteReader();

            MessageBox.Show("Secussefly Saved");


            conn.Close();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            //UPTAE 
            //to Updaqte the Names
            string connecrtion = "server=127.0.0.1;user=root; database=employeerecord; password=";
            string query = "UPDATE tbl_employee SET FIRSTNAME='" + this.FIRSTNAME.Text + "', MI='" + this.MI.Text + "', LASTNAME='" + this.LASTNAME.Text + "', GENDER='" + this.GENDER.Text + "', POSITION='" + this.POSITION.Text + "' WHERE EMPID='" + this.EMPID.Text + "'";
            MySqlConnection conn = new MySqlConnection(connecrtion);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();

            dr = cmd.ExecuteReader();
            MessageBox.Show("RECORD IS UPDATE SUSSCFULLY");

            conn.Close();


        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            //READ
            //to show the data in the desktop app  
            string connecrtion = "server=127.0.0.1;user=root; database=employeerecord; password=";
            string query = "SELECT * FROM tbl_employee";
            MySqlConnection conn = new MySqlConnection(connecrtion);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            //DELETE
            string connecrtion = "server=127.0.0.1;user=root; database=employeerecord; password=";
            string query = "DELETE FROM tbl_employee WHERE EMPID ='" + this.EMPID.Text + "'";
            MySqlConnection conn = new MySqlConnection(connecrtion);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();

            dr = cmd.ExecuteReader();
            MessageBox.Show("RECORD IS DELETE ");

            conn.Close();

        }
    }
}
