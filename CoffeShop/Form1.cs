using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoffeShop
{
    public partial class frmLogin : Form
    {
        string uid;
        string pwd;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {

            if (textUserName.Text=="admin")
            {
                adminLogin();
            }else
            {
                userLogin();
            }

            if ((uid == textUserName.Text.Trim()) && (pwd == textPassword.Text.Trim()))
            {
                if (textUserName.Text == "admin")
                {
                    frmAdmin adminFrm = new frmAdmin();
                    adminFrm.Name = "Admin";
                    adminFrm.Text = "Administrator";
                    if (Application.OpenForms["Admins"] == null)
                    {

                        adminFrm.Show();
                        this.Hide();

                    }
                } else
                {
                    frmUser userFrm = new frmUser();
                    userFrm.Name = "User";
                    userFrm.Text = "Coffe Shop";
                    if (Application.OpenForms["Admins"] == null)
                    {

                        userFrm.Show();
                        this.Hide();

                    }
                }
            } else
            {
                MessageBox.Show("Kullanici adi veya Parola hatali", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void adminLogin()
        {
            XDocument xDoc = XDocument.Load(@"..\..\admin.xml");
          

            XElement rootElement = xDoc.Root;
            
            foreach (XElement users in rootElement.Elements())
            {
                uid = users.Element("username").Value;
                pwd = users.Element("password").Value;
            }

        }

        private void userLogin()
        {
            XDocument xDoc = XDocument.Load(@"..\..\user.xml");


            XElement rootElement = xDoc.Root;

            foreach (XElement users in rootElement.Elements())
            {
                if (textUserName.Text == users.Element("username").Value)
                {
                    uid = users.Element("username").Value;
                    pwd = users.Element("password").Value;
                }
            }

        }


    }
}
