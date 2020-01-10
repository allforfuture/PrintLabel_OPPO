using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintLabel_OPPO
{
    public partial class Main : Form
    {
        public static Main main;
        public Main()
        {
            InitializeComponent();
            Text += " " + Application.ProductVersion.ToString();
            RefreshTxt();
            RefreshImage();
            main = this;
        }
        
        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConfigSettingForm().ShowDialog();
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

        public void RefreshTxt()
        {
            txtUPN.Text = Config.GetAppSetting("UPN");
            txtDATE.Text = Config.GetAppSetting("DATE");
            txtMSD.Text = Config.GetAppSetting("MSD");
            txtDC.Text = Config.GetAppSetting("DC");
            txtLN.Text = Config.GetAppSetting("LN");
            txtQC.Text = Config.GetAppSetting("QC");
            txtQTY.Text = Config.GetAppSetting("QTY");
            txtHard.Text = Config.GetAppSetting("Hard");
            txtSoft.Text = Config.GetAppSetting("Soft");
            txtDescribe.Text = Config.GetAppSetting("Describe");

            txtVendor.Text = Config.GetAppSetting("Vendor");
            txtProduct.Text = Config.GetAppSetting("Product");
            txtQTY2.Text = Config.GetAppSetting("QTY2");
            txtDescribe2.Text = Config.GetAppSetting("Describe2");
        }

        public void RefreshImage()
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDocument2.PrinterSettings = printDialog.PrinterSettings;
                printDocument1.Print();
                printDocument2.Print();
            }
        }
    }
}
