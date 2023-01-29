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
    public partial class frmAdmin : Form
    {
        string selId;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            tabPage.Left = 0;
            tabPage.Top = 0;
            tabPage.Width = this.Width;
            tabPage.Height = this.Height;
            listUser();
            listCoffe();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

       private void listCoffe()
        {
            XDocument xDoc = XDocument.Load(@"..\..\urunler.xml");
         

            XElement rootElement = xDoc.Root;
            

            String coffe = "", price = "", ID;
            cmbUrun.Items.Clear();
            foreach (XElement urunler in rootElement.Elements())

            {

                ID = urunler.Attribute("id").Value;
                coffe = urunler.Element("urunadi").Value;
                price = urunler.Element("fiyati").Value;
             
                cmbUrun.Items.Add(ID + " " + coffe + " " + price);

            }
        }

        private void listUser()
        {
            lstUsers.Items.Clear();
            XDocument xDoc = XDocument.Load(@"..\..\user.xml");


            XElement rootElement = xDoc.Root;


            String username = "", pwd = "", ID;
           
            foreach (XElement users in rootElement.Elements())

            {

                ID = users.Attribute("id").Value;
                username = users.Element("username").Value;
                pwd = users.Element("password").Value;

                lstUsers.Items.Add(ID + " " + username + " " + pwd);

            }

          
        }

        private void tabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            listCoffe();
            listUser();


        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            selId = cmbUrun.SelectedItem.ToString().Split(' ')[0];
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(@"..\..\urunler.xml");
        
            XElement rootElement = xDoc.Root;
          

            foreach (XElement urunler in rootElement.Elements())
            {

                if (urunler.Attribute("id").Value == selId)
                {
                    urunler.Element("fiyati").Value = txtFiyat.Text;
                    break;
                }
            }
            xDoc.Save(@"..\..\urunler.xml");
           
            listCoffe();
            txtFiyat.Text = "";
            cmbUrun.Text = "";
        }

        private bool isExist()
        {
            bool flag = false;
            XDocument xDoc = XDocument.Load(@"..\..\user.xml");
            XElement rootElement = xDoc.Root;
           
            foreach (XElement users in rootElement.Elements())
            {

                if (txtUserName.Text == users.Element("username").Value)
                    flag = true;
                
            }
            return flag;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (!isExist())
            {
                int id = getUserId();

                
                XDocument xDoc = XDocument.Load(@"..\..\user.xml");

                XElement rootElement = xDoc.Root;

                XElement newElement = new XElement("user");

                XAttribute idAttribute = new XAttribute("id", id.ToString());

                XElement user = new XElement("username", txtUserName.Text);
                XElement pwd = new XElement("password", textPasword.Text);


                newElement.Add(idAttribute, user, pwd);

                rootElement.Add(newElement);

                xDoc.Save(@"..\..\user.xml");
                //Yaptığımız işlemi kayıt ediyoruz.
                
                textPasword.Clear();
                txtUserName.Clear();




            }
            else
            {
                MessageBox.Show("Kullanici adı daha önce kullanılmış", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listUser();
        }

        private int getUserId()
        {
            XDocument xDoc = XDocument.Load(@"..\..\user.xml");

            XElement rootElement = xDoc.Root;
            return  rootElement.Elements().ToArray().Length;
            
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(@"..\..\user.xml");
            //Xml dosyamıza erişip yükleme işlemini gerçekleştiriyoruz.

            XElement rootElement = xDoc.Root;
            //Oluşturduğumuz Root elementine XML dökümanında ki root elementini seçmesini sağlıyoruz.

            foreach (XElement kullanicilar in rootElement.Elements())
            {
                if (kullanicilar.Attribute("id").Value == selId)

                {
                    kullanicilar.Remove();

                }
            }
            xDoc.Save(@"..\..\user.xml");
            listUser();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selId = lstUsers.SelectedItem.ToString().Split(' ')[0];
        }
    }
}
