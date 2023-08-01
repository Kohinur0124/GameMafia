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
    public partial class Prof : Form
    {
        public User user1 = new User();
        public Prof(User user)
        {
            user1 = user;
            InitializeComponent();
            Fullname.Text = user1.FullName;
            Username.Text = user1.UserName;

            Summ.Text = user1.Summ.ToString();
            Ximoya.Text = user1.Security.ToString();

        }

        private void Prof_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Main main = new Main(user1);
            main.Show();
            this.Close();
        }

        private void toMarket_Click(object sender, EventArgs e)
        {
            Market market = new Market(user1);
            market.Show();
            this.Close();
        }
    }
}
