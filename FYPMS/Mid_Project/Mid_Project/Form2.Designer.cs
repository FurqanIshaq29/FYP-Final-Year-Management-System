
namespace Mid_Project
{
    partial class ManageStu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStu_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelleft = new System.Windows.Forms.Panel();
            this.exit_button = new FontAwesome.Sharp.IconButton();
            this.searchstu_button = new FontAwesome.Sharp.IconButton();
            this.updatestu_button = new FontAwesome.Sharp.IconButton();
            this.addstu_button = new FontAwesome.Sharp.IconButton();
            this.home_button = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Search_tbox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.dgv_stu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.email_tbox = new System.Windows.Forms.TextBox();
            this.contact_tbox = new System.Windows.Forms.TextBox();
            this.lname_tbox = new System.Windows.Forms.TextBox();
            this.fname_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gender_cbox = new System.Windows.Forms.ComboBox();
            this.regno_tbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelleft.SuspendLayout();
            this.paneltitle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelleft.Controls.Add(this.exit_button);
            this.panelleft.Controls.Add(this.searchstu_button);
            this.panelleft.Controls.Add(this.updatestu_button);
            this.panelleft.Controls.Add(this.addstu_button);
            this.panelleft.Controls.Add(this.home_button);
            this.panelleft.Controls.Add(this.panel2);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(171, 575);
            this.panelleft.TabIndex = 3;
            // 
            // exit_button
            // 
            this.exit_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.exit_button.IconColor = System.Drawing.Color.White;
            this.exit_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exit_button.IconSize = 30;
            this.exit_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_button.Location = new System.Drawing.Point(0, 532);
            this.exit_button.Name = "exit_button";
            this.exit_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 5);
            this.exit_button.Size = new System.Drawing.Size(171, 43);
            this.exit_button.TabIndex = 11;
            this.exit_button.Text = "Exit";
            this.exit_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.iconButton10_Click);
            // 
            // searchstu_button
            // 
            this.searchstu_button.FlatAppearance.BorderSize = 0;
            this.searchstu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchstu_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchstu_button.ForeColor = System.Drawing.Color.White;
            this.searchstu_button.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchstu_button.IconColor = System.Drawing.Color.White;
            this.searchstu_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchstu_button.IconSize = 30;
            this.searchstu_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchstu_button.Location = new System.Drawing.Point(0, 407);
            this.searchstu_button.Name = "searchstu_button";
            this.searchstu_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.searchstu_button.Size = new System.Drawing.Size(153, 43);
            this.searchstu_button.TabIndex = 5;
            this.searchstu_button.Text = "Search Record";
            this.searchstu_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchstu_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchstu_button.UseVisualStyleBackColor = true;
            this.searchstu_button.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // updatestu_button
            // 
            this.updatestu_button.FlatAppearance.BorderSize = 0;
            this.updatestu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatestu_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatestu_button.ForeColor = System.Drawing.Color.White;
            this.updatestu_button.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.updatestu_button.IconColor = System.Drawing.Color.White;
            this.updatestu_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updatestu_button.IconSize = 30;
            this.updatestu_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatestu_button.Location = new System.Drawing.Point(3, 319);
            this.updatestu_button.Name = "updatestu_button";
            this.updatestu_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.updatestu_button.Size = new System.Drawing.Size(153, 43);
            this.updatestu_button.TabIndex = 4;
            this.updatestu_button.Text = "Update Record";
            this.updatestu_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatestu_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updatestu_button.UseVisualStyleBackColor = true;
            this.updatestu_button.Click += new System.EventHandler(this.updatestu_button_Click);
            // 
            // addstu_button
            // 
            this.addstu_button.FlatAppearance.BorderSize = 0;
            this.addstu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addstu_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstu_button.ForeColor = System.Drawing.Color.White;
            this.addstu_button.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.addstu_button.IconColor = System.Drawing.Color.White;
            this.addstu_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addstu_button.IconSize = 30;
            this.addstu_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addstu_button.Location = new System.Drawing.Point(0, 233);
            this.addstu_button.Name = "addstu_button";
            this.addstu_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addstu_button.Size = new System.Drawing.Size(153, 43);
            this.addstu_button.TabIndex = 3;
            this.addstu_button.Text = "Add Student Record";
            this.addstu_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addstu_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addstu_button.UseVisualStyleBackColor = true;
            this.addstu_button.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // home_button
            // 
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.ForeColor = System.Drawing.Color.White;
            this.home_button.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.home_button.IconColor = System.Drawing.Color.White;
            this.home_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.home_button.IconSize = 30;
            this.home_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_button.Location = new System.Drawing.Point(3, 129);
            this.home_button.Name = "home_button";
            this.home_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.home_button.Size = new System.Drawing.Size(153, 43);
            this.home_button.TabIndex = 2;
            this.home_button.Text = "Home";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 123);
            this.panel2.TabIndex = 1;
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.White;
            this.paneltitle.Controls.Add(this.label1);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(171, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(1433, 54);
            this.paneltitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vani", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "FINAL YEAR PRESENTATIONS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.dgv_stu);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(171, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1433, 521);
            this.panel3.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Search_tbox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Search, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(108, 75);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 42);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Search_tbox
            // 
            this.Search_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_tbox.Location = new System.Drawing.Point(236, 3);
            this.Search_tbox.Name = "Search_tbox";
            this.Search_tbox.Size = new System.Drawing.Size(228, 27);
            this.Search_tbox.TabIndex = 3;
            this.Search_tbox.Visible = false;
            this.Search_tbox.TextChanged += new System.EventHandler(this.Search_tbox_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.Search.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(142, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(88, 42);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.Visible = false;
            // 
            // dgv_stu
            // 
            this.dgv_stu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_stu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_stu.ColumnHeadersHeight = 30;
            this.dgv_stu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_stu.EnableHeadersVisualStyles = false;
            this.dgv_stu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_stu.Location = new System.Drawing.Point(23, 173);
            this.dgv_stu.Name = "dgv_stu";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stu.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_stu.Size = new System.Drawing.Size(801, 132);
            this.dgv_stu.TabIndex = 1;
            this.dgv_stu.Visible = false;
            this.dgv_stu.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stu_CellEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(857, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 521);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(174, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.email_tbox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.contact_tbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lname_tbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fname_tbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.gender_cbox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.regno_tbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(64, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 306);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Visible = false;
            // 
            // email_tbox
            // 
            this.email_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email_tbox.Location = new System.Drawing.Point(203, 175);
            this.email_tbox.Name = "email_tbox";
            this.email_tbox.Size = new System.Drawing.Size(272, 20);
            this.email_tbox.TabIndex = 13;
            // 
            // contact_tbox
            // 
            this.contact_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contact_tbox.Location = new System.Drawing.Point(203, 132);
            this.contact_tbox.Name = "contact_tbox";
            this.contact_tbox.Size = new System.Drawing.Size(272, 20);
            this.contact_tbox.TabIndex = 12;
            // 
            // lname_tbox
            // 
            this.lname_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lname_tbox.Location = new System.Drawing.Point(203, 89);
            this.lname_tbox.Name = "lname_tbox";
            this.lname_tbox.Size = new System.Drawing.Size(272, 20);
            this.lname_tbox.TabIndex = 11;
            // 
            // fname_tbox
            // 
            this.fname_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fname_tbox.Location = new System.Drawing.Point(203, 46);
            this.fname_tbox.Name = "fname_tbox";
            this.fname_tbox.Size = new System.Drawing.Size(272, 20);
            this.fname_tbox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reg No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 43);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 43);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 43);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(136, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 43);
            this.label8.TabIndex = 7;
            this.label8.Text = "DOB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 48);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gender";
            // 
            // gender_cbox
            // 
            this.gender_cbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gender_cbox.FormattingEnabled = true;
            this.gender_cbox.Location = new System.Drawing.Point(203, 261);
            this.gender_cbox.Name = "gender_cbox";
            this.gender_cbox.Size = new System.Drawing.Size(272, 21);
            this.gender_cbox.TabIndex = 15;
            // 
            // regno_tbox
            // 
            this.regno_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regno_tbox.Location = new System.Drawing.Point(203, 3);
            this.regno_tbox.Name = "regno_tbox";
            this.regno_tbox.Size = new System.Drawing.Size(272, 20);
            this.regno_tbox.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "dd-MM-yyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // ManageStu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 575);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelleft);
            this.Name = "ManageStu_Form";
            this.RightToLeftLayout = true;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelleft.ResumeLayout(false);
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private FontAwesome.Sharp.IconButton exit_button;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton searchstu_button;
        private FontAwesome.Sharp.IconButton updatestu_button;
        private FontAwesome.Sharp.IconButton addstu_button;
        private FontAwesome.Sharp.IconButton home_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox email_tbox;
        private System.Windows.Forms.TextBox contact_tbox;
        private System.Windows.Forms.TextBox lname_tbox;
        private System.Windows.Forms.TextBox fname_tbox;
        private System.Windows.Forms.TextBox regno_tbox;
        private System.Windows.Forms.ComboBox gender_cbox;
        private System.Windows.Forms.DataGridView dgv_stu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Search_tbox;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}