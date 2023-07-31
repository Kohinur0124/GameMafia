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
    public partial class Main : Form
    {
        public bool t = true;
        public User user { get; set; }
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

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           /* Profile profile = new Profile(user);
            profile.Show();
            this.Close();*/
        }
    }
}
