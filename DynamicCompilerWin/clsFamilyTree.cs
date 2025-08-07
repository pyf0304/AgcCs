using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestTree;

namespace DynamicCompilerWin
{
    public class clsFamilyTree : Tree
    {
        private List<clsFamilyTree> Children = null;
        public override object Key { get; set; }
        public clsFamilyTree(clsPerson objPerson)
        {
            this.Key = objPerson;
            Children = new List<clsFamilyTree>();
        }
        public clsFamilyTree AddChild(clsPerson objPerson)
        {
            clsFamilyTree objFamilyTree = new clsFamilyTree(objPerson);
            this.Children.Add(objFamilyTree);

            return objFamilyTree;
        }
        public override bool IsLeaf()
        {
            if (this.Children.Count == 0) return true;
            else return false;
        }
        public override bool IsEmpty()//;// property takes the place of IsEmpty()
        {
            if (this.Key == null) return true;
            else return false;
        }
        public override uint Degree
        {
            get
            {
                return (uint) Children.Count;
            }
        }
        public override Tree this[uint _index]
        {
            get
            {
                return Children[(int)_index];
            }
            set
            {
            }
        }//if I only use get, can I change it later?

    }
    public class FamilyVisitor : IVisitor
    {
       
        #region IVisitor 成员

        public void Visit(object _obj)
        {
            // TODO: 添加 EnumVisitor.Visit 实现
            clsPerson objPerson = _obj as clsPerson;
            Console.WriteLine(objPerson.Name);
//            this.thisQueue.Enqueue(_obj);
        }
        #endregion
    }
}
