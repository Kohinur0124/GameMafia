using GameMafia.Core.Data;
using GameMafia.Core.Models;
using GameMafia.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GameMafia.UI
{
    public partial class Main : Form
    {
        public bool t = true;
        public User user { get; set; }
        public Player player = new Player();  
            
        public Main(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (t)
            {
                guna2Panel1.Width = 70;
                t = false;
                guna2Panel8.Location = new Point(200, 54);
            }
            else
            {
                guna2Panel1.Width = 300;
                t = true;

                guna2Panel8.Location = new Point(331, 54);
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            var db = new MafiaGameDb();
            if (db.Player.ToList().Count() < 1)
            {
                guna2GradientButton1.Visible = true;
                guna2ComboBox1.Visible = true;

            }
            else if (db.Player.FirstOrDefault(player => player.UserId == user.UserId) == null)
            {
                guna2GradientButton2.Visible = true;
            }
            else
            {
                guna2GradientButton1.Visible = false;
                guna2GradientButton2.Visible = false;
                guna2ComboBox1.Visible = false;

                if (db.Player.Count() == db.Player.ToList()[0].CountPlayersStart)
                {

                    var  roles = db.CountRole.Where(role => role.CountPlayer == db.Player.First().CountPlayersStart).ToList();

                    List<string> rolesString = new List<string>();
                    foreach (var role in roles)
                    {
                        for(int i=0;i<role.CountRoles; i++)
                        {
                            rolesString.Add(db.Roles.FirstOrDefault(p=>p.RoleId == role.RoleId).Name);
                        }
                    }
                    rolesString.Shuffle<string>();
                    for (int i=0;i<rolesString.Count;i++)
                    {
                        var player1 = db.Player.FirstOrDefault(p => p.PlayerId == i + 1);
                        if (player1 != null)
                        {
                            player1.RoleName = rolesString[i];
                            db.Player.Update(player1);
                            db.SaveChanges();
                        }
                    }
                    

                    guna2HtmlLabel1.Visible = true;
                    guna2Button1.Enabled = true;

                }




            }

            /* while (true)
             {
                 for(int i = 0; i < 100; i++)
                 {

                 }

                 if (db.Player.Count() == db.Player.ToList()[0].CountPlayersStart)
                 {
                     //timer1.Stop();
                     guna2GradientButton1.Visible = false;
                     guna2GradientButton2.Visible = false;
                     guna2HtmlLabel1.Visible = true;
                 }

             }*/
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var db = new MafiaGameDb();
            player = db.Player.FirstOrDefault(player => player.UserId == user.UserId);
            Game game = new Game(player);
            game.Show();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Prof prof = new Prof(user);
            prof.Show();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Market market = new Market(user);
            market.Show();
            this.Close();
        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {
            //timer1.Start();

            {

                /*if (db.Player.ToList() == null)
                {
                    guna2Button1.Visible = true;

                }
                else if (db.Player.FirstOrDefault(player => player.UserId == user.UserId) == null)
                {
                    guna2Button2.Visible = false;
                }
                else
                {
                    guna2Button1.Visible = false;
                    guna2Button2.Visible = false;

                    if (db.Player.Count() == db.Player.ToList()[0].CountPlayersStart)
                    {
                        guna2HtmlLabel1.Visible = true;
                    }


                */
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Main main = new Main(user);
            main.Show();
            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            var db = new MafiaGameDb();
            if (guna2ComboBox1.SelectedIndex >= 0)
            {
                player.UserId = user.UserId;
                player.CountPlayersStart = Convert.ToInt32(player.CountPlayersStart);
                db.Player.Add(player);
                db.SaveChanges();
                guna2ComboBox1.Visible = false;

                guna2GradientButton1.Text = "Siz o`yinga qo`shildingiz !";
                guna2GradientButton1.Enabled = false;
            }

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            var db = new MafiaGameDb();
            player.UserId = user.UserId;
            player.CountPlayersStart = db.Player.First().CountPlayersStart;
            db.Player.Add(player);
            db.SaveChanges();
            guna2GradientButton2.Text = "Siz o`yinga qo`shildingiz !";
            guna2GradientButton2.Enabled = false;

        }
    }
}
