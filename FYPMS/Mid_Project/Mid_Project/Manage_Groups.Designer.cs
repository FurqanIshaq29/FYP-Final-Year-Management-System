
namespace Mid_Project
{
    partial class Manage_Groups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Groups));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelleft = new System.Windows.Forms.Panel();
            this.exit_button = new FontAwesome.Sharp.IconButton();
            this.searchgroup_button = new FontAwesome.Sharp.IconButton();
            this.removestu_button = new FontAwesome.Sharp.IconButton();
            this.creategroup_button = new FontAwesome.Sharp.IconButton();
            this.home_button = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_stu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_groupmembers = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Search_tbox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.panelleft.SuspendLayout();
            this.paneltitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_groupmembers)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelleft.Controls.Add(this.exit_button);
            this.panelleft.Controls.Add(this.searchgroup_button);
            this.panelleft.Controls.Add(this.removestu_button);
            this.panelleft.Controls.Add(this.creategroup_button);
            this.panelleft.Controls.Add(this.home_button);
            this.panelleft.Controls.Add(this.panel2);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(181, 575);
            this.panelleft.TabIndex = 5;
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
            this.exit_button.Size = new System.Drawing.Size(181, 43);
            this.exit_button.TabIndex = 11;
            this.exit_button.Text = "Exit";
            this.exit_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // searchgroup_button
            // 
            this.searchgroup_button.FlatAppearance.BorderSize = 0;
            this.searchgroup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchgroup_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchgroup_button.ForeColor = System.Drawing.Color.White;
            this.searchgroup_button.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchgroup_button.IconColor = System.Drawing.Color.White;
            this.searchgroup_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchgroup_button.IconSize = 30;
            this.searchgroup_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchgroup_button.Location = new System.Drawing.Point(3, 440);
            this.searchgroup_button.Name = "searchgroup_button";
            this.searchgroup_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.searchgroup_button.Size = new System.Drawing.Size(153, 43);
            this.searchgroup_button.TabIndex = 5;
            this.searchgroup_button.Text = "Search Groups";
            this.searchgroup_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchgroup_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchgroup_button.UseVisualStyleBackColor = true;
            this.searchgroup_button.Click += new System.EventHandler(this.searchgroup_button_Click);
            // 
            // removestu_button
            // 
            this.removestu_button.FlatAppearance.BorderSize = 0;
            this.removestu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removestu_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removestu_button.ForeColor = System.Drawing.Color.White;
            this.removestu_button.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.removestu_button.IconColor = System.Drawing.Color.White;
            this.removestu_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.removestu_button.IconSize = 30;
            this.removestu_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removestu_button.Location = new System.Drawing.Point(0, 328);
            this.removestu_button.Name = "removestu_button";
            this.removestu_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.removestu_button.Size = new System.Drawing.Size(153, 62);
            this.removestu_button.TabIndex = 4;
            this.removestu_button.Text = "Remove any Student from Group";
            this.removestu_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removestu_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removestu_button.UseVisualStyleBackColor = true;
            this.removestu_button.Click += new System.EventHandler(this.removestu_button_Click);
            // 
            // creategroup_button
            // 
            this.creategroup_button.FlatAppearance.BorderSize = 0;
            this.creategroup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creategroup_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creategroup_button.ForeColor = System.Drawing.Color.White;
            this.creategroup_button.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.creategroup_button.IconColor = System.Drawing.Color.White;
            this.creategroup_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.creategroup_button.IconSize = 30;
            this.creategroup_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creategroup_button.Location = new System.Drawing.Point(3, 237);
            this.creategroup_button.Name = "creategroup_button";
            this.creategroup_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.creategroup_button.Size = new System.Drawing.Size(153, 43);
            this.creategroup_button.TabIndex = 3;
            this.creategroup_button.Text = "Create Group";
            this.creategroup_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creategroup_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.creategroup_button.UseVisualStyleBackColor = true;
            this.creategroup_button.Click += new System.EventHandler(this.addproject_button_Click);
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
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 123);
            this.panel2.TabIndex = 1;
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.White;
            this.paneltitle.Controls.Add(this.label1);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(181, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(1209, 54);
            this.paneltitle.TabIndex = 6;
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
            this.dgv_stu.Location = new System.Drawing.Point(191, 146);
            this.dgv_stu.Name = "dgv_stu";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stu.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_stu.Size = new System.Drawing.Size(1187, 164);
            this.dgv_stu.TabIndex = 7;
            this.dgv_stu.Visible = false;
            this.dgv_stu.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stu_CellEnter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1077, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add in Group";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(204, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save and Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_groupmembers
            // 
            this.dgv_groupmembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_groupmembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_groupmembers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_groupmembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_groupmembers.ColumnHeadersHeight = 30;
            this.dgv_groupmembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_groupmembers.EnableHeadersVisualStyles = false;
            this.dgv_groupmembers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_groupmembers.Location = new System.Drawing.Point(269, 226);
            this.dgv_groupmembers.Name = "dgv_groupmembers";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_groupmembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_groupmembers.Size = new System.Drawing.Size(658, 164);
            this.dgv_groupmembers.TabIndex = 10;
            this.dgv_groupmembers.Visible = false;
            this.dgv_groupmembers.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_groupmembers_CellEnter);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(576, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(301, 40);
            this.button3.TabIndex = 11;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(301, 81);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(455, 42);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // Search_tbox
            // 
            this.Search_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_tbox.Location = new System.Drawing.Point(230, 3);
            this.Search_tbox.Name = "Search_tbox";
            this.Search_tbox.Size = new System.Drawing.Size(222, 27);
            this.Search_tbox.TabIndex = 3;
            this.Search_tbox.Visible = false;
            this.Search_tbox.TextChanged += new System.EventHandler(this.Search_tbox_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.Search.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(136, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(88, 42);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.Visible = false;
            // 
            // Manage_Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 575);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgv_groupmembers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_stu);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelleft);
            this.Name = "Manage_Groups";
            this.Text = "Manage_Groups";
            this.panelleft.ResumeLayout(false);
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_groupmembers)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private FontAwesome.Sharp.IconButton exit_button;
        private FontAwesome.Sharp.IconButton searchgroup_button;
        private FontAwesome.Sharp.IconButton removestu_button;
        private FontAwesome.Sharp.IconButton creategroup_button;
        private FontAwesome.Sharp.IconButton home_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_stu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_groupmembers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Search_tbox;
        private System.Windows.Forms.Label Search;
    }
}