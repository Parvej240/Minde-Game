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

namespace Mind_Game
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GAME_database.mdf;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("player Name Is Empty");
                return;
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Email is Empty");
                return;
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("password is Empty");
                return;
            }
            con.Open();
            SqlCommand com = new SqlCommand(@"insert into player(name, password,email) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("player Is Created");

            FormClosed += (o, a) => new Registration().ShowDialog();
            Hide();
            Close();
        }

       

        private void Registration_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this .Hide ();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
