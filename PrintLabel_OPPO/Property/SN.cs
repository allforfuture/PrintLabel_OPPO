using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace PrintLabel_OPPO.Property
{
    class SN
    {
        SN(string sn)
        {
            string[] info = sn.Split('_');
            if (info.Length != 5)
            {
                MessageBox.Show("格式异常", "SN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string product = info[1];
            string date = info[2];
            string model = info[3];
            string num = info[4];

            //DateTime time = Convert.ToDateTime("200227");
            //Main.txtDATE.Text = "@";
        }
    }
}
