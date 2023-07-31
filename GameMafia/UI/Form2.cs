using GameMafia.Core.Data;
using GameMafia.Core.Models;
using GameMafia.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GameMafia.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        } 

        //
        public User user = new User();
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            FullNameLbl.Text = "";
            UsernameLbl.Text = "";
            PasswordLbl.Text = "";
            if (CheckRegister.CheckFullName(FullNameTxt.Text))
            {
                user.FullName = FullNameTxt.Text;
                if (CheckRegister.CheckUserName(UserNameTxt.Text))
                {
                    user.UserName = UserNameTxt.Text;
                    if (CheckRegister.PasswordChecked(guna2TextBox2.Text))
                    {
                        user.Password = guna2TextBox2.Text;

                        var db = new MafiaGameDb();
                        if (db.Users.FirstOrDefault(user => user.UserName == UserNameTxt.Text) == null)
                        {/*
                            User user1 = new User()
                            {
                                FullName = FullNameTxt.Text,
                                UserName = UserNameTxt.Text,
                                Password = guna2TextBox2.Text,
                                CreateDate = DateTime.Now,
                                Security = 0,
                                Summ = 0,
                            };*/
                            
                           
                            db.Users.Add(user);
                            db.SaveChanges();
                            Main main = new Main(user);
                            main.Show();
                            this.Hide();


                        }
                        else
                        {
                            UsernameLbl.Text = "Bunday username band !!!";
                        }
                    }
                    else
                    {
                        PasswordLbl.Text = "Password to`g`ri kiritilmagan ";
                    }

                }
                else
                {
                    UsernameLbl.Text = "UserName xato kiritilgan";
                }

            }
            else
            {
                FullNameLbl.Text = "Fullname to`gri kiritilmagan";
            }
        }
    }
}
