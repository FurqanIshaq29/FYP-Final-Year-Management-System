
namespace Mid_Project
{
    partial class AssignProject_Group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignProject_Group));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelleft = new System.Windows.Forms.Panel();
            this.exit_button = new FontAwesome.Sharp.IconButton();
            this.assignproject_button = new FontAwesome.Sharp.IconButton();
            this.home_button = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_project = new System.Windows.Forms.DataGridView();
            this.dgv_groups = new System.Windows.Forms.DataGridView();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_groups)).BeginInit();
            this.paneltitle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelleft.Controls.Add(this.exit_button);
            this.panelleft.Controls.Add(this.assignproject_button);
            this.panelleft.Controls.Add(this.home_button);
            this.panelleft.Controls.Add(this.panel2);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(181, 610);
            this.panelleft.TabIndex = 6;
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
            this.exit_button.Location = new System.Drawing.Point(0, 567);
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
            // assignproject_button
            // 
            this.assignproject_button.FlatAppearance.BorderSize = 0;
            this.assignproject_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignproject_button.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignproject_button.ForeColor = System.Drawing.Color.White;
            this.assignproject_button.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.assignproject_button.IconColor = System.Drawing.Color.White;
            this.assignproject_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.assignproject_button.IconSize = 30;
            this.assignproject_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assignproject_button.Location = new System.Drawing.Point(0, 288);
            this.assignproject_button.Name = "assignproject_button";
            this.assignproject_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.assignproject_button.Size = new System.Drawing.Size(153, 85);
            this.assignproject_button.TabIndex = 3;
            this.assignproject_button.Text = "Assign Projects to Groups";
            this.assignproject_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assignproject_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.assignproject_button.UseVisualStyleBackColor = true;
            this.assignproject_button.Click += new System.EventHandler(this.assignproject_button_Click_1);
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
            this.home_button.Size = new System.Drawing.Size(153, 47);
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
            // dgv_project
            // 
            this.dgv_project.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_project.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_project.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_project.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_project.ColumnHeadersHeight = 30;
            this.dgv_project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_project.EnableHeadersVisualStyles = false;
            this.dgv_project.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_project.Location = new System.Drawing.Point(248, 154);
            this.dgv_project.Name = "dgv_project";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_project.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_project.Size = new System.Drawing.Size(427, 126);
            this.dgv_project.TabIndex = 9;
            this.dgv_project.Visible = false;
            this.dgv_project.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_project_CellContentClick);
            this.dgv_project.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_project_CellEnter);
            // 
            // dgv_groups
            // 
            this.dgv_groups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_groups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_groups.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_groups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_groups.ColumnHeadersHeight = 30;
            this.dgv_groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_groups.EnableHeadersVisualStyles = false;
            this.dgv_groups.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_groups.Location = new System.Drawing.Point(248, 376);
            this.dgv_groups.Name = "dgv_groups";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_groups.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_groups.Size = new System.Drawing.Size(427, 126);
            this.dgv_groups.TabIndex = 10;
            this.dgv_groups.Visible = false;
            this.dgv_groups.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_groups_CellEnter);
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.White;
            this.paneltitle.Controls.Add(this.label1);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(181, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(619, 54);
            this.paneltitle.TabIndex = 11;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(187, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 49);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "Projects:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(187, 307);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 49);
            this.tableLayoutPanel2.TabIndex = 13;
            this.tableLayoutPanel2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "Groups:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(487, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "ASSIGN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssignProject_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.dgv_groups);
            this.Controls.Add(this.dgv_project);
            this.Controls.Add(this.panelleft);
            this.Name = "AssignProject_Group";
            this.Text = "AssignProject_Group";
            this.panelleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_groups)).EndInit();
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private FontAwesome.Sharp.IconButton exit_button;
        private FontAwesome.Sharp.IconButton assignproject_button;
        private FontAwesome.Sharp.IconButton home_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_project;
        private System.Windows.Forms.DataGridView dgv_groups;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}