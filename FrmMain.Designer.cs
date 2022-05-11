namespace RTSP_Cameras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.GunaGroupboxNameInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ConnectedTo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GunaGroupBoxVerifLogiciel = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnFlux = new Guna.UI2.WinForms.Guna2Button();
            this.TxtIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtSecret = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GunaGroupBoxInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LblVersion = new Guna.UI.WinForms.GunaLabel();
            this.Lbl6 = new Guna.UI.WinForms.GunaLabel();
            this.LblAccessDistant = new Guna.UI.WinForms.GunaLabel();
            this.Lbl5 = new Guna.UI.WinForms.GunaLabel();
            this.LblIP = new Guna.UI.WinForms.GunaLabel();
            this.Lbl4 = new Guna.UI.WinForms.GunaLabel();
            this.LblInternet = new Guna.UI.WinForms.GunaLabel();
            this.Lbl3 = new Guna.UI.WinForms.GunaLabel();
            this.LblRegistre = new Guna.UI.WinForms.GunaLabel();
            this.Lbl2 = new Guna.UI.WinForms.GunaLabel();
            this.LblAdmin = new Guna.UI.WinForms.GunaLabel();
            this.Lbl1 = new Guna.UI.WinForms.GunaLabel();
            this.GunaGroupboxNameVerifLogi = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.GunaGroupBoxInfo.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.vlcControl1.Location = new System.Drawing.Point(9, 12);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(723, 500);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 3;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // GunaGroupboxNameInfo
            // 
            this.GunaGroupboxNameInfo.BackColor = System.Drawing.Color.Transparent;
            this.GunaGroupboxNameInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.GunaGroupboxNameInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.GunaGroupboxNameInfo.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.GunaGroupboxNameInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.GunaGroupboxNameInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaGroupboxNameInfo.ForeColor = System.Drawing.Color.White;
            this.GunaGroupboxNameInfo.Location = new System.Drawing.Point(3, 12);
            this.GunaGroupboxNameInfo.Name = "GunaGroupboxNameInfo";
            this.GunaGroupboxNameInfo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.GunaGroupboxNameInfo.ShadowDecoration.Parent = this.GunaGroupboxNameInfo;
            this.GunaGroupboxNameInfo.Size = new System.Drawing.Size(734, 49);
            this.GunaGroupboxNameInfo.TabIndex = 4;
            this.GunaGroupboxNameInfo.Text = "Real Time camera:";
            this.GunaGroupboxNameInfo.TextOffset = new System.Drawing.Point(1, 3);
            // 
            // ConnectedTo
            // 
            this.ConnectedTo.BackColor = System.Drawing.Color.Transparent;
            this.ConnectedTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ConnectedTo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.ConnectedTo.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.ConnectedTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ConnectedTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConnectedTo.ForeColor = System.Drawing.Color.White;
            this.ConnectedTo.Location = new System.Drawing.Point(6, 462);
            this.ConnectedTo.Name = "ConnectedTo";
            this.ConnectedTo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.ConnectedTo.ShadowDecoration.Parent = this.ConnectedTo;
            this.ConnectedTo.Size = new System.Drawing.Size(731, 50);
            this.ConnectedTo.TabIndex = 5;
            this.ConnectedTo.Text = "Connected to: ...";
            this.ConnectedTo.TextOffset = new System.Drawing.Point(1, 4);
            // 
            // GunaGroupBoxVerifLogiciel
            // 
            this.GunaGroupBoxVerifLogiciel.BackColor = System.Drawing.Color.Transparent;
            this.GunaGroupBoxVerifLogiciel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.GunaGroupBoxVerifLogiciel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.GunaGroupBoxVerifLogiciel.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.GunaGroupBoxVerifLogiciel.FillColor = System.Drawing.Color.Transparent;
            this.GunaGroupBoxVerifLogiciel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaGroupBoxVerifLogiciel.ForeColor = System.Drawing.Color.White;
            this.GunaGroupBoxVerifLogiciel.Location = new System.Drawing.Point(3, 12);
            this.GunaGroupBoxVerifLogiciel.Name = "GunaGroupBoxVerifLogiciel";
            this.GunaGroupBoxVerifLogiciel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.GunaGroupBoxVerifLogiciel.ShadowDecoration.Parent = this.GunaGroupBoxVerifLogiciel;
            this.GunaGroupBoxVerifLogiciel.Size = new System.Drawing.Size(734, 500);
            this.GunaGroupBoxVerifLogiciel.TabIndex = 9;
            // 
            // BtnFlux
            // 
            this.BtnFlux.Animated = true;
            this.BtnFlux.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.BtnFlux.BorderThickness = 1;
            this.BtnFlux.CheckedState.Parent = this.BtnFlux;
            this.BtnFlux.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.BtnFlux.CustomImages.Parent = this.BtnFlux;
            this.BtnFlux.FillColor = System.Drawing.Color.Transparent;
            this.BtnFlux.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFlux.ForeColor = System.Drawing.Color.White;
            this.BtnFlux.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.BtnFlux.HoverState.Parent = this.BtnFlux;
            this.BtnFlux.Image = ((System.Drawing.Image)(resources.GetObject("BtnFlux.Image")));
            this.BtnFlux.Location = new System.Drawing.Point(482, 518);
            this.BtnFlux.Name = "BtnFlux";
            this.BtnFlux.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.BtnFlux.ShadowDecoration.Parent = this.BtnFlux;
            this.BtnFlux.Size = new System.Drawing.Size(255, 45);
            this.BtnFlux.TabIndex = 10;
            this.BtnFlux.Text = "Connect to flux";
            this.BtnFlux.Click += new System.EventHandler(this.BtnFlux_Click);
            // 
            // TxtIP
            // 
            this.TxtIP.Animated = true;
            this.TxtIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.TxtIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtIP.DefaultText = "";
            this.TxtIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtIP.DisabledState.Parent = this.TxtIP;
            this.TxtIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtIP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.TxtIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtIP.FocusedState.Parent = this.TxtIP;
            this.TxtIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtIP.HoverState.Parent = this.TxtIP;
            this.TxtIP.Location = new System.Drawing.Point(6, 518);
            this.TxtIP.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.PasswordChar = '\0';
            this.TxtIP.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtIP.PlaceholderText = "IP..";
            this.TxtIP.SelectedText = "";
            this.TxtIP.ShadowDecoration.Parent = this.TxtIP;
            this.TxtIP.Size = new System.Drawing.Size(205, 45);
            this.TxtIP.TabIndex = 0;
            // 
            // TxtSecret
            // 
            this.TxtSecret.Animated = true;
            this.TxtSecret.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.TxtSecret.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSecret.DefaultText = "";
            this.TxtSecret.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSecret.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSecret.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSecret.DisabledState.Parent = this.TxtSecret;
            this.TxtSecret.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSecret.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.TxtSecret.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSecret.FocusedState.Parent = this.TxtSecret;
            this.TxtSecret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSecret.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSecret.HoverState.Parent = this.TxtSecret;
            this.TxtSecret.Location = new System.Drawing.Point(221, 518);
            this.TxtSecret.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtSecret.Name = "TxtSecret";
            this.TxtSecret.PasswordChar = '\0';
            this.TxtSecret.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSecret.PlaceholderText = "Password..";
            this.TxtSecret.SelectedText = "";
            this.TxtSecret.ShadowDecoration.Parent = this.TxtSecret;
            this.TxtSecret.Size = new System.Drawing.Size(253, 45);
            this.TxtSecret.TabIndex = 11;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(743, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(323, 49);
            this.guna2GroupBox1.TabIndex = 13;
            this.guna2GroupBox1.Text = "Configuration";
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, 6);
            // 
            // GunaGroupBoxInfo
            // 
            this.GunaGroupBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.GunaGroupBoxInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.GunaGroupBoxInfo.Controls.Add(this.guna2CheckBox2);
            this.GunaGroupBoxInfo.Controls.Add(this.guna2CheckBox1);
            this.GunaGroupBoxInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.GunaGroupBoxInfo.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.GunaGroupBoxInfo.FillColor = System.Drawing.Color.Transparent;
            this.GunaGroupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaGroupBoxInfo.ForeColor = System.Drawing.Color.White;
            this.GunaGroupBoxInfo.Location = new System.Drawing.Point(743, 53);
            this.GunaGroupBoxInfo.Name = "GunaGroupBoxInfo";
            this.GunaGroupBoxInfo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.GunaGroupBoxInfo.ShadowDecoration.Parent = this.GunaGroupBoxInfo;
            this.GunaGroupBoxInfo.Size = new System.Drawing.Size(323, 172);
            this.GunaGroupBoxInfo.TabIndex = 14;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.Animated = true;
            this.guna2CheckBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(243)))));
            this.guna2CheckBox1.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.guna2CheckBox1.Location = new System.Drawing.Point(14, 9);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(117, 34);
            this.guna2CheckBox1.TabIndex = 0;
            this.guna2CheckBox1.Text = "Always on top";
            this.guna2CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.guna2CheckBox1.UseVisualStyleBackColor = true;
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.GunaGroupboxNameInfo;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(743, 518);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(323, 45);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "Quit application";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.guna2GroupBox2.Controls.Add(this.LblVersion);
            this.guna2GroupBox2.Controls.Add(this.Lbl6);
            this.guna2GroupBox2.Controls.Add(this.LblAccessDistant);
            this.guna2GroupBox2.Controls.Add(this.Lbl5);
            this.guna2GroupBox2.Controls.Add(this.LblIP);
            this.guna2GroupBox2.Controls.Add(this.Lbl4);
            this.guna2GroupBox2.Controls.Add(this.LblInternet);
            this.guna2GroupBox2.Controls.Add(this.Lbl3);
            this.guna2GroupBox2.Controls.Add(this.LblRegistre);
            this.guna2GroupBox2.Controls.Add(this.Lbl2);
            this.guna2GroupBox2.Controls.Add(this.LblAdmin);
            this.guna2GroupBox2.Controls.Add(this.Lbl1);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(743, 272);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(323, 240);
            this.guna2GroupBox2.TabIndex = 19;
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LblVersion.ForeColor = System.Drawing.Color.Green;
            this.LblVersion.Location = new System.Drawing.Point(130, 93);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(30, 15);
            this.LblVersion.TabIndex = 14;
            this.LblVersion.Text = "[1.0]";
            // 
            // Lbl6
            // 
            this.Lbl6.AutoSize = true;
            this.Lbl6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lbl6.Location = new System.Drawing.Point(3, 93);
            this.Lbl6.Name = "Lbl6";
            this.Lbl6.Size = new System.Drawing.Size(48, 15);
            this.Lbl6.TabIndex = 13;
            this.Lbl6.Text = "Version:";
            // 
            // LblAccessDistant
            // 
            this.LblAccessDistant.AutoSize = true;
            this.LblAccessDistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LblAccessDistant.Location = new System.Drawing.Point(130, 78);
            this.LblAccessDistant.Name = "LblAccessDistant";
            this.LblAccessDistant.Size = new System.Drawing.Size(39, 15);
            this.LblAccessDistant.TabIndex = 12;
            this.LblAccessDistant.Text = "-> OK";
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lbl5.Location = new System.Drawing.Point(3, 78);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(84, 15);
            this.Lbl5.TabIndex = 11;
            this.Lbl5.Text = "Distant access:";
            // 
            // LblIP
            // 
            this.LblIP.AutoSize = true;
            this.LblIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LblIP.Location = new System.Drawing.Point(130, 63);
            this.LblIP.Name = "LblIP";
            this.LblIP.Size = new System.Drawing.Size(16, 15);
            this.LblIP.TabIndex = 10;
            this.LblIP.Text = "...";
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lbl4.Location = new System.Drawing.Point(3, 63);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(63, 15);
            this.Lbl4.TabIndex = 9;
            this.Lbl4.Text = "IP address:";
            // 
            // LblInternet
            // 
            this.LblInternet.AutoSize = true;
            this.LblInternet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LblInternet.Location = new System.Drawing.Point(130, 48);
            this.LblInternet.Name = "LblInternet";
            this.LblInternet.Size = new System.Drawing.Size(39, 15);
            this.LblInternet.TabIndex = 6;
            this.LblInternet.Text = "-> OK";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lbl3.Location = new System.Drawing.Point(3, 48);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(51, 15);
            this.Lbl3.TabIndex = 5;
            this.Lbl3.Text = "Internet:";
            // 
            // LblRegistre
            // 
            this.LblRegistre.AutoSize = true;
            this.LblRegistre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LblRegistre.Location = new System.Drawing.Point(130, 33);
            this.LblRegistre.Name = "LblRegistre";
            this.LblRegistre.Size = new System.Drawing.Size(39, 15);
            this.LblRegistre.TabIndex = 4;
            this.LblRegistre.Text = "-> OK";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lbl2.Location = new System.Drawing.Point(3, 33);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(86, 15);
            this.Lbl2.TabIndex = 3;
            this.Lbl2.Text = "Registry access";
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LblAdmin.Location = new System.Drawing.Point(130, 18);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(39, 15);
            this.LblAdmin.TabIndex = 2;
            this.LblAdmin.Text = "-> OK";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lbl1.Location = new System.Drawing.Point(3, 18);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(116, 15);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.Text = "Administrator rights:";
            // 
            // GunaGroupboxNameVerifLogi
            // 
            this.GunaGroupboxNameVerifLogi.BackColor = System.Drawing.Color.Transparent;
            this.GunaGroupboxNameVerifLogi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.GunaGroupboxNameVerifLogi.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.GunaGroupboxNameVerifLogi.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.GunaGroupboxNameVerifLogi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.GunaGroupboxNameVerifLogi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaGroupboxNameVerifLogi.ForeColor = System.Drawing.Color.White;
            this.GunaGroupboxNameVerifLogi.Location = new System.Drawing.Point(743, 231);
            this.GunaGroupboxNameVerifLogi.Name = "GunaGroupboxNameVerifLogi";
            this.GunaGroupboxNameVerifLogi.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.GunaGroupboxNameVerifLogi.ShadowDecoration.Parent = this.GunaGroupboxNameVerifLogi;
            this.GunaGroupboxNameVerifLogi.Size = new System.Drawing.Size(323, 41);
            this.GunaGroupboxNameVerifLogi.TabIndex = 18;
            this.GunaGroupboxNameVerifLogi.Text = "Extra information";
            this.GunaGroupboxNameVerifLogi.TextOffset = new System.Drawing.Point(0, 1);
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.Animated = true;
            this.guna2CheckBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.CheckedState.BorderRadius = 2;
            this.guna2CheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(243)))));
            this.guna2CheckBox2.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.guna2CheckBox2.Location = new System.Drawing.Point(14, 36);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(74, 34);
            this.guna2CheckBox2.TabIndex = 1;
            this.guna2CheckBox2.Text = "Sound";
            this.guna2CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.guna2CheckBox2.UseVisualStyleBackColor = true;
            this.guna2CheckBox2.CheckedChanged += new System.EventHandler(this.guna2CheckBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1078, 607);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.GunaGroupboxNameVerifLogi);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.GunaGroupBoxInfo);
            this.Controls.Add(this.TxtSecret);
            this.Controls.Add(this.TxtIP);
            this.Controls.Add(this.BtnFlux);
            this.Controls.Add(this.ConnectedTo);
            this.Controls.Add(this.GunaGroupboxNameInfo);
            this.Controls.Add(this.vlcControl1);
            this.Controls.Add(this.GunaGroupBoxVerifLogiciel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.GunaGroupBoxInfo.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private Guna.UI2.WinForms.Guna2GroupBox GunaGroupboxNameInfo;
        private Guna.UI2.WinForms.Guna2GroupBox ConnectedTo;
        private Guna.UI2.WinForms.Guna2GroupBox GunaGroupBoxVerifLogiciel;
        private Guna.UI2.WinForms.Guna2Button BtnFlux;
        private Guna.UI2.WinForms.Guna2TextBox TxtIP;
        private Guna.UI2.WinForms.Guna2TextBox TxtSecret;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox GunaGroupBoxInfo;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI.WinForms.GunaLabel LblVersion;
        private Guna.UI.WinForms.GunaLabel Lbl6;
        private Guna.UI.WinForms.GunaLabel LblAccessDistant;
        private Guna.UI.WinForms.GunaLabel Lbl5;
        private Guna.UI.WinForms.GunaLabel LblIP;
        private Guna.UI.WinForms.GunaLabel Lbl4;
        private Guna.UI.WinForms.GunaLabel LblInternet;
        private Guna.UI.WinForms.GunaLabel Lbl3;
        private Guna.UI.WinForms.GunaLabel LblRegistre;
        private Guna.UI.WinForms.GunaLabel Lbl2;
        private Guna.UI.WinForms.GunaLabel LblAdmin;
        private Guna.UI.WinForms.GunaLabel Lbl1;
        private Guna.UI2.WinForms.Guna2GroupBox GunaGroupboxNameVerifLogi;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
    }
}

