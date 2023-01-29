using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoffeShop
{
    public partial class frmUser : Form
    {
        List<string> prices = new List<string>();
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            int adet, fiyat, tutar;
            string strPrice;
            int toplamTutar = 0;
            
            richTextOredrs.SelectionFont = new Font(richTextOredrs.Font, FontStyle.Underline| FontStyle.Bold);
            richTextOredrs.AppendText("Ürün Adı \t\t Adet \t Fiyat \t Tutar");
            richTextOredrs.AppendText("\n\n");
            richTextOredrs.SelectionFont = new Font(richTextOredrs.Font, FontStyle.Regular);
            if (numLatte.Value > 0)
            {
                adet = (int)numLatte.Value;
                // menu.TryGetValue("Cafe Latte", out strPrice);
                strPrice = prices[0];

                fiyat = Convert.ToInt32(strPrice);
                tutar = adet * fiyat;
                richTextOredrs.AppendText("\nCafe Latte \t\t" + adet + "\t " + fiyat + "\t" + tutar);
                toplamTutar += tutar;
            }
            if (numAmericano.Value > 0)
            {
                adet = (int)numAmericano.Value;

                strPrice = prices[1];

                fiyat = Convert.ToInt32(strPrice);
                tutar = adet * fiyat;
                richTextOredrs.AppendText("\nAmericano \t\t" + adet + "\t " + fiyat + "\t" + tutar);
                toplamTutar += tutar;
            }
            if (numEspresso.Value > 0)
            {
                adet = (int)numEspresso.Value;

                strPrice = prices[2];

                fiyat = Convert.ToInt32(strPrice);
                tutar = adet * fiyat;
                richTextOredrs.AppendText("\nEspresso \t\t" + adet + "\t " + fiyat + "\t" + tutar);
                toplamTutar += tutar;
            }

            if (numFiltre.Value > 0)
            {
                adet = (int)numFiltre.Value;

                strPrice = prices[3];

                fiyat = Convert.ToInt32(strPrice);
                tutar = adet * fiyat;
                richTextOredrs.AppendText("\nFiltre Kahve \t\t" + adet + "\t " + fiyat + "\t" + tutar);
                toplamTutar += tutar;
            }
            richTextOredrs.SelectionFont = new Font(richTextOredrs.Font, FontStyle.Bold);
            richTextOredrs.AppendText("\n\n\n\n\t\t\t   Toplam   : " + toplamTutar);

        }

        private void addCaffe(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            int total = (int)(numLatte.Value + numAmericano.Value + numEspresso.Value + numFiltre.Value);
            txtToplam.Text = total.ToString();
        }

        private void getPrices()
        {
            XDocument xDoc = XDocument.Load(@"..\..\urunler.xml");

            XElement rootElement = xDoc.Root;

            String price = "", ID;


            foreach (XElement urunler in rootElement.Elements())

            {
                price = urunler.Element("fiyati").Value;
                prices.Add(price);
                
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            getPrices();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            numLatte.Value = 0;
            numFiltre.Value = 0;
            numAmericano.Value = 0;
            numEspresso.Value = 0;
            richTextOredrs.Clear();
        }

        private void PrintOrders(object sender, EventArgs e)
        {

            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 600, 500);
            printDocument1.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            DialogResult result = printPreviewDialog1.ShowDialog();
            if (result == DialogResult.OK)
                printDocument1.Print();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextOredrs.Text, new Font(richTextOredrs.Font.ToString(), richTextOredrs.Font.Size), System.Drawing.Brushes.Red, 66, 50);
        }
    }
}
