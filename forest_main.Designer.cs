namespace FOREST
{
    partial class forest_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Handoff");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sales", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forest_main));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.outside_dataview = new System.Windows.Forms.DataGridView();
            this.Outside = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bay1_dataview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.outside_dataview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bay1_dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "sales_handoff";
            treeNode1.Text = "Handoff";
            treeNode2.Name = "Sales";
            treeNode2.Text = "Sales";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(121, 582);
            this.treeView1.TabIndex = 0;
            // 
            // outside_dataview
            // 
            this.outside_dataview.AllowUserToAddRows = false;
            this.outside_dataview.AllowUserToDeleteRows = false;
            this.outside_dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outside_dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Outside});
            this.outside_dataview.Location = new System.Drawing.Point(8, 3);
            this.outside_dataview.Name = "outside_dataview";
            this.outside_dataview.ReadOnly = true;
            this.outside_dataview.RowHeadersVisible = false;
            this.outside_dataview.RowTemplate.Height = 25;
            this.outside_dataview.Size = new System.Drawing.Size(91, 457);
            this.outside_dataview.TabIndex = 1;
            this.outside_dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Outside
            // 
            this.Outside.HeaderText = "Outside";
            this.Outside.MinimumWidth = 6;
            this.Outside.Name = "Outside";
            this.Outside.ReadOnly = true;
            this.Outside.Width = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bay1_dataview);
            this.panel1.Controls.Add(this.outside_dataview);
            this.panel1.Location = new System.Drawing.Point(139, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 467);
            this.panel1.TabIndex = 2;
            // 
            // bay1_dataview
            // 
            this.bay1_dataview.AllowUserToAddRows = false;
            this.bay1_dataview.AllowUserToDeleteRows = false;
            this.bay1_dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bay1_dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.bay1_dataview.Location = new System.Drawing.Point(105, 3);
            this.bay1_dataview.Name = "bay1_dataview";
            this.bay1_dataview.ReadOnly = true;
            this.bay1_dataview.RowHeadersVisible = false;
            this.bay1_dataview.RowTemplate.Height = 25;
            this.bay1_dataview.Size = new System.Drawing.Size(91, 457);
            this.bay1_dataview.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Bay 1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(682, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Job Location";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // forest_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "forest_main";
            this.Text = "FOREST";
            ((System.ComponentModel.ISupportInitialize)(this.outside_dataview)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bay1_dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeView1;
        private DataGridView outside_dataview;
        private DataGridViewTextBoxColumn Outside;
        private Panel panel1;
        private DataGridView bay1_dataview;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Label label1;
    }
}