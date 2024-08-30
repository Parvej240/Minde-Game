using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mind_Game
{
    public partial class Game : Form
    {
        List<Button> lst;
        System.Timers.Timer t;
        int h, m, s;
        //int scroeCounter = 0;
        public Game()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GAME_database.mdf;Integrated Security=True");

        private void Game_Load(object sender, EventArgs e)
        {
            lst = new List<Button>();
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += onTimeEvent;
        }

        private void onTimeEvent(object sender, ElapsedEventArgs e)
        {
           Invoke(new Action(() =>
           {
               s += 1;
               if (s == 60)
               {
                   s = 0;
                   m += 1;
               }
               if (m == 60)
               {
                   m = 0;
                   h += 1;
               }
               txtResult.Text= string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
           }));
        }

        private void cardModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            card cd =new card();
            cd.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playerUpdateAndDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player player = new player();
            player.Show();
            this.Hide();
        }

        private void backToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void backToRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }

        private void A_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.Enabled = false;

            lst.Add(newButton);

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst.Count > 1)
                {


                    if (lst[0].Tag == lst[1].Tag)
                    {
                        lst[0].Visible = false;
                        lst[1].Visible = false;
                        lst = new List<Button>();
                        scroeCounter.Text =Convert .ToString(Convert.ToInt32 (scroeCounter.Text) + 1);
                    }
                }

                if (lst.Count == 2)
                {
                    for (int j = 0; j < lst.Count; j++)
                    {
                        lst[j].Enabled = true;
                    }
                    lst = new List<Button>();
                }

            }
        }

        private void B_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.Enabled = false;

            lst.Add(newButton);

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst.Count > 1)
                {


                    if (lst[0].Tag == lst[1].Tag)
                    {
                        lst[0].Visible = false;
                        lst[1].Visible = false;
                        lst = new List<Button>();
                        scroeCounter.Text = Convert.ToString(Convert.ToInt32(scroeCounter.Text) + 1);
                    }
                }

                if (lst.Count == 2)
                {
                    for (int j = 0; j < lst.Count; j++)
                    {
                        lst[j].Enabled = true;
                    }
                    lst = new List<Button>();
                }

            }
        }

        private void C_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.Enabled = false;

            lst.Add(newButton);

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst.Count > 1)
                {


                    if (lst[0].Tag == lst[1].Tag)
                    {
                        lst[0].Visible = false;
                        lst[1].Visible = false;
                        lst = new List<Button>();
                        scroeCounter.Text = Convert.ToString(Convert.ToInt32(scroeCounter.Text) + 1);
                    }
                }

                if (lst.Count == 2)
                {
                    for (int j = 0; j < lst.Count; j++)
                    {
                        lst[j].Enabled = true;
                    }
                    lst = new List<Button>();
                }

            }
        }

        private void D_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.Enabled = false;

            lst.Add(newButton);

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst.Count > 1)
                {


                    if (lst[0].Tag == lst[1].Tag)
                    {
                        lst[0].Visible = false;
                        lst[1].Visible = false;
                        lst = new List<Button>();
                        scroeCounter.Text = Convert.ToString(Convert.ToInt32(scroeCounter.Text) + 1);
                    }
                }

                if (lst.Count == 2)
                {
                    for (int j = 0; j < lst.Count; j++)
                    {
                        lst[j].Enabled = true;
                    }
                    lst = new List<Button>();
                }

            }
        }

        private void E_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.Enabled = false;

            lst.Add(newButton);

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst.Count > 1)
                {


                    if (lst[0].Tag == lst[1].Tag)
                    {
                        lst[0].Visible = false;
                        lst[1].Visible = false;
                        lst = new List<Button>();
                        scroeCounter.Text = Convert.ToString(Convert.ToInt32(scroeCounter.Text) + 1);
                    }
                }

                if (lst.Count == 2)
                {
                    for (int j = 0; j < lst.Count; j++)
                    {
                        lst[j].Enabled = true;
                    }
                    lst = new List<Button>();
                }

            }
        }

        private void F_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.Enabled = false;

            lst.Add(newButton);

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst.Count > 1)
                {


                    if (lst[0].Tag == lst[1].Tag)
                    {
                        lst[0].Visible = false;
                        lst[1].Visible = false;
                        lst = new List<Button>();
                        scroeCounter.Text = Convert.ToString(Convert.ToInt32(scroeCounter.Text) + 1);
                    }
                }

                if (lst.Count == 2)
                {
                    for (int j = 0; j < lst.Count; j++)
                    {
                        lst[j].Enabled = true;
                    }
                    lst = new List<Button>();
                }

            }
        }

        private void G_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.Enabled = false;

            lst.Add(newButton);

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst.Count > 1)
                {


                    if (lst[0].Tag == lst[1].Tag)
                    {
                        lst[0].Visible = false;
                        lst[1].Visible = false;
                        lst = new List<Button>();
                        scroeCounter.Text = Convert.ToString(Convert.ToInt32(scroeCounter.Text) + 1);
                    }
                }

                if (lst.Count == 2)
                {
                    for (int j = 0; j < lst.Count; j++)
                    {
                        lst[j].Enabled = true;
                    }
                    lst = new List<Button>();
                }

            }
        }

        private void H_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.Enabled = false;

            lst.Add(newButton);

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst.Count > 1)
                {


                    if (lst[0].Tag == lst[1].Tag)
                    {
                        lst[0].Visible = false;
                        lst[1].Visible = false;
                        lst = new List<Button>();
                        scroeCounter.Text = Convert.ToString(Convert.ToInt32(scroeCounter.Text) + 1);
                    }
                }

                if (lst.Count == 2)
                {
                    for (int j = 0; j < lst.Count; j++)
                    {
                        lst[j].Enabled = true;
                    }
                    lst = new List<Button>();
                }

            }
        }

        private void I_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.Enabled = false;

            lst.Add(newButton);

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst.Count > 1)
                {


                    if (lst[0].Tag == lst[1].Tag)
                    {
                        lst[0].Visible = false;
                        lst[1].Visible = false;
                        lst = new List<Button>();
                        scroeCounter.Text = Convert.ToString(Convert.ToInt32(scroeCounter.Text) + 1);
                    }
                }

                if (lst.Count == 2)
                {
                    for (int j = 0; j < lst.Count; j++)
                    {
                        lst[j].Enabled = true;
                    }
                    lst = new List<Button>();
                }

            }
        }

        private void J_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.Enabled = false;

            lst.Add(newButton);

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst.Count > 1)
                {


                    if (lst[0].Tag == lst[1].Tag)
                    {
                        lst[0].Visible = false;
                        lst[1].Visible = false;
                        lst = new List<Button>();
                        scroeCounter.Text = Convert.ToString(Convert.ToInt32(scroeCounter.Text) + 1);
                    }
                }

                if (lst.Count == 2)
                {
                    for (int j = 0; j < lst.Count; j++)
                    {
                        lst[j].Enabled = true;
                    }
                    lst = new List<Button>();
                }

            }
        }

        private void K_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.Enabled = false;

            lst.Add(newButton);

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst.Count > 1)
                {


                    if (lst[0].Tag == lst[1].Tag)
                    {
                        lst[0].Visible = false;
                        lst[1].Visible = false;
                        lst = new List<Button>();
                        scroeCounter.Text = Convert.ToString(Convert.ToInt32(scroeCounter.Text) + 1);
                    }
                }

                if (lst.Count == 2)
                {
                    for (int j = 0; j < lst.Count; j++)
                    {
                        lst[j].Enabled = true;
                    }
                    lst = new List<Button>();
                }

            }
        }
        

        private void btnstart_Click_1(object sender, EventArgs e)
        {
            t.Start();
        }

        private void btnstop_Click_1(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void L_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.Enabled = false;

            lst.Add(newButton);

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst.Count > 1)
                {


                    if (lst[0].Tag == lst[1].Tag)
                    {
                        lst[0].Visible = false;
                        lst[1].Visible = false;
                        lst = new List<Button>();
                        scroeCounter.Text = Convert.ToString(Convert.ToInt32(scroeCounter.Text) + 1);
                    }
                }

                if (lst.Count == 2)
                {
                    for (int j = 0; j < lst.Count; j++)
                    {
                        lst[j].Enabled = true;
                    }
                    lst = new List<Button>();
                }

            }
        }

        private void M_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.Enabled = false;

            lst.Add(newButton);

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst.Count > 1)
                {


                    if (lst[0].Tag == lst[1].Tag)
                    {
                        lst[0].Visible = false;
                        lst[1].Visible = false;
                        lst = new List<Button>();
                        scroeCounter.Text = Convert.ToString(Convert.ToInt32(scroeCounter.Text) + 1);
                    }
                }

                if (lst.Count == 2)
                {
                    for (int j = 0; j < lst.Count; j++)
                    {
                        lst[j].Enabled = true;
                    }
                    lst = new List<Button>();
                }

            }
        }
    }
}
