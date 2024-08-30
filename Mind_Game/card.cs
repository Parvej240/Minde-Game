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
    public partial class card : Form
    {
        public card()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GAME_database.mdf;Integrated Security=True");


        private void button6_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void card_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("insert into Card(name) values('" + textBox1.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Card Is Created");

            FormClosed += (o, a) => new card().ShowDialog();
            Hide();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select * from card", con);
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Id is Empty");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Note Id is Empty");
                return;
            }
            con.Open();
            SqlCommand com = new SqlCommand("select * from Card where id = '" + textBox2.Text + "'", con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                textBox3.Text = dr[1].ToString();



            }
            else
            {
                MessageBox.Show("Plese Enter Valid ID");
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Title is Empty");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Card Id is Empty");
                return;
            }


            con.Open();
            SqlCommand com = new SqlCommand("update card set name='" + textBox3.Text + "' where id= '" + textBox2.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("card Updated");
            textBox3.Clear();
            textBox2.Clear();
            FormClosed += (o, a) => new card().ShowDialog();
            Hide();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Title is Empty");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Card Id is Empty");
                return;
            }


            con.Open();
            SqlCommand com = new SqlCommand("delete from card where id='" + textBox2.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("card deleted");
            textBox3.Clear();
            textBox2.Clear();
            FormClosed += (o, a) => new card().ShowDialog();
            Hide();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
