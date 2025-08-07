using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestTree;

namespace DynamicCompilerWin
{
    public partial class frmTestFamilyTree : Form
    {
        private clsFamilyTree objTreeRoot = null;
        public frmTestFamilyTree()
        {
            InitializeComponent();
        }

        private void btnCreateTree_Click(object sender, EventArgs e)
        {
            clsPerson objPerson_Parent = new clsPerson();
            objPerson_Parent.Name = "P1";
            objPerson_Parent.Relation = "";
            objPerson_Parent.Age = 80;
            objTreeRoot = new clsFamilyTree(objPerson_Parent);
            
            clsPerson objPerson_S1 = new clsPerson();
            objPerson_S1.Name = "S1";
            objPerson_S1.Relation = "Parent";
            objPerson_S1.Age = 60;
            objTreeRoot.AddChild(objPerson_S1);
            //objTreeRoot.
            MessageBox.Show("建立树完成！");
        }

        private void btnGetTree_Click(object sender, EventArgs e)
        {
            objTreeRoot.BreadthFirstTraversal(new FamilyVisitor());
            MessageBox.Show("广搜树完成！");
        }
    }
}
