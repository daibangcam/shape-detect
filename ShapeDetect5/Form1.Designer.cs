namespace ShapeDetect5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lbKichThuoc = new System.Windows.Forms.Label();
            this.lbHinhDang = new System.Windows.Forms.Label();
            this.imBCam = new Emgu.CV.UI.ImageBox();
            this.imBXuLy = new Emgu.CV.UI.ImageBox();
            this.imBNhanDang = new Emgu.CV.UI.ImageBox();
            this.lbAnhXuLy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCamera = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTongSanPham = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.TextBox();
            this.lbTri = new System.Windows.Forms.TextBox();
            this.lbSquad = new System.Windows.Forms.TextBox();
            this.lbCir = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cbbBaudRate = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imBien = new Emgu.CV.UI.ImageBox();
            this.imNhiphan = new Emgu.CV.UI.ImageBox();
            this.imXam = new Emgu.CV.UI.ImageBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imBCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imBXuLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imBNhanDang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imBien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imNhiphan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imXam)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1837, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startCameraToolStripMenuItem,
            this.stopCameraToolStripMenuItem,
            this.exitFormToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(86, 30);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startCameraToolStripMenuItem
            // 
            this.startCameraToolStripMenuItem.Name = "startCameraToolStripMenuItem";
            this.startCameraToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.startCameraToolStripMenuItem.Text = "Start Camera";
            this.startCameraToolStripMenuItem.Click += new System.EventHandler(this.startCameraToolStripMenuItem_Click);
            // 
            // stopCameraToolStripMenuItem
            // 
            this.stopCameraToolStripMenuItem.Name = "stopCameraToolStripMenuItem";
            this.stopCameraToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.stopCameraToolStripMenuItem.Text = "Stop Camera";
            this.stopCameraToolStripMenuItem.Click += new System.EventHandler(this.stopCameraToolStripMenuItem_Click);
            // 
            // exitFormToolStripMenuItem
            // 
            this.exitFormToolStripMenuItem.Name = "exitFormToolStripMenuItem";
            this.exitFormToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.exitFormToolStripMenuItem.Text = "Exit Form";
            this.exitFormToolStripMenuItem.Click += new System.EventHandler(this.exitFormToolStripMenuItem_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1559, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 31);
            this.label7.TabIndex = 15;
            // 
            // lbKichThuoc
            // 
            this.lbKichThuoc.AutoSize = true;
            this.lbKichThuoc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKichThuoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbKichThuoc.Location = new System.Drawing.Point(1733, 122);
            this.lbKichThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKichThuoc.Name = "lbKichThuoc";
            this.lbKichThuoc.Size = new System.Drawing.Size(0, 31);
            this.lbKichThuoc.TabIndex = 16;
            // 
            // lbHinhDang
            // 
            this.lbHinhDang.AutoSize = true;
            this.lbHinhDang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHinhDang.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbHinhDang.Location = new System.Drawing.Point(1166, 329);
            this.lbHinhDang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHinhDang.Name = "lbHinhDang";
            this.lbHinhDang.Size = new System.Drawing.Size(328, 26);
            this.lbHinhDang.TabIndex = 12;
            this.lbHinhDang.Text = "(TRÒN, VUÔNG, TAM GIÁC)";
            // 
            // imBCam
            // 
            this.imBCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.imBCam.Location = new System.Drawing.Point(10, 359);
            this.imBCam.Margin = new System.Windows.Forms.Padding(4);
            this.imBCam.Name = "imBCam";
            this.imBCam.Size = new System.Drawing.Size(493, 345);
            this.imBCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imBCam.TabIndex = 2;
            this.imBCam.TabStop = false;
            // 
            // imBXuLy
            // 
            this.imBXuLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.imBXuLy.Location = new System.Drawing.Point(511, 359);
            this.imBXuLy.Margin = new System.Windows.Forms.Padding(4);
            this.imBXuLy.Name = "imBXuLy";
            this.imBXuLy.Size = new System.Drawing.Size(493, 345);
            this.imBXuLy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imBXuLy.TabIndex = 8;
            this.imBXuLy.TabStop = false;
            // 
            // imBNhanDang
            // 
            this.imBNhanDang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.imBNhanDang.Location = new System.Drawing.Point(1012, 359);
            this.imBNhanDang.Margin = new System.Windows.Forms.Padding(4);
            this.imBNhanDang.Name = "imBNhanDang";
            this.imBNhanDang.Size = new System.Drawing.Size(493, 345);
            this.imBNhanDang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imBNhanDang.TabIndex = 9;
            this.imBNhanDang.TabStop = false;
            // 
            // lbAnhXuLy
            // 
            this.lbAnhXuLy.AutoSize = true;
            this.lbAnhXuLy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnhXuLy.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbAnhXuLy.Location = new System.Drawing.Point(674, 329);
            this.lbAnhXuLy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAnhXuLy.Name = "lbAnhXuLy";
            this.lbAnhXuLy.Size = new System.Drawing.Size(145, 26);
            this.lbAnhXuLy.TabIndex = 11;
            this.lbAnhXuLy.Text = "ẢNH XỬ LÝ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(1007, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "HÌNH DẠNG";
            // 
            // lbCamera
            // 
            this.lbCamera.AutoSize = true;
            this.lbCamera.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamera.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbCamera.Location = new System.Drawing.Point(151, 329);
            this.lbCamera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCamera.Name = "lbCamera";
            this.lbCamera.Size = new System.Drawing.Size(182, 26);
            this.lbCamera.TabIndex = 10;
            this.lbCamera.Text = "CAMERA LIVE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShapeDetect5.Properties.Resources.logoHUFI;
            this.pictureBox1.Location = new System.Drawing.Point(53, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lbTongSanPham);
            this.panel2.Controls.Add(this.lbError);
            this.panel2.Controls.Add(this.lbTri);
            this.panel2.Controls.Add(this.lbSquad);
            this.panel2.Controls.Add(this.lbCir);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lb);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(511, 712);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 134);
            this.panel2.TabIndex = 51;
            // 
            // lbTongSanPham
            // 
            this.lbTongSanPham.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSanPham.ForeColor = System.Drawing.Color.Red;
            this.lbTongSanPham.Location = new System.Drawing.Point(915, 38);
            this.lbTongSanPham.Multiline = true;
            this.lbTongSanPham.Name = "lbTongSanPham";
            this.lbTongSanPham.Size = new System.Drawing.Size(43, 31);
            this.lbTongSanPham.TabIndex = 39;
            // 
            // lbError
            // 
            this.lbError.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Firebrick;
            this.lbError.Location = new System.Drawing.Point(503, 38);
            this.lbError.Multiline = true;
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(43, 31);
            this.lbError.TabIndex = 38;
            // 
            // lbTri
            // 
            this.lbTri.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTri.ForeColor = System.Drawing.Color.DeepPink;
            this.lbTri.Location = new System.Drawing.Point(286, 83);
            this.lbTri.Multiline = true;
            this.lbTri.Name = "lbTri";
            this.lbTri.Size = new System.Drawing.Size(43, 31);
            this.lbTri.TabIndex = 37;
            // 
            // lbSquad
            // 
            this.lbSquad.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSquad.ForeColor = System.Drawing.Color.DeepPink;
            this.lbSquad.Location = new System.Drawing.Point(286, 44);
            this.lbSquad.Multiline = true;
            this.lbSquad.Name = "lbSquad";
            this.lbSquad.Size = new System.Drawing.Size(43, 31);
            this.lbSquad.TabIndex = 37;
            // 
            // lbCir
            // 
            this.lbCir.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCir.ForeColor = System.Drawing.Color.DeepPink;
            this.lbCir.Location = new System.Drawing.Point(286, 5);
            this.lbCir.Multiline = true;
            this.lbCir.Name = "lbCir";
            this.lbCir.Size = new System.Drawing.Size(43, 31);
            this.lbCir.TabIndex = 36;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(646, 46);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(214, 26);
            this.label23.TabIndex = 34;
            this.label23.Text = "TỔNG SẢN PHẨM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(410, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 26);
            this.label6.TabIndex = 27;
            this.label6.Text = "LỖI";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.DeepPink;
            this.lb.Location = new System.Drawing.Point(15, 52);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(170, 26);
            this.lb.TabIndex = 27;
            this.lb.Text = "HÌNH VUÔNG";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DeepPink;
            this.label11.Location = new System.Drawing.Point(15, 91);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 26);
            this.label11.TabIndex = 22;
            this.label11.Text = "HÌNH TAM GIÁC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(15, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "HÌNH TRÒN";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(346, 6);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 34);
            this.comboBox1.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Coral;
            this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnConnect.Location = new System.Drawing.Point(9, 82);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(221, 43);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "KẾT NỐI";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "CHỌN CỔNG COM";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Coral;
            this.btnDisconnect.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDisconnect.Location = new System.Drawing.Point(234, 82);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(245, 43);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "NGẮT KÉT NỐI";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // cbbBaudRate
            // 
            this.cbbBaudRate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBaudRate.FormattingEnabled = true;
            this.cbbBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "11520"});
            this.cbbBaudRate.Location = new System.Drawing.Point(346, 44);
            this.cbbBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBaudRate.Name = "cbbBaudRate";
            this.cbbBaudRate.Size = new System.Drawing.Size(133, 34);
            this.cbbBaudRate.TabIndex = 9;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Blue;
            this.label26.Location = new System.Drawing.Point(4, 43);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(178, 26);
            this.label26.TabIndex = 10;
            this.label26.Text = "TỐC ĐỘ BAUD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.cbbBaudRate);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(10, 712);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 134);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(284, 38);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1090, 83);
            this.panel4.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(317, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "KHOA CÔNG NGHỆ ĐIỆN - ĐIỆN TỬ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(76, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(897, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "TRƯỜNG ĐẠI HỌC CÔNG NGHIỆP THỰC PHẨM TP. HỒ CHÍ MINH";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(626, 125);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(431, 37);
            this.label12.TabIndex = 58;
            this.label12.Text = "KHÓA LUẬN TỐT NGHIỆP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(293, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1075, 160);
            this.label9.TabIndex = 61;
            this.label9.Text = "Tên đề tài: Thiết kế thi công mô hình phân loại sản phẩm theo hình dạng dùng xử l" +
    "ý ảnh\r\nGVHD:       ThS. Trần Hoàn\r\nSinh viên:   Đào Ngọc Đô\r\nMSSV:        203217" +
    "2019\r\n\r\n";
            // 
            // imBien
            // 
            this.imBien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.imBien.Location = new System.Drawing.Point(1513, 0);
            this.imBien.Margin = new System.Windows.Forms.Padding(4);
            this.imBien.Name = "imBien";
            this.imBien.Size = new System.Drawing.Size(493, 345);
            this.imBien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imBien.TabIndex = 9;
            this.imBien.TabStop = false;
            // 
            // imNhiphan
            // 
            this.imNhiphan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.imNhiphan.Location = new System.Drawing.Point(1513, 341);
            this.imNhiphan.Margin = new System.Windows.Forms.Padding(4);
            this.imNhiphan.Name = "imNhiphan";
            this.imNhiphan.Size = new System.Drawing.Size(493, 345);
            this.imNhiphan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imNhiphan.TabIndex = 9;
            this.imNhiphan.TabStop = false;
            // 
            // imXam
            // 
            this.imXam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.imXam.Location = new System.Drawing.Point(1513, 680);
            this.imXam.Margin = new System.Windows.Forms.Padding(4);
            this.imXam.Name = "imXam";
            this.imXam.Size = new System.Drawing.Size(493, 345);
            this.imXam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imXam.TabIndex = 9;
            this.imXam.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1837, 874);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbKichThuoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbHinhDang);
            this.Controls.Add(this.lbAnhXuLy);
            this.Controls.Add(this.imXam);
            this.Controls.Add(this.lbCamera);
            this.Controls.Add(this.imNhiphan);
            this.Controls.Add(this.imBien);
            this.Controls.Add(this.imBNhanDang);
            this.Controls.Add(this.imBXuLy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imBCam);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imBCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imBXuLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imBNhanDang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imBien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imNhiphan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imXam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitFormToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbKichThuoc;
        private System.Windows.Forms.Label lbHinhDang;
        private Emgu.CV.UI.ImageBox imBCam;
        private Emgu.CV.UI.ImageBox imBXuLy;
        private Emgu.CV.UI.ImageBox imBNhanDang;
        private System.Windows.Forms.Label lbAnhXuLy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCamera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox lbTongSanPham;
        private System.Windows.Forms.TextBox lbError;
        private System.Windows.Forms.TextBox lbTri;
        private System.Windows.Forms.TextBox lbSquad;
        private System.Windows.Forms.TextBox lbCir;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private Emgu.CV.UI.ImageBox imBien;
        private Emgu.CV.UI.ImageBox imNhiphan;
        private Emgu.CV.UI.ImageBox imXam;
    }
}

