namespace PrintLabel_OPPO
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrint = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnl = new System.Windows.Forms.Panel();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.txtHard = new System.Windows.Forms.TextBox();
            this.txtSoft = new System.Windows.Forms.TextBox();
            this.txtQC = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.txtMSD = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtUPN = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picQRcode = new System.Windows.Forms.PictureBox();
            this.picUPN = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUPN)).BeginInit();
            this.pnl2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "UPN条码模板";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.Controls.Add(this.txtDescribe);
            this.pnl.Controls.Add(this.txtHard);
            this.pnl.Controls.Add(this.txtSoft);
            this.pnl.Controls.Add(this.txtQC);
            this.pnl.Controls.Add(this.txtQTY);
            this.pnl.Controls.Add(this.txtMSD);
            this.pnl.Controls.Add(this.txtLN);
            this.pnl.Controls.Add(this.txtDC);
            this.pnl.Controls.Add(this.txtDate);
            this.pnl.Controls.Add(this.txtUPN);
            this.pnl.Controls.Add(this.label23);
            this.pnl.Controls.Add(this.label21);
            this.pnl.Controls.Add(this.label22);
            this.pnl.Controls.Add(this.label20);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.label6);
            this.pnl.Controls.Add(this.picQRcode);
            this.pnl.Controls.Add(this.picUPN);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.label1);
            this.pnl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnl.Location = new System.Drawing.Point(12, 51);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(346, 276);
            this.pnl.TabIndex = 5;
            // 
            // txtDescribe
            // 
            this.txtDescribe.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDescribe.Location = new System.Drawing.Point(81, 224);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(265, 52);
            this.txtDescribe.TabIndex = 57;
            this.txtDescribe.Text = "摄像头IMX278 13.0M 8.5×8.5×4.572 5P BTB 5BAD13P1D\r\nOK";
            // 
            // txtHard
            // 
            this.txtHard.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHard.Location = new System.Drawing.Point(81, 195);
            this.txtHard.Name = "txtHard";
            this.txtHard.Size = new System.Drawing.Size(62, 26);
            this.txtHard.TabIndex = 56;
            // 
            // txtSoft
            // 
            this.txtSoft.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSoft.Location = new System.Drawing.Point(243, 195);
            this.txtSoft.Name = "txtSoft";
            this.txtSoft.Size = new System.Drawing.Size(55, 26);
            this.txtSoft.TabIndex = 56;
            this.txtSoft.Text = "V1.0";
            // 
            // txtQC
            // 
            this.txtQC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQC.Location = new System.Drawing.Point(49, 166);
            this.txtQC.Name = "txtQC";
            this.txtQC.Size = new System.Drawing.Size(94, 26);
            this.txtQC.TabIndex = 54;
            this.txtQC.Text = "HG";
            // 
            // txtQTY
            // 
            this.txtQTY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQTY.Location = new System.Drawing.Point(204, 166);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(33, 26);
            this.txtQTY.TabIndex = 54;
            this.txtQTY.Text = "100";
            // 
            // txtMSD
            // 
            this.txtMSD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMSD.Location = new System.Drawing.Point(204, 79);
            this.txtMSD.Name = "txtMSD";
            this.txtMSD.Size = new System.Drawing.Size(33, 26);
            this.txtMSD.TabIndex = 54;
            this.txtMSD.Text = "1";
            // 
            // txtLN
            // 
            this.txtLN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLN.Location = new System.Drawing.Point(49, 137);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(188, 26);
            this.txtLN.TabIndex = 53;
            this.txtLN.Text = "20160330/20160331";
            // 
            // txtDC
            // 
            this.txtDC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDC.Location = new System.Drawing.Point(49, 108);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(188, 26);
            this.txtDC.TabIndex = 53;
            this.txtDC.Text = "1611/1612/1613";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDate.Location = new System.Drawing.Point(49, 79);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(94, 26);
            this.txtDate.TabIndex = 53;
            this.txtDate.Text = "2017-04-01";
            // 
            // txtUPN
            // 
            this.txtUPN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUPN.Location = new System.Drawing.Point(49, 50);
            this.txtUPN.Name = "txtUPN";
            this.txtUPN.Size = new System.Drawing.Size(294, 26);
            this.txtUPN.TabIndex = 52;
            this.txtUPN.Text = "9490168-A1391-16401-00001";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(0, 226);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 16);
            this.label23.TabIndex = 51;
            this.label23.Text = "物体描述:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(158, 197);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 16);
            this.label21.TabIndex = 51;
            this.label21.Text = "软件版本:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(0, 197);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 16);
            this.label22.TabIndex = 51;
            this.label22.Text = "硬件版本:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(158, 168);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 16);
            this.label20.TabIndex = 49;
            this.label20.Text = "QTY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(0, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Q/C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(0, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "L/N:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(0, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "D/C:";
            // 
            // picQRcode
            // 
            this.picQRcode.BackColor = System.Drawing.Color.Transparent;
            this.picQRcode.Location = new System.Drawing.Point(243, 90);
            this.picQRcode.Name = "picQRcode";
            this.picQRcode.Size = new System.Drawing.Size(100, 100);
            this.picQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picQRcode.TabIndex = 46;
            this.picQRcode.TabStop = false;
            // 
            // picUPN
            // 
            this.picUPN.BackColor = System.Drawing.Color.Transparent;
            this.picUPN.Location = new System.Drawing.Point(3, 3);
            this.picUPN.Name = "picUPN";
            this.picUPN.Size = new System.Drawing.Size(100, 40);
            this.picUPN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUPN.TabIndex = 45;
            this.picUPN.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(158, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "MSD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(0, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPN:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(494, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 12);
            this.label19.TabIndex = 58;
            this.label19.Text = "OPPO物料标识贴";
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.Controls.Add(this.panel12);
            this.pnl2.Controls.Add(this.panel11);
            this.pnl2.Controls.Add(this.panel10);
            this.pnl2.Controls.Add(this.panel9);
            this.pnl2.Controls.Add(this.panel8);
            this.pnl2.Controls.Add(this.panel7);
            this.pnl2.Controls.Add(this.panel6);
            this.pnl2.Controls.Add(this.panel5);
            this.pnl2.Controls.Add(this.panel4);
            this.pnl2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnl2.Location = new System.Drawing.Point(368, 51);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(346, 276);
            this.pnl2.TabIndex = 60;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(8, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 50);
            this.panel4.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(53, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 24);
            this.label8.TabIndex = 55;
            this.label8.Text = "OPPO物料标识贴";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(8, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(125, 50);
            this.panel5.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 16F);
            this.label9.Location = new System.Drawing.Point(0, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 55;
            this.label9.Text = "供应商代码";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(8, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(125, 50);
            this.panel6.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(8, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 55;
            this.label10.Text = "物料代码";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(8, 162);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(125, 50);
            this.panel7.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(8, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 24);
            this.label11.TabIndex = 55;
            this.label11.Text = "包装数量";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(8, 211);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(125, 50);
            this.panel8.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(8, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 55;
            this.label12.Text = "物体描述";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(0, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 28);
            this.textBox1.TabIndex = 57;
            this.textBox1.Text = "G117";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.textBox1);
            this.panel9.Location = new System.Drawing.Point(132, 64);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(206, 50);
            this.panel9.TabIndex = 58;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.textBox2);
            this.panel10.Location = new System.Drawing.Point(132, 113);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(206, 50);
            this.panel10.TabIndex = 59;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(0, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 28);
            this.textBox2.TabIndex = 57;
            this.textBox2.Text = "4879497";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.textBox3);
            this.panel11.Location = new System.Drawing.Point(132, 162);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(206, 50);
            this.panel11.TabIndex = 59;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(0, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 28);
            this.textBox3.TabIndex = 57;
            this.textBox3.Text = "1000";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.textBox5);
            this.panel12.Location = new System.Drawing.Point(132, 211);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(206, 50);
            this.panel12.TabIndex = 59;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(0, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(204, 28);
            this.textBox5.TabIndex = 57;
            this.textBox5.Text = "VC散热片AD097";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 341);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrint);
            this.Name = "Main";
            this.Text = "PrintLabel_OPPO";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUPN)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picQRcode;
        private System.Windows.Forms.PictureBox picUPN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUPN;
        private System.Windows.Forms.TextBox txtSoft;
        private System.Windows.Forms.TextBox txtQC;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.TextBox txtMSD;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtHard;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.Label label19;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox2;
    }
}

