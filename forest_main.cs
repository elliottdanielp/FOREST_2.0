namespace FOREST
{
    public partial class forest_main : Form
    {
        public forest_main()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TreeView1.SelectedNode.Text.ToString() == "Handoff") 
            {             
                var myForm = new Sales_Handoff();
                myForm.Show();
            }
        }
    }
}