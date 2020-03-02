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
        string PC_Nnumber
        {
            get { return Config.GetAppSetting("PC_Nnumber"); }
        }

        int Expiration
        {
            get { return Convert.ToUInt16(Config.GetAppSetting("Expiration")); }
        }

        public enum Model
        {
            error = -1,
            tray = 0,
            pack = 1,
            carton = 2,
            pallet = 3
        }

        public Model model
        {
            get
            {
                switch (txtSN.Text.Split('_')[3])
                {
                    case "T":
                        return Model.tray;
                    case "P":
                        return Model.pack;
                    case "C":
                        return Model.carton;
                    case "L":
                        return Model.pallet;
                    default:
                        return Model.error;
                }
            }
        }

        public Main()
        {
            InitializeComponent();
            Text = Application.ProductName + " " + Application.ProductVersion;
            RefreshTxt();
            RefreshImage();
            if (Page.Login.Role != "Admin")
            {
                设置ToolStripMenuItem.Enabled = false;
                changeTxtEnabled(false);
            }
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
            if (Page.Login.Role != "Admin")
                changeTxtEnabled(true);

            #region 打印
            Bitmap bitmap = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            #endregion

            changeTxtBorderStyle(BorderStyle.Fixed3D);
            if (Page.Login.Role != "Admin")
                changeTxtEnabled(false);
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

        void changeTxtEnabled(bool b)
        {
            txtUPN.Enabled =
            txtDATE.Enabled =
            txtMSD.Enabled =
            txtDC.Enabled =
            txtLN.Enabled =
            txtQC.Enabled =
            txtQTY.Enabled =
            txtHard.Enabled =
            txtSoft.Enabled =
            txtDescribe.Enabled =
            txtVendor.Enabled =
            txtProduct.Enabled =
            txtQTY2.Enabled =
            txtDescribe2.Enabled = b;
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (Page.Login.Role != "Admin")
                changeTxtEnabled(true);

            Bitmap bitmap = new Bitmap(pnl2.Width, pnl2.Height);
            pnl2.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);

            if (Page.Login.Role != "Admin")
                changeTxtEnabled(false);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDocument2.PrinterSettings = printDialog.PrinterSettings;
                for (int i = 0; i < numPrint1.Value; i++)
                { printDocument1.Print(); }
                for (int i = 0; i < numPrint2.Value; i++)
                { printDocument2.Print(); }
            }
        }

        private void txtSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSN.Text != "" && e.KeyCode == Keys.Return)
            {
                txtUPN.Text = txtDATE.Text = txtDC.Text = txtLN.Text = txtQTY.Text = txtProduct.Text = txtQTY2.Text = "";
                string[] info = txtSN.Text.Split('_');
                if (info.Length != 5)
                {
                    MessageBox.Show("格式异常", "SN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //N_4878595_0226_T_0001
                string product = info[1];
                string date = info[2];
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

                #region 查询成品数量
                int printQTY = 0;
                string sqlQTY = PrintLabel_OPPO.Unit.DB.QTYsql.sql(model, txtSN.Text);
                printQTY = (int)new Unit.DB.Help().ExecuteScalar(sqlQTY);
                if (printQTY == 0)
                {
                    MessageBox.Show($"该SN在数据库中的成品数量为空", "Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region 控件赋值
                if (txtVendor.Text == "")
                {
                    MessageBox.Show("供应商代码不能为空", "供应商代码", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtUPN.Text = product + "-" + txtVendor.Text + PC_Nnumber + "-" + "2" + date + "-" + info[3] + num;
                txtDATE.Text = time.AddDays(Expiration).ToString("yyyy-MM-dd");
                txtDC.Text = year.Substring(2, 2) + GetWeekOfYear(time);
                txtLN.Text = time.ToString("yyyyMMdd");
                txtQTY.Text = txtQTY2.Text = printQTY.ToString();


                txtProduct.Text = product;
                #endregion

                RefreshImage();
            }

            /// <summary>
            /// 获取一年中的周
            /// </summary>
            /// <param name="dt">日期</param>
            /// <returns></returns>
            string GetWeekOfYear(DateTime dt)
            {
                System.Globalization.GregorianCalendar gc = new System.Globalization.GregorianCalendar();
                int weekOfYear = gc.GetWeekOfYear(dt, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
                string result = "0" + weekOfYear;
                return result.Substring(result.Length-2, 2);
            }
        }
    }
}
