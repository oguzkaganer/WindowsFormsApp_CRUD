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

namespace WindowsFormsApp_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;
        SqlDataReader sqlDataReader;
        
        void connection()
        {
            sqlConnection = new SqlConnection("Data Source=403-08;Initial Catalog=dbApp;User ID=sa;Password=1234");
            sqlConnection.Open();
        }
        

        private void btn_save_Click(object sender, EventArgs e)
        {
            connection();
            sqlCommand = new SqlCommand("insert into Users values ('" + txt_firstName.Text + "','" + txt_lastName.Text + "','" + txt_username.Text + "','" + txt_password.Text + "')",sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            connection();
            sqlCommand = new SqlCommand("Select * from Users where Id=@id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id",txt_id.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                txt_up_firstName.Text = sqlDataReader["FirstName"].ToString();
                txt_up_lastName.Text = sqlDataReader["LastName"].ToString();
                txt_up_username.Text = sqlDataReader["UserName"].ToString();
                txt_up_password.Text = sqlDataReader["Password"].ToString();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            connection();
            sqlDataAdapter = new SqlDataAdapter("Select * From Users", sqlConnection);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Users");
            dgv_list.DataSource = dataSet.Tables["Users"];
            sqlCommand = new SqlCommand("Select * From Users", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbx_list.Items.Add(sqlDataReader["Id"].ToString() +" "+ sqlDataReader["FirstName"].ToString());
                //List<SqlDataReader> users = new List<SqlDataReader>() { };
                //users.Add(sqlDataReader);
                //cbx_list.Items.AddRange(sqlDataReader);

                //cbx_list.DisplayMember = sqlDataReader["FirstName"].ToString();
                //cbx_list.ValueMember = sqlDataReader["Id"].ToString();
            }
            

            sqlConnection.Close();
        }

        private void btn_up_save_Click(object sender, EventArgs e)
        {
            connection();
            sqlCommand = new SqlCommand("update Users set FirstName=@firstname,LastName=@lastname,UserName=@username,Password=@password where Id=@id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", txt_id.Text);
            sqlCommand.Parameters.AddWithValue("@firstname", txt_up_firstName.Text);
            sqlCommand.Parameters.AddWithValue("@lastname", txt_up_lastName.Text);
            sqlCommand.Parameters.AddWithValue("@username", txt_up_username.Text);
            sqlCommand.Parameters.AddWithValue("@password", txt_up_password.Text);
            sqlCommand.ExecuteNonQuery();
            sqlDataAdapter = new SqlDataAdapter("Select * From Users", sqlConnection);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Users");
            dgv_list.DataSource = dataSet.Tables["Users"];
            sqlConnection.Close();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            connection();
            sqlCommand = new SqlCommand("Delete from Users where Id=@id", sqlConnection);
            var p = cbx_list.Text.IndexOf(' ');
            sqlCommand.Parameters.AddWithValue("@id",cbx_list.Text.Substring(0, p > -1 ? p : cbx_list.Text.Length));
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            
        }
    }
}
