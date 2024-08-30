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
    public partial class player : Form
    {
        public player()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\00172097_Parvej_Assignment_DDOOCP\Mind_Game\Mind_Game\GAME_database.mdf;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select * from player", con);
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("player Id is Empty");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("player Id is Empty");
                return;
            }
            con.Open();
            SqlCommand com = new SqlCommand("select * from player where id = '" + textBox1.Text + "'", con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
            }
            else
            {
                MessageBox.Show("Plese Enter Valid ID");
            }
            con.Close();
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("name is Empty");
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("email is Empty");
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("password is Empty");
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("player Id is Empty");
                return;
            }


            con.Open();
            SqlCommand com = new SqlCommand("update player set name='" + textBox2.Text + "', password = '" + textBox3.Text + "', email ='" + textBox4.Text + "' where id= '" + textBox1.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("player Updated");
            textBox3.Clear();
            textBox2.Clear();
            FormClosed += (o, a) => new player().ShowDialog();
            Hide();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Name is Empty");
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("email is Empty");
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("password is Empty");
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("player Id is Empty");
                return;
            }


            con.Open();
            SqlCommand com = new SqlCommand("delete from player where id='" + textBox1.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("player deleted");
            textBox3.Clear();
            textBox2.Clear();
            FormClosed += (o, a) => new player().ShowDialog();
            Hide();
            Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
