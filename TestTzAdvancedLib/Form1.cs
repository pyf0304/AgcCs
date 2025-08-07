using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TzAdvancedLib;

namespace TestTzAdvancedLib
{
    public partial class Form1 : Form
    {
        //        private string strPrjId = "0116";
        private string strPrjId = "0005";
        private List<clsPrjTabEN> arrPrjTabObjLst = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graph g = new Graph();
            g.AddVertex("A");
            g.AddVertex("B");
            g.AddVertex("C");
            g.AddVertex("D");
            g.AddEdge(0, 1);
            g.AddEdge(1, 2);
            g.AddEdge(2, 3);
            g.AddEdge(3, 4);
            System.Collections.Stack result = g.TopSort();
            StringBuilder sbMsg = new StringBuilder();
            sbMsg.Append("拓扑排序的顺序为:");

            while (result.Count > 0)
            {
                sbMsg.Append(result.Pop() + " ");
            }
            lblResult.Text = sbMsg.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graph g = new Graph();
            g.AddVertex("A");
            g.AddVertex("B");
            g.AddVertex("C");
            g.AddVertex("D");
            g.AddVertex("E");
            g.AddVertex("F");
            g.AddVertex("G");
            g.AddVertex("H");

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 3);
            g.AddEdge(2, 4);
            g.AddEdge(3, 5);
            g.AddEdge(3, 4);
            g.AddEdge(4, 6);
            g.AddEdge(5, 6);
            g.AddEdge(5, 7);

            StringBuilder sbMsg = new StringBuilder();
            Console.WriteLine("\n深度优先遍历");
            sbMsg.Append("\n深度优先遍历");
            List<Vertex> arrResult = g.DepthFirstSearch();
            foreach (Vertex strResult in arrResult)
            {
                sbMsg.AppendFormat("{0}({1}) ", strResult.Data, strResult.Depth);
            }
            Console.WriteLine("\n广度优先遍历");
            sbMsg.Append("\n广度优先遍历");
            List<Vertex> arrResult2 = g.BreadthFirstSearch();
            foreach (Vertex strResult in arrResult2)
            {
                sbMsg.AppendFormat("{0}({1}) ", strResult.Data, strResult.Depth);
            }
            //Console.ReadKey();
            lblResult.Text = sbMsg.ToString();

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Graph g = new Graph();
            InitGraph(g, strPrjId);
            g.CalcDepth();
            StringBuilder sbMsg = new StringBuilder();
        
            sbMsg.Append("\n深度优先遍历");
            listBox1.Items.Add("深度优先遍历");
            List<Vertex> arrResult = g.DepthFirstSearch();
            foreach (Vertex strResult in arrResult)
            {
                string strMsg = string.Format("{0}({1}) ", strResult.Data, strResult.Depth);
                listBox1.Items.Add(strMsg);
            sbMsg.AppendFormat(strMsg);
            }
       
            sbMsg.Append("\n广度优先遍历");
            listBox1.Items.Add("广度优先遍历");
            List<Vertex> arrResult2 = g.BreadthFirstSearch();
            foreach (Vertex strResult in arrResult2)
            {
                string strMsg = string.Format("{0}({1}) ", strResult.Data, strResult.Depth);
                listBox1.Items.Add(strMsg);
                sbMsg.AppendFormat(strMsg);
            }
            //Console.ReadKey();
            lblResult.Text = sbMsg.ToString();

           

        }
        private void DispVertex(List<Vertex> arrResult2)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graph g = new Graph();
            InitGraph(g, strPrjId);
            StringBuilder sbMsg = new StringBuilder();
            //Console.WriteLine("\n深度优先遍历");
            //sbMsg.Append("\n深度优先遍历");
            //List<Vertex> arrResult = g.DepthFirstSearch();
            //foreach (Vertex strResult in arrResult)
            //{
            //    sbMsg.AppendFormat("{0}({1}) ", strResult.Data, strResult.Depth);
            //}
            //Console.WriteLine("\n广度优先遍历");
            //sbMsg.Append("\n广度优先遍历");
            //List<Vertex> arrResult2 = g.BreadthFirstSearch();
            //foreach (Vertex strResult in arrResult2)
            //{
            //    sbMsg.AppendFormat("{0}({1}) ", strResult.Data, strResult.Depth);
            //}
            ////Console.ReadKey();
            //lblResult.Text = sbMsg.ToString();

            System.Collections.Stack result = g.TopSort();
            sbMsg = new StringBuilder();
            sbMsg.Append("拓扑排序的顺序为:");

            while (result.Count > 0)
            {
                sbMsg.Append(result.Pop() + " ");
            }
            lblTopResult.Text = sbMsg.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Graph g = new Graph();

            InitGraph(g, strPrjId);
            g.inDegree();
            g.outDegree();

            StringBuilder sbMsg = new StringBuilder();
            //Console.WriteLine("\n深度优先遍历");
            //sbMsg.Append("\n深度优先遍历");
            //List<Vertex> arrResult = g.DepthFirstSearch();
            foreach (Vertex strResult in g.Vertiexes)
            {
                if (strResult == null) continue;
                string strMsg = string.Format("{0}(入度：{1}，出度：{2}) ",
                    strResult.Data, strResult.InDegree, strResult.OutDegree);
                sbMsg.AppendFormat(strMsg);
                listBox1.Items.Add(strMsg);
            }
           
            lblResult.Text = sbMsg.ToString();

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Graph g = new Graph();
            InitGraph(g, strPrjId);
            g.CalcDepth();

            StringBuilder sbMsg = new StringBuilder();
            //Console.WriteLine("\n深度优先遍历");
            //sbMsg.Append("\n深度优先遍历");
            //List<Vertex> arrResult = g.DepthFirstSearch();
            foreach (Vertex strResult in g.Vertiexes)
            {
                if (strResult == null) continue;
                string strMsg = string.Format("{0}(深度：{1}) ",
                    strResult.Data, strResult.Depth);
                sbMsg.AppendFormat(strMsg);
                listBox1.Items.Add(strMsg);
            }

            lblResult.Text = sbMsg.ToString();
        }
        private void InitGraph0(Graph g)
        {
            g.AddVertex("Root");
            g.AddVertex("Users");
            g.AddVertex("Dept");
            g.AddVertex("Student");
            g.AddVertex("Teacher");

            g.AddVertex("vUsers");
            g.AddVertex("vDept");
            g.AddVertex("vStudent");
            g.AddVertex("AA");
            g.AddVertex("vTeacher");
            g.AddVertex("BB");

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(0, 3);
            g.AddEdge(0, 4);

            g.AddEdge(1, 5);
            g.AddEdge(1, 6);
            g.AddEdge(1, 7);
            g.AddEdge(2, 9);
            g.AddEdge(2, 6);
            g.AddEdge(2, 7);
            g.AddEdge(3, 7);
            g.AddEdge(3, 8);
            g.AddEdge(4, 9);
            g.AddEdge(5, 9);
            g.AddEdge(8, 9);
            g.AddEdge(9, 10);

        }

        public static clsSqlViewEN GetSqlViewObjByTabId(List<clsSqlViewEN> arrSqlViewObjLst, string strTabId)
        {
            foreach (clsSqlViewEN objSqlViewEN in arrSqlViewObjLst)
            {
                if (objSqlViewEN.RelaTabId == strTabId)
                {
                    return objSqlViewEN;
                }
            }
            return null;
        }


        private void InitGraph(Graph g, string strPrjId)
        {
            string strCondition = string.Format("PrjId = '{0}' Order By {1}", 
                strPrjId, clsPrjTabEN.con_TabName);
            string strCondition2 = string.Format("PrjId = '{0}'", strPrjId);

            arrPrjTabObjLst = clsPrjTabBL.GetObjLst(strCondition);
            List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabENObjLst = clsvSqlViewRelaTabBL.GetObjLst(strCondition2);

            //g.AddVertex("Tab-Root");

            foreach (clsPrjTabEN objPrjTabEN in arrPrjTabObjLst)
            {
                if (objPrjTabEN.TabStateId != "01") continue;
                string strText = string.Format("{0}-{1}", 
                    objPrjTabEN.TabId, objPrjTabEN.TabName);
                g.AddVertex(strText);
            }
            foreach(clsvSqlViewRelaTabEN objvSqlViewRelaTabEN in arrvSqlViewRelaTabENObjLst)
            {
                int intStart = clsPrjTabBLEx.GetIndexByTabId(objvSqlViewRelaTabEN.TabId, arrPrjTabObjLst);
                int intEnd = clsPrjTabBLEx.GetIndexByTabId(objvSqlViewRelaTabEN.RelaTabId4SqlView, arrPrjTabObjLst);
                if (intStart != -1 && intEnd != -1)
                {
                    g.AddEdge(intStart, intEnd);
                }
            }
            //g.AddVertex("Root");
            //g.AddVertex("Users");
            //g.AddVertex("Dept");
            //g.AddVertex("Student");
            //g.AddVertex("Teacher");

            //g.AddVertex("vUsers");
            //g.AddVertex("vDept");
            //g.AddVertex("vStudent");
            //g.AddVertex("AA");
            //g.AddVertex("vTeacher");
            //g.AddVertex("BB");

            //g.AddEdge(0, 1);
            //g.AddEdge(0, 2);
            //g.AddEdge(0, 3);
            //g.AddEdge(0, 4);

            //g.AddEdge(1, 5);
            //g.AddEdge(1, 6);
            //g.AddEdge(1, 7);
            //g.AddEdge(2, 9);
            //g.AddEdge(2, 6);
            //g.AddEdge(2, 7);
            //g.AddEdge(3, 7);
            //g.AddEdge(3, 8);
            //g.AddEdge(4, 9);
            //g.AddEdge(5, 9);
            //g.AddEdge(8, 9);
            //g.AddEdge(9, 10);

        }
   
        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Graph g = new Graph();
            InitGraph(g, strPrjId);
            g.CalcDepth();
            StringBuilder sbMsg = new StringBuilder();

            sbMsg.Append("\n深度优先遍历");
            listBox1.Items.Add("深度优先遍历");
            string strTabId = cboPrjTab.SelectedValue.ToString();
            int intIndex = clsPrjTabBLEx.GetIndexByTabId(strTabId, arrPrjTabObjLst);
            List<Vertex> arrResult = g.GetAllSuccessorBFS(intIndex);
            foreach (Vertex strResult in arrResult)
            {
                string strMsg = string.Format("{0}({1}) ", strResult.Data, strResult.Depth);
                listBox1.Items.Add(strMsg);
                sbMsg.AppendFormat(strMsg);
            }

            sbMsg.Append("\n广度优先遍历");
            listBox1.Items.Add("广度优先遍历");
            List<Vertex> arrResult2 = g.GetAllSuccessorDFS(intIndex);
            foreach (Vertex strResult in arrResult2)
            {
                string strMsg = string.Format("{0}({1}) ", strResult.Data, strResult.Depth);
                listBox1.Items.Add(strMsg);
                sbMsg.AppendFormat(strMsg);
            }
            //Console.ReadKey();
            lblResult.Text = sbMsg.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsPrjTabBLEx.BindCbo_TabIdEx(cboPrjTab, strPrjId);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string strTabId = cboPrjTab.SelectedValue.ToString();
            //arrPrjTabObjLst = clsPrjTabBLEx.GetPrjTabObjLstByPrjId_CacheEx(strPrjId);
            //int intIndex = clsPrjTabBLEx.GetIndexByTabId(strTabId, arrPrjTabObjLst);
            List<string> arrTabId = clsPrjTabBLEx.GetRelaSubNodeByTabId(strTabId, strPrjId);
            foreach(string strRelaTabId in arrTabId)
            {
                clsPrjTabEN objPrjTab = clsPrjTabBLEx.GetObjByTabId_CacheEx(strRelaTabId, strPrjId);
                string strMsg = string.Format("{0}({1}) ", 
                    objPrjTab.TabName, objPrjTab.TabId);
                listBox1.Items.Add(strMsg);
            }
        }
    }
}
