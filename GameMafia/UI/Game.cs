using GameMafia.Core.Data;
using GameMafia.Core.Enum;
using GameMafia.Core.MafiaModels.Models;
using GameMafia.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Message = GameMafia.Core.Models.Message;
using Microsoft.EntityFrameworkCore;

namespace GameMafia.UI
{
    public partial class Game : Form
    {
        public static int i;
        public List<Panel> ls = new List<Panel>();
        public Player player;
        public Game(Player player1)
        {
            player = player1;
            InitializeComponent();
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {/*
            i++;
            Panel pan = new Panel();
            pan.Name = "panel" + i;
            ls.Add(pan);
            Label l = new Label();
            l.Text = guna2TextBox1.Text;
            l.ForeColor = Color.White;
            pan.Location = new Point(300, i * 100);
            pan.Size = new Size(300, 90);  // just an example
            pan.Controls.Add(l);
            this.Controls.Add(pan);
            guna2TextBox1.Text = "";*/
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {


            //

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if ((guna2TextBox1.Text).Length > 0)
            {
                var mess = new Message()
                {
                    PlayerId = player.PlayerId,
                    MessagePlayer = guna2TextBox1.Text,
                    DTime = DateTimeOffset.UtcNow,

                };
                var db = new MafiaGameDb();
                db.Messages.Add(mess);
                db.SaveChanges();
                /*Game game = new Game(player);
                game.Show();
                this.Close();*/

                //listBox1.ForeColor = Color.White;
                //listBox1.Items.Add(guna2TextBox1.Text);
                //guna2TextBox1.Text = "";
            }

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Game_Load(object sender, EventArgs e)
        {
            var db = new MafiaGameDb();

            var user12 = db.Users.FirstOrDefault(user => user.UserId == player.UserId);
            if (user12 != null)
            {
                guna2HtmlLabel1.Text = $"{user12.FullName} , {user12.UserName}";
                guna2HtmlLabel2.Text = db.Roles.FirstOrDefault(role => role.RoleId == player.RoleId).Name;
            }
            listBox1.Items.Clear();

            while (true)
            {

                foreach (var user in await db.Messages.ToListAsync())
                {
                    listBox1.Items.Add(user.ToString());
                }
                Thread.Sleep(1000);

            }

            if (db.Player.Count(p => db.Roles.FirstOrDefault(r => r.RoleId == p.RoleId).Type != RoleType.Black) > db.Player.Count(t => db.Roles.FirstOrDefault(r => r.RoleId == t.RoleId).Type == RoleType.Black))
            {

                db.Add(new Core.Models.Message()
                {
                    MessagePlayer = "Tun",

                });

            }



        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var db = new MafiaGameDb();
            var user12 = db.Users.FirstOrDefault(user => user.UserId == player.UserId);
            if (user12 != null)
            {
                Main main = new Main(user12);
                main.Show();
                this.Close();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Game main = new Game(player);
            main.Show();    
            this.Close();
        }
    }
}
