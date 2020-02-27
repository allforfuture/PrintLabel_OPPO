﻿using System;
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
        string PC_Nnumber
        {
            get { return Config.GetAppSetting("PC_Nnumber"); }
        }

        public Main()
        {
            InitializeComponent();
            Text += " " + Application.ProductVersion.ToString();
            RefreshTxt();
            RefreshImage();
            main = this;
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

        private void txtSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSN.Text != "" && e.KeyCode == Keys.Return)
            {
                string[] info = txtSN.Text.Split('_');
                if (info.Length != 5)
                {
                    MessageBox.Show("格式异常", "SN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //N_4878595_0226_T_0001
                string product = info[1];
                string date = info[2];
                string model = info[3];
                string num = info[4];

                string year = "202" + date.Substring(0, 1); ;
                string month = date.Substring(1, 1);
                switch (date.Substring(1, 1))
                {

                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        month = "0" + month;
                        break;
                    case "A":
                        month = "10";
                        break;
                    case "B":
                        month = "11";
                        break;
                    case "C":
                        month = "12";
                        break;
                }
                string day = date.Substring(2, 2);

                DateTime time = Convert.ToDateTime(year + "-" + month + "-" + day);

                #region 控件赋值
                if (txtVendor.Text == "")
                {
                    MessageBox.Show("供应商代码不能为空", "供应商代码", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtUPN.Text = product + "-" + txtVendor.Text + PC_Nnumber + "-" + "2" + date + "-" + model + num;
                txtDATE.Text = time.ToString("yyyy-MM-dd");
                txtDC.Text = year.Substring(2, 2) + GetWeekOfYear(time);
                txtLN.Text = time.ToString("yyyyMMdd");

                txtProduct.Text = product;
                #endregion

                RefreshImage();
            }

            /// <summary>
            /// 获取一年中的周
            /// </summary>
            /// <param name="dt">日期</param>
            /// <returns></returns>
            int GetWeekOfYear(DateTime dt)
            {
                System.Globalization.GregorianCalendar gc = new System.Globalization.GregorianCalendar();
                int weekOfYear = gc.GetWeekOfYear(dt, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Sunday);

                return weekOfYear;
            }
        }
    }
}
