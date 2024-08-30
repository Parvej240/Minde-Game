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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GAME_database.mdf;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            string playerName = textBox1.Text;
            string playerPass = textBox2.Text;

            SqlCommand cmd = new SqlCommand("select name,password from player where name='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("Login Successful");
                Game game = new Game();
                game.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed Please Check player name and Passoward Or Create New player");
            }
            con.Close();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
