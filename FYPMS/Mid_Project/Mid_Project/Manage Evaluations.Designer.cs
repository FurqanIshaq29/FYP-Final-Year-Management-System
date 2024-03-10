
namespace Mid_Project
{
    partial class Manage_Evaluations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Evaluations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelleft = new System.Windows.Forms.Panel();
            this.exit_button = new FontAwesome.Sharp.IconButton();
            this.searchevaluation_button = new FontAwesome.Sharp.IconButton();
            this.updateevaluation_button = new FontAwesome.Sharp.IconButton();
            this.addevaluation_button = new FontAwesome.Sharp.IconButton();
            this.home_button = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.weightage_cbox = new System.Windows.Forms.ComboBox();
            this.marks_cbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_tbox = new System.Windows.Forms.TextBox();
            this.dgv_evaluation = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Search_tbox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.panelleft.SuspendLayout();
            this.paneltitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evaluation)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelleft.Controls.Add(this.exit_button);
            this.panelleft.Controls.Add(this.searchevaluation_button);
            this.panelleft.Controls.Add(this.updateevaluation_button);
            this.panelleft.Controls.Add(this.addevaluation_button);
            this.panelleft.Controls.Add(this.home_button);
            this.panelleft.Controls.Add(this.panel2);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(181, 595);
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
            this.exit_button.Location = new System.Drawing.Point(0, 552);
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
            // searchevaluation_button
            // 
            this.searchevaluation_button.FlatAppearance.BorderSize = 0;
            this.searchevaluation_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchevaluation_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchevaluation_button.ForeColor = System.Drawing.Color.White;
            this.searchevaluation_button.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchevaluation_button.IconColor = System.Drawing.Color.White;
            this.searchevaluation_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchevaluation_button.IconSize = 30;
            this.searchevaluation_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchevaluation_button.Location = new System.Drawing.Point(3, 429);
            this.searchevaluation_button.Name = "searchevaluation_button";
            this.searchevaluation_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.searchevaluation_button.Size = new System.Drawing.Size(153, 43);
            this.searchevaluation_button.TabIndex = 5;
            this.searchevaluation_button.Text = "Search Evaluations";
            this.searchevaluation_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchevaluation_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchevaluation_button.UseVisualStyleBackColor = true;
            this.searchevaluation_button.Click += new System.EventHandler(this.searchevaluation_button_Click);
            // 
            // updateevaluation_button
            // 
            this.updateevaluation_button.FlatAppearance.BorderSize = 0;
            this.updateevaluation_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateevaluation_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateevaluation_button.ForeColor = System.Drawing.Color.White;
            this.updateevaluation_button.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.updateevaluation_button.IconColor = System.Drawing.Color.White;
            this.updateevaluation_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateevaluation_button.IconSize = 30;
            this.updateevaluation_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateevaluation_button.Location = new System.Drawing.Point(0, 310);
            this.updateevaluation_button.Name = "updateevaluation_button";
            this.updateevaluation_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.updateevaluation_button.Size = new System.Drawing.Size(153, 68);
            this.updateevaluation_button.TabIndex = 4;
            this.updateevaluation_button.Text = "Update/Edit Any Evaluation";
            this.updateevaluation_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateevaluation_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateevaluation_button.UseVisualStyleBackColor = true;
            this.updateevaluation_button.Click += new System.EventHandler(this.updateevaluation_button_Click);
            // 
            // addevaluation_button
            // 
            this.addevaluation_button.FlatAppearance.BorderSize = 0;
            this.addevaluation_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addevaluation_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addevaluation_button.ForeColor = System.Drawing.Color.White;
            this.addevaluation_button.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addevaluation_button.IconColor = System.Drawing.Color.White;
            this.addevaluation_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addevaluation_button.IconSize = 30;
            this.addevaluation_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addevaluation_button.Location = new System.Drawing.Point(0, 207);
            this.addevaluation_button.Name = "addevaluation_button";
            this.addevaluation_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addevaluation_button.Size = new System.Drawing.Size(153, 68);
            this.addevaluation_button.TabIndex = 3;
            this.addevaluation_button.Text = "Add Evaluation for Project";
            this.addevaluation_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addevaluation_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addevaluation_button.UseVisualStyleBackColor = true;
            this.addevaluation_button.Click += new System.EventHandler(this.addevaluation_button_Click);
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
            this.paneltitle.Size = new System.Drawing.Size(910, 54);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(722, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 541);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(61, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 40);
            this.button1.TabIndex = 2;
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
            this.tableLayoutPanel1.Controls.Add(this.weightage_cbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.marks_cbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.name_tbox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 313);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Visible = false;
            // 
            // weightage_cbox
            // 
            this.weightage_cbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightage_cbox.FormattingEnabled = true;
            this.weightage_cbox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40"});
            this.weightage_cbox.Location = new System.Drawing.Point(203, 211);
            this.weightage_cbox.Name = "weightage_cbox";
            this.weightage_cbox.Size = new System.Drawing.Size(101, 21);
            this.weightage_cbox.TabIndex = 20;
            // 
            // marks_cbox
            // 
            this.marks_cbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marks_cbox.FormattingEnabled = true;
            this.marks_cbox.Items.AddRange(new object[] {
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.marks_cbox.Location = new System.Drawing.Point(203, 107);
            this.marks_cbox.Name = "marks_cbox";
            this.marks_cbox.Size = new System.Drawing.Size(101, 21);
            this.marks_cbox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 105);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Weightage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 104);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 104);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Marks";
            // 
            // name_tbox
            // 
            this.name_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_tbox.Location = new System.Drawing.Point(203, 3);
            this.name_tbox.Name = "name_tbox";
            this.name_tbox.Size = new System.Drawing.Size(101, 20);
            this.name_tbox.TabIndex = 4;
            // 
            // dgv_evaluation
            // 
            this.dgv_evaluation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_evaluation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_evaluation.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_evaluation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_evaluation.ColumnHeadersHeight = 30;
            this.dgv_evaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_evaluation.EnableHeadersVisualStyles = false;
            this.dgv_evaluation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_evaluation.Location = new System.Drawing.Point(204, 266);
            this.dgv_evaluation.Name = "dgv_evaluation";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_evaluation.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_evaluation.Size = new System.Drawing.Size(494, 126);
            this.dgv_evaluation.TabIndex = 9;
            this.dgv_evaluation.Visible = false;
            this.dgv_evaluation.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_evaluation_CellEnter);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(273, 193);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(348, 42);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // Search_tbox
            // 
            this.Search_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_tbox.Location = new System.Drawing.Point(177, 3);
            this.Search_tbox.Name = "Search_tbox";
            this.Search_tbox.Size = new System.Drawing.Size(168, 27);
            this.Search_tbox.TabIndex = 3;
            this.Search_tbox.Visible = false;
            this.Search_tbox.TextChanged += new System.EventHandler(this.Search_tbox_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.Search.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(83, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(88, 42);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.Visible = false;
            // 
            // Manage_Evaluations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 595);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dgv_evaluation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelleft);
            this.Name = "Manage_Evaluations";
            this.Text = "Manage_Evaluations";
            this.panelleft.ResumeLayout(false);
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evaluation)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private FontAwesome.Sharp.IconButton exit_button;
        private FontAwesome.Sharp.IconButton searchevaluation_button;
        private FontAwesome.Sharp.IconButton updateevaluation_button;
        private FontAwesome.Sharp.IconButton addevaluation_button;
        private FontAwesome.Sharp.IconButton home_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_tbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_evaluation;
        private System.Windows.Forms.ComboBox weightage_cbox;
        private System.Windows.Forms.ComboBox marks_cbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Search_tbox;
        private System.Windows.Forms.Label Search;
    }
}