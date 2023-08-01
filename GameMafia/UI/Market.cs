using GameMafia.Core.Data;
using GameMafia.Core.Models;
using Microsoft.EntityFrameworkCore.Update;
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
    public partial class Market : Form
    {
        public User user1 = new User();
        public Market(User user)
        {
            user1 = user;
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            Main main = new Main(user1);
            main.Show();
            this.Close();

        }

        private void toMarket_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel2.Visible = false;
            guna2HtmlLabel3.Visible = false;
            if (user1.Summ > 100)
            {
                user1.Summ -= 100;
                user1.Security++;
                var db = new MafiaGameDb();
                db.Users.Update(user1);
                db.SaveChanges();
                guna2HtmlLabel3.Visible=true;

            }
            else
            {
                guna2HtmlLabel2.Visible = true;
            }
        }
    }
}
