using GameMafia.Services;
using GameMafia.UI;

namespace GameMafia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserNameTxt_Enter(object sender, EventArgs e)
        {

        }

        private void UserNameTxt_Leave(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UsernameLbl.Text = string.Empty;
            PasvordLbl.Text = string.Empty;
            if (CheckLogin.CheckUsername(this.UserNameTxt.Text))
            {
                if (CheckLogin.CheckPassword(this.PasswordTxt.Text, this.UserNameTxt.Text))
                {
                    var user = CheckLogin.GetUser(this.UserNameTxt.Text);
                    if (user != null)
                    {
                        Main main = new Main(user);
                        main.Show();
                        this.Hide();

                    }

                }
                else
                {
                    PasvordLbl.Text = "Password xato kiritilgan !";
                }

            }
            else
            {
                UsernameLbl.Text = "UserName xato kiritilgan !";
            }
        }
    }
}