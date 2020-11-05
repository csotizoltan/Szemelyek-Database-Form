namespace Szemelyek_Database_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoad = new System.Windows.Forms.Button();
            this.listBoxDb = new System.Windows.Forms.ListBox();
            this.listViewDb = new System.Windows.Forms.ListView();
            this.btnBoxViewSelectedItem = new System.Windows.Forms.Button();
            this.dataGridViewDb = new System.Windows.Forms.DataGridView();
            this.btnListViewSelectedItem = new System.Windows.Forms.Button();
            this.lblListBox = new System.Windows.Forms.Label();
            this.lblListView = new System.Windows.Forms.Label();
            this.lblDataGridView = new System.Windows.Forms.Label();
            this.labelView = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewlStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripListBoxSelectedItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2ListViewSelectedItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLoad.Font = new System.Drawing.Font("Verdana", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoad.Location = new System.Drawing.Point(12, 400);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(732, 38);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "B e t ö l t";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // listBoxDb
            // 
            this.listBoxDb.FormattingEnabled = true;
            this.listBoxDb.ItemHeight = 16;
            this.listBoxDb.Location = new System.Drawing.Point(12, 105);
            this.listBoxDb.Name = "listBoxDb";
            this.listBoxDb.Size = new System.Drawing.Size(157, 148);
            this.listBoxDb.TabIndex = 1;
            // 
            // listViewDb
            // 
            this.listViewDb.HideSelection = false;
            this.listViewDb.Location = new System.Drawing.Point(201, 105);
            this.listViewDb.Name = "listViewDb";
            this.listViewDb.Size = new System.Drawing.Size(143, 148);
            this.listViewDb.TabIndex = 2;
            this.listViewDb.UseCompatibleStateImageBehavior = false;
            // 
            // btnBoxViewSelectedItem
            // 
            this.btnBoxViewSelectedItem.Location = new System.Drawing.Point(12, 282);
            this.btnBoxViewSelectedItem.Name = "btnBoxViewSelectedItem";
            this.btnBoxViewSelectedItem.Size = new System.Drawing.Size(115, 38);
            this.btnBoxViewSelectedItem.TabIndex = 3;
            this.btnBoxViewSelectedItem.Text = "SelectedItem";
            this.btnBoxViewSelectedItem.UseVisualStyleBackColor = true;
            this.btnBoxViewSelectedItem.Click += new System.EventHandler(this.btnListBoxViewSelectedItem_Click);
            // 
            // dataGridViewDb
            // 
            this.dataGridViewDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDb.Location = new System.Drawing.Point(404, 105);
            this.dataGridViewDb.Name = "dataGridViewDb";
            this.dataGridViewDb.RowHeadersWidth = 53;
            this.dataGridViewDb.RowTemplate.Height = 24;
            this.dataGridViewDb.Size = new System.Drawing.Size(340, 177);
            this.dataGridViewDb.TabIndex = 4;
            // 
            // btnListViewSelectedItem
            // 
            this.btnListViewSelectedItem.Location = new System.Drawing.Point(201, 282);
            this.btnListViewSelectedItem.Name = "btnListViewSelectedItem";
            this.btnListViewSelectedItem.Size = new System.Drawing.Size(115, 38);
            this.btnListViewSelectedItem.TabIndex = 5;
            this.btnListViewSelectedItem.Text = "SelectedItem";
            this.btnListViewSelectedItem.UseVisualStyleBackColor = true;
            this.btnListViewSelectedItem.Click += new System.EventHandler(this.btnListViewViewSelectedItem_Click);
            // 
            // lblListBox
            // 
            this.lblListBox.AutoSize = true;
            this.lblListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblListBox.Location = new System.Drawing.Point(12, 67);
            this.lblListBox.Name = "lblListBox";
            this.lblListBox.Size = new System.Drawing.Size(54, 16);
            this.lblListBox.TabIndex = 6;
            this.lblListBox.Text = "List Box";
            // 
            // lblListView
            // 
            this.lblListView.AutoSize = true;
            this.lblListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblListView.Location = new System.Drawing.Point(198, 67);
            this.lblListView.Name = "lblListView";
            this.lblListView.Size = new System.Drawing.Size(60, 16);
            this.lblListView.TabIndex = 7;
            this.lblListView.Text = "List View";
            // 
            // lblDataGridView
            // 
            this.lblDataGridView.AutoSize = true;
            this.lblDataGridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDataGridView.Location = new System.Drawing.Point(404, 67);
            this.lblDataGridView.Name = "lblDataGridView";
            this.lblDataGridView.Size = new System.Drawing.Size(89, 16);
            this.lblDataGridView.TabIndex = 8;
            this.lblDataGridView.Text = "dataGridView";
            // 
            // labelView
            // 
            this.labelView.AutoSize = true;
            this.labelView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelView.Location = new System.Drawing.Point(794, 67);
            this.labelView.Name = "labelView";
            this.labelView.Size = new System.Drawing.Size(42, 16);
            this.labelView.TabIndex = 9;
            this.labelView.Text = "Label";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAbout.Font = new System.Drawing.Font("Verdana", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAbout.Location = new System.Drawing.Point(791, 400);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(166, 38);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "Progarmról...";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ViewlStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.openToolStripMenuItem.Text = "&Open Databse";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ViewlStripMenuItem1
            // 
            this.ViewlStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripListBoxSelectedItem,
            this.toolStripMenuItem2ListViewSelectedItem});
            this.ViewlStripMenuItem1.Name = "ViewlStripMenuItem1";
            this.ViewlStripMenuItem1.Size = new System.Drawing.Size(55, 25);
            this.ViewlStripMenuItem1.Text = "View";
            // 
            // toolStripListBoxSelectedItem
            // 
            this.toolStripListBoxSelectedItem.Name = "toolStripListBoxSelectedItem";
            this.toolStripListBoxSelectedItem.Size = new System.Drawing.Size(240, 30);
            this.toolStripListBoxSelectedItem.Text = "ListBox SelectedItem";
            this.toolStripListBoxSelectedItem.Click += new System.EventHandler(this.toolStripListBoxSelectedItem_Click);
            // 
            // toolStripMenuItem2ListViewSelectedItem
            // 
            this.toolStripMenuItem2ListViewSelectedItem.Name = "toolStripMenuItem2ListViewSelectedItem";
            this.toolStripMenuItem2ListViewSelectedItem.Size = new System.Drawing.Size(240, 30);
            this.toolStripMenuItem2ListViewSelectedItem.Text = "ListView SelectedItem";
            this.toolStripMenuItem2ListViewSelectedItem.Click += new System.EventHandler(this.toolStripListViewSelectedItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(142, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 30);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.labelView);
            this.Controls.Add(this.lblDataGridView);
            this.Controls.Add(this.lblListView);
            this.Controls.Add(this.lblListBox);
            this.Controls.Add(this.btnListViewSelectedItem);
            this.Controls.Add(this.dataGridViewDb);
            this.Controls.Add(this.btnBoxViewSelectedItem);
            this.Controls.Add(this.listViewDb);
            this.Controls.Add(this.listBoxDb);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Személyek Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox listBoxDb;
        private System.Windows.Forms.ListView listViewDb;
        private System.Windows.Forms.Button btnBoxViewSelectedItem;
        private System.Windows.Forms.DataGridView dataGridViewDb;
        private System.Windows.Forms.Button btnListViewSelectedItem;
        private System.Windows.Forms.Label lblListBox;
        private System.Windows.Forms.Label lblListView;
        private System.Windows.Forms.Label lblDataGridView;
        private System.Windows.Forms.Label labelView;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewlStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripListBoxSelectedItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2ListViewSelectedItem;
    }
}

