using GameMafia.Core.Data;
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

        /*private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {
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
            guna2TextBox1.Text = "";
        }*/

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {


            //

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if ((guna2TextBox1.Text).Length > 0)
            {
                listBox1.ForeColor = Color.White;
                listBox1.Items.Add(guna2TextBox1.Text);
                guna2TextBox1.Text = "";
            }

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {
            var db = new MafiaGameDb();

            var user12 = db.Users.FirstOrDefault(user => user.UserId == player.UserId);
            if (user12 != null)
            {
                guna2HtmlLabel1.Text = $"{user12.FullName} , {user12.UserName}";
                guna2HtmlLabel2.Text = player.RoleName;
            }
        }
    }
}
