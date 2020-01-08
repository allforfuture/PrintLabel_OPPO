using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace PrintLabel_OPPO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Text += " " + Application.ProductVersion.ToString();
            txtUPN.Text = ConfigurationManager.AppSettings["UPN"];
            txtDATE.Text = ConfigurationManager.AppSettings["DATE"];
            txtMSD.Text = ConfigurationManager.AppSettings["MSD"];
            txtDC.Text = ConfigurationManager.AppSettings["DC"];
            txtLN.Text = ConfigurationManager.AppSettings["LN"];
            txtQC.Text = ConfigurationManager.AppSettings["QC"];
            txtQTY.Text = ConfigurationManager.AppSettings["QTY"];
            txtHard.Text = ConfigurationManager.AppSettings["Hard"];
            txtSoft.Text = ConfigurationManager.AppSettings["Soft"];
            txtDescribe.Text = ConfigurationManager.AppSettings["Describe"];

            txtVendor.Text = ConfigurationManager.AppSettings["Vendor"];
            txtProduct.Text = ConfigurationManager.AppSettings["Product"];
            txtQTY2.Text = ConfigurationManager.AppSettings["QTY2"];
            txtDescribe2.Text = ConfigurationManager.AppSettings["Describe2"];
            RefreshImage();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //string key = "UPN";
            //string value = "OK";
            //_config.AppSettings.Settings.Remove(key);
            //_config.AppSettings.Settings.Add(key, value);
            //_config.Save();
            //return;
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDocument2.PrinterSettings = printDialog.PrinterSettings;
                printDocument1.Print();
                printDocument2.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            RefreshImage();
            changeTxtBorderStyle(BorderStyle.None);
            #region 打印
            Bitmap bitmap = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            #endregion
            changeTxtBorderStyle(BorderStyle.Fixed3D);
        }

        void RefreshImage()
        {
            picUPN.Image = Barcode.BarcodeHelper.Barcode(txtUPN.Text, picUPN.Height);
            string[] strArr = {txtUPN.Text,txtDATE.Text,txtMSD.Text, txtDC.Text,
            txtLN.Text,txtQC.Text,txtQTY.Text,txtHard.Text,txtSoft.Text};
            string QRcode = string.Join("*", strArr);
            picQRcode.Image = Barcode.BarcodeHelper.QRcode(QRcode, picQRcode.Width, picQRcode.Height);
        }

        void changeTxtBorderStyle(BorderStyle borderStyle)
        {
            txtUPN.BorderStyle =
            txtDATE.BorderStyle =
            txtMSD.BorderStyle =
            txtDC.BorderStyle =
            txtLN.BorderStyle =
            txtQC.BorderStyle =
            txtQTY.BorderStyle =
            txtHard.BorderStyle =
            txtSoft.BorderStyle =
            txtDescribe.BorderStyle = borderStyle;
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(pnl2.Width, pnl2.Height);
            pnl2.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
        }
    }
}
