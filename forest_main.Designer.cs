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
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.Bay_Complete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Bay_4B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Bay_4A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Bay_3B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Bay_3A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bay_2B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bay2a_dataview = new System.Windows.Forms.DataGridView();
            this.Bay_2A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bay1_dataview = new System.Windows.Forms.DataGridView();
            this.Bay_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.outside_dataview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bay2a_dataview)).BeginInit();
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
            this.treeView1.Size = new System.Drawing.Size(185, 582);
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
            this.Outside.Width = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView6);
            this.panel1.Controls.Add(this.dataGridView5);
            this.panel1.Controls.Add(this.dataGridView4);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.bay2a_dataview);
            this.panel1.Controls.Add(this.bay1_dataview);
            this.panel1.Controls.Add(this.outside_dataview);
            this.panel1.Location = new System.Drawing.Point(216, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 467);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bay_Complete});
            this.dataGridView6.Location = new System.Drawing.Point(784, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.RowHeadersVisible = false;
            this.dataGridView6.RowTemplate.Height = 25;
            this.dataGridView6.Size = new System.Drawing.Size(91, 457);
            this.dataGridView6.TabIndex = 9;
            // 
            // Bay_Complete
            // 
            this.Bay_Complete.HeaderText = "Complete";
            this.Bay_Complete.MinimumWidth = 6;
            this.Bay_Complete.Name = "Bay_Complete";
            this.Bay_Complete.ReadOnly = true;
            this.Bay_Complete.Width = 70;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bay_4B});
            this.dataGridView5.Location = new System.Drawing.Point(687, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.Size = new System.Drawing.Size(91, 457);
            this.dataGridView5.TabIndex = 8;
            // 
            // Bay_4B
            // 
            this.Bay_4B.HeaderText = "Bay 4B";
            this.Bay_4B.MinimumWidth = 6;
            this.Bay_4B.Name = "Bay_4B";
            this.Bay_4B.ReadOnly = true;
            this.Bay_4B.Width = 70;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bay_4A});
            this.dataGridView4.Location = new System.Drawing.Point(590, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(91, 457);
            this.dataGridView4.TabIndex = 7;
            // 
            // Bay_4A
            // 
            this.Bay_4A.HeaderText = "Bay 4A";
            this.Bay_4A.MinimumWidth = 6;
            this.Bay_4A.Name = "Bay_4A";
            this.Bay_4A.ReadOnly = true;
            this.Bay_4A.Width = 70;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bay_3B});
            this.dataGridView3.Location = new System.Drawing.Point(493, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(91, 457);
            this.dataGridView3.TabIndex = 6;
            // 
            // Bay_3B
            // 
            this.Bay_3B.HeaderText = "Bay 3B";
            this.Bay_3B.MinimumWidth = 6;
            this.Bay_3B.Name = "Bay_3B";
            this.Bay_3B.ReadOnly = true;
            this.Bay_3B.Width = 70;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bay_3A});
            this.dataGridView2.Location = new System.Drawing.Point(396, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(91, 457);
            this.dataGridView2.TabIndex = 5;
            // 
            // Bay_3A
            // 
            this.Bay_3A.HeaderText = "Bay 3A";
            this.Bay_3A.MinimumWidth = 6;
            this.Bay_3A.Name = "Bay_3A";
            this.Bay_3A.ReadOnly = true;
            this.Bay_3A.Width = 70;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bay_2B});
            this.dataGridView1.Location = new System.Drawing.Point(299, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(91, 457);
            this.dataGridView1.TabIndex = 4;
            // 
            // Bay_2B
            // 
            this.Bay_2B.HeaderText = "Bay 2B";
            this.Bay_2B.MinimumWidth = 6;
            this.Bay_2B.Name = "Bay_2B";
            this.Bay_2B.ReadOnly = true;
            this.Bay_2B.Width = 70;
            // 
            // bay2a_dataview
            // 
            this.bay2a_dataview.AllowUserToAddRows = false;
            this.bay2a_dataview.AllowUserToDeleteRows = false;
            this.bay2a_dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bay2a_dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bay_2A});
            this.bay2a_dataview.Location = new System.Drawing.Point(202, 3);
            this.bay2a_dataview.Name = "bay2a_dataview";
            this.bay2a_dataview.ReadOnly = true;
            this.bay2a_dataview.RowHeadersVisible = false;
            this.bay2a_dataview.RowTemplate.Height = 25;
            this.bay2a_dataview.Size = new System.Drawing.Size(91, 457);
            this.bay2a_dataview.TabIndex = 3;
            // 
            // Bay_2A
            // 
            this.Bay_2A.HeaderText = "Bay 2A";
            this.Bay_2A.MinimumWidth = 6;
            this.Bay_2A.Name = "Bay_2A";
            this.Bay_2A.ReadOnly = true;
            this.Bay_2A.Width = 70;
            // 
            // bay1_dataview
            // 
            this.bay1_dataview.AllowUserToAddRows = false;
            this.bay1_dataview.AllowUserToDeleteRows = false;
            this.bay1_dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bay1_dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bay_1});
            this.bay1_dataview.Location = new System.Drawing.Point(105, 3);
            this.bay1_dataview.Name = "bay1_dataview";
            this.bay1_dataview.ReadOnly = true;
            this.bay1_dataview.RowHeadersVisible = false;
            this.bay1_dataview.RowTemplate.Height = 25;
            this.bay1_dataview.Size = new System.Drawing.Size(91, 457);
            this.bay1_dataview.TabIndex = 2;
            // 
            // Bay_1
            // 
            this.Bay_1.HeaderText = "Bay 1";
            this.Bay_1.MinimumWidth = 6;
            this.Bay_1.Name = "Bay_1";
            this.Bay_1.ReadOnly = true;
            this.Bay_1.Width = 70;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGreen;
            this.textBox1.Location = new System.Drawing.Point(222, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Orange;
            this.textBox2.Location = new System.Drawing.Point(410, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(20, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightCoral;
            this.textBox3.Location = new System.Drawing.Point(597, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(20, 23);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox4.Location = new System.Drawing.Point(746, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(20, 23);
            this.textBox4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "= Production Handed Off";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "= Production Complete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "= Test Complete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(772, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "= Ready To Ship";
            // 
            // forest_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 606);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "forest_main";
            this.Text = "FOREST";
            ((System.ComponentModel.ISupportInitialize)(this.outside_dataview)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bay2a_dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bay1_dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeView1;
        private DataGridView outside_dataview;
        private Panel panel1;
        private DataGridView bay1_dataview;
        private Label label1;
        private DataGridViewTextBoxColumn Outside;
        private DataGridView dataGridView6;
        private DataGridViewTextBoxColumn Bay_Complete;
        private DataGridView dataGridView5;
        private DataGridViewTextBoxColumn Bay_4B;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn Bay_4A;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Bay_3B;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Bay_3A;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Bay_2B;
        private DataGridView bay2a_dataview;
        private DataGridViewTextBoxColumn Bay_2A;
        private DataGridViewTextBoxColumn Bay_1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}