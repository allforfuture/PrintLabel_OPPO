using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace PrintLabel_OPPO
{
    public partial class ConfigSetting : UserControl
    {
        public ConfigSetting()
        {
            InitializeComponent();
            txtUPN.Text = Config.GetAppSetting("UPN");//ConfigurationManager.AppSettings["UPN"];
            txtDATE.Text = Config.GetAppSetting("DATE");//ConfigurationManager.AppSettings["DATE"];
            txtMSD.Text = Config.GetAppSetting("MSD");// ConfigurationManager.AppSettings["MSD"];
            txtDC.Text = Config.GetAppSetting("DC");// ConfigurationManager.AppSettings["DC"];
            txtLN.Text = Config.GetAppSetting("LN");//ConfigurationManager.AppSettings["LN"];
            txtQC.Text = Config.GetAppSetting("QC");// ConfigurationManager.AppSettings["QC"];
            txtQTY.Text = Config.GetAppSetting("QTY");// ConfigurationManager.AppSettings["QTY"];
            txtHard.Text = Config.GetAppSetting("Hard");//ConfigurationManager.AppSettings["Hard"];
            txtSoft.Text = Config.GetAppSetting("Soft");//ConfigurationManager.AppSettings["Soft"];
            txtDescribe.Text = Config.GetAppSetting("Describe");//ConfigurationManager.AppSettings["Describe"];

            txtVendor.Text = Config.GetAppSetting("Vendor");//ConfigurationManager.AppSettings["Vendor"];
            txtProduct.Text = Config.GetAppSetting("Product");// ConfigurationManager.AppSettings["Product"];
            txtQTY2.Text = Config.GetAppSetting("QTY2");// ConfigurationManager.AppSettings["QTY2"];
            txtDescribe2.Text = Config.GetAppSetting("Describe2");// ConfigurationManager.AppSettings["Describe2"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region UPN转化Barcode.CODE_128的验证
            if (txtUPN.Text == "")
            {
                MessageBox.Show("UPN不能为空", "UPN输入：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (char s in txtUPN.Text)
            {
                int i = Convert.ToInt32(s); //把字符类型转换成数值类型，如：a——>97；输出是整型隐式转换为字符串型输出；
                bool isASCII = i <= 127 ? true : false;
                if (!isASCII)
                {
                    MessageBox.Show("UPN不能转化为Barcode.CODE_128,请输入ASCII字符","UPN输入：",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            #endregion
            Config.SetAppSetting("UPN", txtUPN.Text);
            Config.SetAppSetting("DATE", txtDATE.Text);
            Config.SetAppSetting("MSD", txtMSD.Text);
            Config.SetAppSetting("DC", txtDC.Text);
            Config.SetAppSetting("LN", txtLN.Text);
            Config.SetAppSetting("QC", txtQC.Text);
            Config.SetAppSetting("QTY", txtQTY.Text);
            Config.SetAppSetting("Hard", txtHard.Text);
            Config.SetAppSetting("Soft", txtSoft.Text);
            Config.SetAppSetting("Describe", txtDescribe.Text);

            Config.SetAppSetting("Vendor", txtVendor.Text);
            Config.SetAppSetting("Product", txtProduct.Text);
            Config.SetAppSetting("QTY2", txtQTY2.Text);
            Config.SetAppSetting("Describe2", txtDescribe2.Text);
            Main.main.RefreshTxt();
            Main.main.RefreshImage();
            MessageBox.Show("修改成功");
        }
    }

    //窗口窗口话
    public partial class ConfigSettingForm : Form
    {
        public ConfigSettingForm()
        {
            Size = new Size(540, 480);
            Text = "设置";
            //ConfigSetting configSetting = new ConfigSetting();
            //configSetting.Dock = DockStyle.Fill;
            Controls.Add(new ConfigSetting());
        }
    }

    class Config
    {
        static Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        private Config()
        {

        }

        static public void AddAppSetting(string key, string value)
        {
            _config.AppSettings.Settings.Add(key, value);
            _config.Save();
        }

        static public void SetAppSetting(string key, string value)
        {
            _config.AppSettings.Settings.Remove(key);
            _config.AppSettings.Settings.Add(key, value);

            _config.Save();
        }

        static public string GetAppSetting(string key)
        {
            return _config.AppSettings.Settings[key].Value;
        }

        static public void DelAppSetting(string key)
        {
            _config.AppSettings.Settings.Remove(key);
            _config.Save();
        }

    }
}
