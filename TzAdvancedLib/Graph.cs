using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TzAdvancedLib
{
    public class Graph
    {
        public List<Vertex> arrLogVertext = null;// new List<Vertex>();
        //图中所能包含的点上限
        private const int Number = 2000;
        //顶点数组
        private Vertex[] vertexes;
        //邻接矩阵
        public int[,] adjmatrix;
        //统计当前图中有几个点
        int numVerts = 0;

        public Vertex[] Vertexes
        {
            get
            {
                return vertexes;
            }

            set
            {
                vertexes = value;
            }
        }
        /// <summary>
        /// 当前图的顶点数
        /// </summary>
        public int NumVerts
        {
            get
            {
                return numVerts;
            }

            set
            {
                numVerts = value;
            }
        }

        //初始化图
        public Graph()
        {
            arrLogVertext = new List<Vertex>();
            //初始化邻接矩阵和顶点数组
            adjmatrix = new Int32[Number, Number];
            Vertexes = new Vertex[Number];
            //将代表邻接矩阵的表全初始化为0
            for (int i = 0; i < Number; i++)
            {
                for (int j = 0; j < Number; j++)
                {
                    adjmatrix[i, j] = 0;
                }
            }
        }

        //向图中添加节点
        //public void AddVertex(String v)
        //{
        //    Vertexes[NumVerts] = new Vertex(v);
        //    NumVerts++;
        //}
        public void SetAllVertexNoVisited()
        {
            for(int i = 0;i< NumVerts; i++)
            {
                Vertexes[i].IsVisited = false;
            }
        }
        public void AddVertex(string strKeyId, string strName)
        {
            Vertexes[NumVerts] = new Vertex(strKeyId, strName);
            Vertexes[NumVerts].index = NumVerts;
            NumVerts++;
        }
        //向图中添加有向边
        public void AddEdge(int vertex1, int vertex2)
        {
            if (vertex1>= numVerts)
            {
                string strMsg = string.Format("当前图的结点数为:{0}, 所给结点序号:{1}应不大于{0}.", numVerts, vertex1);
                throw new Exception(strMsg);
            }
            if (vertex2 >= numVerts)
            {
                string strMsg = string.Format("当前图的结点数为:{0}, 所给结点序号:{1}应不大于{0}.", numVerts, vertex2);
                throw new Exception(strMsg);
            }
            try
            {

                adjmatrix[vertex1, vertex2] = 1;
                Vertexes[vertex2].PrevVertex = vertexes[vertex1];
                Vertexes[vertex1].NextVertex = vertexes[vertex2];
            }
            catch(Exception objException)
            {
                string strMsg = objException.Message;

            }
            //adjmatrix[vertex2, vertex1] = 1;
        }
        //显示点
        public void DisplayVert(int vertexPosition)
        {            
            Console.WriteLine(vertexes[vertexPosition].VertexName + " ");
        }
        public void DisplayVert(Vertex objVertex)
        {
            arrLogVertext.Add(objVertex);
//            Console.WriteLine(Vertexes[vertexPosition] + " ");
        }
        
        /// <summary>
        /// 寻找图中没有后继节点的点,
        /// 具体表现为邻接矩阵中某一列全为0
        /// 此时返回行号，如果找不到返回-1
        /// </summary>
        /// <returns></returns>
        private int FindNoSuccessor()
        {
            bool isEdge;
            //循环行
            for (int i = 0; i < NumVerts; i++)
            {
                isEdge = false;
                //循环列，有一个1就跳出循环
                for (int j = 0; j < NumVerts; j++)
                {
                    if (adjmatrix[i, j] == 1)
                    {
                        isEdge = true;
                        break;
                    }
                }
                if (!isEdge)
                {
                    return i;
                }
            }
            return -1;

        }


        /// <summary>
        /// 寻找图中没有前驱节点的点,
        /// 具体表现为邻接矩阵中某一列全为0
        /// 此时返回行号，如果找不到返回-1
        /// </summary>
        /// <returns></returns>
        private int FindNoPredecessor()
        {
            bool isEdge;
            List<int> arrRow = new List<int>();
            int intLastCol = -1;
            //循环行
            for (int col = 0; col < NumVerts; col++)
            {
                isEdge = false;
                //循环列，有一个1就跳出循环
                for (int row= 0; row < NumVerts; row++)
                {
                    if (adjmatrix[row, col] == 1)
                    {
                        isEdge = true;
                        arrRow.Add(row);
                        intLastCol = col;
                        break;
                    }
                }
                if (!isEdge)
                {
                    return col;
                }
            }
            return -1;

        }



        
        /// <summary>
        /// 寻找图中某一个环的结点列表
        /// </summary>
        /// <returns></returns>
        private List<Vertex> GetRingLstByBFSBak()
        {
            bool isEdge;
            int intFirstVertHasEdge = -1;//第一个有边的顶点
            //循环行
            for (int i = 0; i < NumVerts; i++)
            {
                isEdge = false;
                //循环列，有一个1就跳出循环
                for (int j = 0; j < NumVerts; j++)
                {
                    if (adjmatrix[i, j] == 1)
                    {
                        isEdge = true;
                        intFirstVertHasEdge = i;
                        break;
                    }
                }

                if (isEdge)
                {
                    break;
                }
            }
            bool bolIsFind = false;
            int intStart = intFirstVertHasEdge;
            List<Vertex> arrResult = new List<Vertex>();
            System.Collections.Queue q = new Queue();
            /*首先访问第一个节点*/
            Vertexes[intStart].IsVisited = true;
            Vertexes[intStart].PrevVertex = null;
            DisplayVert(intStart);
            arrResult.Add(Vertexes[intStart]);
            q.Enqueue(intStart);
            /*第一个节点访问结束*/

            int vert1, vert2;
            while (q.Count > 0)
            {
                /*首先访问同层级第一个节点*/
                vert1 = (int)q.Dequeue();
                var V_vert1 = Vertexes[vert1];

                vert2 = GetAdjUnvisitedVertex(vert1);

                /*结束*/

                while (vert2 != -1)
                {
                    var V_vert2 = Vertexes[vert2];

                    if (vert2 == intStart)
                    {
                        arrResult.Add(Vertexes[vert2]);
                        bolIsFind = true;
                        break;
                    }
                    /*首先访问第二个节点*/
                    V_vert2.IsVisited = true;
                    V_vert2.PrevVertex = Vertexes[vert1];
                    DisplayVert(vert2);
                    arrResult.Add(Vertexes[vert2]);
                    q.Enqueue(vert2);
                    //寻找邻接的
                    vert2 = GetAdjUnvisitedVertex(vert1);

                }
                if (bolIsFind == true)
                {
                    break;
                }
            }
            if (bolIsFind == true)
            {
                //arrResult.RemoveAt(0);
                List<Vertex> arrResult2 = new List<Vertex>();

                Vertex vert_Curr = arrResult[arrResult.Count - 1];
                arrResult2.Add(vert_Curr);
                Vertex vert_prev = vert_Curr.PrevVertex;

                while (vert_prev != null)
                {
                    arrResult2.Add(vert_prev);
                    vert_prev = vert_prev.PrevVertex;
                }


                arrResult2.Reverse();
                //重置所有节点为未访问过
                for (int u = 0; u < NumVerts; u++)
                {
                    Vertexes[u].IsVisited = false;
                }
                return arrResult2;
            }
            else
            {


                //重置所有节点为未访问过
                for (int u = 0; u < NumVerts; u++)
                {
                    Vertexes[u].IsVisited = false;
                }
                return arrResult;

            }

        }
        /// <summary>
        /// 寻找图中某一个环的结点列表
        /// </summary>
        /// <returns></returns>
        private List<Vertex> GetRingLstByDFS()
        {
            bool isEdge;
            int intFirstVertHasEdge = -1;//第一个有边的顶点
            //循环行
            for (int i = 0; i < NumVerts; i++)
            {
                isEdge = false;
                //循环列，有一个1就跳出循环
                for (int j = 0; j < NumVerts; j++)
                {
                    if (adjmatrix[i, j] == 1)
                    {
                        isEdge = true;
                        intFirstVertHasEdge = i;
                        break;
                    }
                }

                if (isEdge)
                {
                    break;
                }
            }

            while (intFirstVertHasEdge < NumVerts)
            {
                bool bolIsFind = false;
                int intStart = intFirstVertHasEdge;
                //声明一个存储临时结果的栈
                List<Vertex> arrResult = new List<Vertex>();
                System.Collections.Stack s = new Stack();
                //先访问第一个节点
                var objFirstVert = vertexes[intStart];
                objFirstVert.iIsVisited = 1;
                DisplayVert(intStart);
                arrResult.Add(objFirstVert);
                s.Push(intStart);

                int intV_End;

                while (s.Count > 0)
                {
                    //获得和当前节点连接的未访问过节点的序号
                    int intCurrVertex = (int)s.Peek();
                    var V_CurrVertex = vertexes[intCurrVertex];

                    intV_End = GetAdjUnvisitedVertexByInt(intCurrVertex);
                    if (intV_End == -1)
                    {
                        s.Pop();
                    }
                    else
                    {
                        var V_End = vertexes[intV_End];
                        V_End.PrevVertex = V_CurrVertex;
                        if (intV_End == intStart)
                        {

                            arrResult.Add(V_End);

                            bolIsFind = true;
                            break;
                        }
                        //标记为已经被访问过
                        if (V_End.iIsVisited == 1) V_End.iIsVisited = 2;
                        else V_End.iIsVisited = 1;
                        DisplayVert(intV_End);
                        arrResult.Add(V_End);
                        s.Push(intV_End);
                    }
                }

                if (bolIsFind == true)
                {
                    //arrResult.RemoveAt(0);
                    List<Vertex> arrResult2 = new List<Vertex>();

                    Vertex vert_Curr = arrResult[arrResult.Count - 1];
                    arrResult2.Add(vert_Curr);
                    Vertex vert_prev = vert_Curr.PrevVertex;

                    while (vert_prev != null)
                    {
                        arrResult2.Add(vert_prev);
                        if (vert_Curr.KeyId == vert_prev.KeyId)
                        {
                            break;
                        }
                        vert_prev = vert_prev.PrevVertex;

                    }


                    arrResult2.Reverse();
                    //重置所有节点为未访问过
                    for (int u = 0; u < NumVerts; u++)
                    {
                        Vertexes[u].iIsVisited = 0;
                    }
                    return arrResult2;
                }
                else
                {

                    //重置所有节点为未访问过
                    for (int u = 0; u < NumVerts; u++)
                    {
                        Vertexes[u].iIsVisited = 0;
                    }
                    intFirstVertHasEdge++;
                    //return arrResult;
                }

                //intFirstVertHasEdge++;
            }
            throw new Exception(string.Format("剩余:{0}个顶点，但没找到环，有错！", NumVerts));

        }



        //删除图中的点
        //需要两个操作，分别从数组中删除点
        //从邻接矩阵中消去被删点的行和列
        private void DelVertex(int vert)
        {
            //保证不越界
            if (vert <= NumVerts - 1)
            {
                //删除节点
                for (int i = vert; i < NumVerts; i++)
                {
                    if (i + 1 > NumVerts - 1) continue;
                    Vertexes[i] = Vertexes[i + 1];
                }
                //删除邻接矩阵的行
                for (int j = vert; j < NumVerts; j++)
                {
                    MoveRow(j, NumVerts);
                }
                //删除邻接矩阵中的列，因为已经删了行，所以少一列
                for (int k = vert; k < NumVerts - 1; k++)
                {
                    MoveCol(k, NumVerts - 1);
                }
                //删除后减少一个
                NumVerts--;
            }
        }
        //辅助方法，移动邻接矩阵中的行
        private void MoveRow(int row, int length)
        {
            //for (int col = row; col < NumVerts; col++)
            //{
            //    if (row + 1 >= NumVerts) continue;
            //    adjmatrix[row, col] = adjmatrix[row + 1, col];
            //}

            for (int col = 0; col < NumVerts; col++)
            {
                //if (row + 1 >= NumVerts) continue;
                adjmatrix[row, col] = adjmatrix[row + 1, col];
            }
        }
        //辅助方法，移动邻接矩阵中的列
        private void MoveCol(int col, int length)
        {
            //for (int row = col; row < NumVerts; row++)
            //{
            //    adjmatrix[row, col] = adjmatrix[row, col + 1];
            //}

            for (int row = 0; row < NumVerts; row++)
            {
                adjmatrix[row, col] = adjmatrix[row, col + 1];
            }

        }
        //拓扑排序
        //找到没有后继节点的节点，删除，加入一个栈，然后输出
        public System.Collections.Stack TopSort()
        {
            int origVerts = NumVerts;
            //存放返回节点的栈
            System.Collections.Stack result = new Stack();
            while (NumVerts > 0)
            {
                //找到第一个没有后继节点的节点
                int currVertex = FindNoSuccessor();
                if (currVertex == -1)
                {
                    Console.WriteLine("图为环路图，不能搞拓扑排序");
                    return null;
                }
                //如果找到，将其加入返回结果栈
                result.Push(Vertexes[currVertex].KeyId);
                //然后删除此节点
                DelVertex(currVertex);
            }
            /*输出排序后的结果*/
            //Console.Write("拓扑排序的顺序为:");
            //while (result.Count > 0)
            //{
            //    Console.Write(result.Pop() + " ");
            //}
            /*输出排序后的结果*/

            return result;
        }
        public List<Vertex> CheckRing()
        {
            if (NumVerts == 0)
            {
                throw new Exception("当前图的顶点数为0，请检查！");
            }
            int origVerts = NumVerts;
            //存放返回节点的栈
            System.Collections.Stack result = new Stack();
            while (NumVerts > 0)
            {
                //找到第一个没有后继节点的节点
                int currVertex = FindNoPredecessor();
                if (currVertex == -1)
                {
                    //Console.WriteLine("图为环路图，不能搞拓扑排序");
                    //return null;
                    List<Vertex> arrResult = GetRingLstByDFS();
                    return arrResult;
                }
        
                try
                {
                    Vertex V_currVertex = vertexes[currVertex];
                    //如果找到，将其加入返回结果栈
                    result.Push(V_currVertex.KeyId);
                    //然后删除此节点
                    DelVertex(currVertex);
                }
                catch(Exception objException)
                {
                    string strMsg = objException.Message;
                }
              
            }
            /*输出排序后的结果*/
            //Console.Write("拓扑排序的顺序为:");
            //while (result.Count > 0)
            //{
            //    Console.Write(result.Pop() + " ");
            //}
            /*输出排序后的结果*/

            return null;

        }
        public Vertex GetVByIndex(int intIndex)
        {
            for (int i = 0; i<numVerts; i++)
            {
                if (vertexes[i].index == intIndex)
                {
                    var objVertex = vertexes[i];
                    return objVertex;
                }
            }
            return null;
        }
        /// <summary>
        /// 获取环列表
        /// </summary>
        /// <returns></returns>
        public List<Vertex> GetRingLst()
        {
            int origVerts = NumVerts;
            //存放返回节点的栈
            System.Collections.Stack result = new Stack();
            while (NumVerts > 0)
            {
                //找到第一个没有后继节点的节点
                int currVertex = FindNoPredecessor();
                if (currVertex == -1)
                {
                    //Console.WriteLine("图为环路图，不能搞拓扑排序");
                    //return null;
                    List<Vertex> arrResult = GetRingLstByDFS();
                    return arrResult;
                }
                var V_currVertex = Vertexes[currVertex];
                //如果找到，将其加入返回结果栈
                result.Push(V_currVertex.KeyId);
                //然后删除此节点
                DelVertex(currVertex);
            }
            /*输出排序后的结果*/
            //Console.Write("拓扑排序的顺序为:");
            //while (result.Count > 0)
            //{
            //    Console.Write(result.Pop() + " ");
            //}
            /*输出排序后的结果*/

            return null;

        }

        /// <summary>
        /// 从邻接矩阵查找给定点第一个相邻且未被访问过的点
        /// </summary>
        /// <param name="v">给定点在邻接矩阵的行</param>
        /// <returns></returns>
        private int GetAdjUnvisitedVertex(int v)
        {
            for (int j = 0; j < NumVerts; j++)
            {
                if (adjmatrix[v, j] == 1 && Vertexes[j].IsVisited == false)
                {
                    return j;
                }
            }
            return -1;
        }
       
        /// <summary>
        /// 从邻接矩阵查找给定点第一个相邻且未被访问过的点
        /// </summary>
        /// <param name="v">给定点在邻接矩阵的行</param>
        /// <returns></returns>
        private int GetAdjUnvisitedVertexByInt(int v)
        {
            for (int j = 0; j < NumVerts; j++)
            {
                if (adjmatrix[v, j] == 1 && Vertexes[j].iIsVisited<2)
                {
                    return j;
                }
            }
            return -1;
        }
        
        /// <summary>
        /// 从邻接矩阵查找给定点第一个相邻且未被访问过的点
        /// </summary>
        /// <param name="v">给定点在邻接矩阵的行</param>
        /// <returns></returns>
        private int GetAdjUnvisitedVertex_Prev(int v)
        {
            for (int j = 0; j < NumVerts; j++)
            {
                if (adjmatrix[j, v] == 1 && Vertexes[j].IsVisited == false)
                {
                    return j;
                }
            }
            return -1;
        }
                
        /// <summary>
        /// 深度优先遍历
        /// </summary>
        /// <returns></returns>
        public List<Vertex> DepthFirstSearch()
        {
            //声明一个存储临时结果的栈
            List<Vertex> arrResult = new List<Vertex>();
            System.Collections.Stack s = new Stack();
            //先访问第一个节点
            Vertexes[0].IsVisited = true;
            DisplayVert(0);
            arrResult.Add(Vertexes[0]);
            s.Push(0);
 
            int v;

            while (s.Count > 0)
            {
                //获得和当前节点连接的未访问过节点的序号
                int intCurrVertex = (int)s.Peek();
                var V_CurrVertex = Vertexes[intCurrVertex];

                v = GetAdjUnvisitedVertex(intCurrVertex);
                if (v == -1)
                {
                    s.Pop();
                }
                else
                {
                    var V_vert2 = Vertexes[v];

                    //标记为已经被访问过
                    V_vert2.IsVisited = true;
      
                    DisplayVert(v);
                    arrResult.Add(V_vert2);
                    s.Push(v);
                }
            }
            //重置所有节点为未访问过
            for (int u = 0; u < NumVerts; u++)
            {
                Vertexes[u].IsVisited = false;
            }
            return arrResult;

        }
      
        /// <summary>
        /// 广度优先遍历
        /// </summary>
        /// <returns></returns>
        public List<Vertex> BreadthFirstSearch()
        {
            List<Vertex> arrResult = new List<Vertex>();
            System.Collections.Queue q = new Queue();
            /*首先访问第一个节点*/
            Vertexes[0].IsVisited = true;
            DisplayVert(0);
            arrResult.Add(Vertexes[0]);
            q.Enqueue(0);
         
            /*第一个节点访问结束*/

            int vert1, vert2;
            while (q.Count > 0)
            {
                /*首先访问同层级第一个节点*/
                vert1 = (int)q.Dequeue();
                vert2 = GetAdjUnvisitedVertex(vert1);
               
                /*结束*/

                while (vert2 != -1)
                {
                    /*首先访问第二个节点*/
                    Vertexes[vert2].IsVisited = true;
                    DisplayVert(vert2);
                    arrResult.Add(Vertexes[vert2]);
                    q.Enqueue(vert2);
                    //寻找邻接的
                    vert2 = GetAdjUnvisitedVertex(vert1);
                  
                }
            }
            //重置所有节点为未访问过
            for (int u = 0; u < NumVerts; u++)
            {
                Vertexes[u].IsVisited = false;
            }
            return arrResult;
        }

        /// <summary>
        /// 用广度优先搜索来查找两个端点之间的路径
        /// </summary>
        /// <param name="intStart">开始端点序号</param>
        /// <param name="intEnd">结束端点序号</param>
        /// <returns></returns>
        public List<Vertex> GetPathByBFS(int intStart, int intEnd)
        {
            List<Vertex> arrResult = new List<Vertex>();
            System.Collections.Queue q = new Queue();
            /*首先访问第一个节点*/
            Vertexes[intStart].IsVisited = true;
            Vertexes[intStart].PrevVertex = null;
            DisplayVert(intStart);
            arrResult.Add(Vertexes[intStart]);
            q.Enqueue(intStart);
            bool bolIsFind = false;
            /*第一个节点访问结束*/

            int vert1, vert2;
            while (q.Count > 0)
            {
                /*首先访问同层级第一个节点*/
                vert1 = (int)q.Dequeue();
                var V_vert1 = Vertexes[vert1];

                vert2 = GetAdjUnvisitedVertex(vert1);
                if (bolIsFind == true) break; 
                /*结束*/

                while (vert2 != -1)
                {
                    /*首先访问第二个节点*/
                    var V_vert2 = Vertexes[vert2];

                    if (vert2 == intEnd)
                    {
                        V_vert2.PrevVertex = V_vert1;
                        arrResult.Add(V_vert2);
                        bolIsFind = true;
                        break;
                    }
                   
                    V_vert2.IsVisited = true;
                    V_vert2.PrevVertex = V_vert1;
                    DisplayVert(vert2);
                    arrResult.Add(V_vert2);
                    q.Enqueue(vert2);
                    //寻找邻接的
                    vert2 = GetAdjUnvisitedVertex(vert1);
            
       
                }
            }
            if (bolIsFind == false)
            {                
                throw new Exception("在起止结点之间未找到通路！");
            }
            List<Vertex> arrResult2 = new List<Vertex>();
       
            Vertex vert_Curr = arrResult[arrResult.Count - 1];
            arrResult2.Add(vert_Curr);
            Vertex vert_prev = vert_Curr.PrevVertex;

            while(vert_prev != null)
            {
                arrResult2.Add(vert_prev);
                vert_prev = vert_prev.PrevVertex;
            }
            //for (int iLast = arrResult.Count-2; iLast>=0; iLast--)
            //{
            //    Vertex a= arrResult[iLast];
            //    if (IsHasEdge(a, vert_Curr))
            //    {
            //        arrResult2.Add(a);
            //        vert_Curr = a;
            //    }

            //}
            arrResult2.Reverse();

            //重置所有节点为未访问过
            for (int u = 0; u < NumVerts; u++)
            {
                Vertexes[u].IsVisited = false;
            }
            return arrResult2;
        }

        public List<Vertex> GetPathByBFS1(int intStart, int intEnd)
        {
            List<Vertex> arrResult = new List<Vertex>();
            System.Collections.Queue q = new Queue();
            /*首先访问第一个节点*/
            Vertexes[intStart].IsVisited = true;
            Vertexes[intStart].PrevVertex = null;
            DisplayVert(intStart);
            arrResult.Add(Vertexes[intStart]);
            q.Enqueue(intStart);
            bool bolIsFind = false;
            /*第一个节点访问结束*/

            int vert1, vert2;
            while (q.Count > 0)
            {
                /*首先访问同层级第一个节点*/
                vert1 = (int)q.Dequeue();
                var V_vert1 = Vertexes[vert1];

                vert2 = GetAdjUnvisitedVertex(vert1);
                if (bolIsFind == true) break;
                /*结束*/

                while (vert2 != -1)
                {
                    /*首先访问第二个节点*/
                    var V_vert2 = Vertexes[vert2];

                    if (vert2 == intEnd)
                    {
                        V_vert2.PrevVertex = V_vert1;
                        arrResult.Add(V_vert2);
                        bolIsFind = true;
                        break;
                    }

                    V_vert2.IsVisited = true;
                    V_vert2.PrevVertex = V_vert1;
                    DisplayVert(vert2);
                    arrResult.Add(V_vert2);
                    q.Enqueue(vert2);
                    //寻找邻接的
                    vert2 = GetAdjUnvisitedVertex(vert1);


                }
            }
            if (bolIsFind == false)
            {
                throw new Exception("在起止结点之间未找到通路！");
            }
            List<Vertex> arrResult2 = new List<Vertex>();

            Vertex vert_Curr = arrResult[arrResult.Count - 1];
            arrResult2.Add(vert_Curr);
            Vertex vert_prev = vert_Curr.PrevVertex;

            while (vert_prev != null)
            {
                arrResult2.Add(vert_prev);
                vert_prev = vert_prev.PrevVertex;
            }
            //for (int iLast = arrResult.Count-2; iLast>=0; iLast--)
            //{
            //    Vertex a= arrResult[iLast];
            //    if (IsHasEdge(a, vert_Curr))
            //    {
            //        arrResult2.Add(a);
            //        vert_Curr = a;
            //    }

            //}
            arrResult2.Reverse();

            //重置所有节点为未访问过
            for (int u = 0; u < NumVerts; u++)
            {
                Vertexes[u].IsVisited = false;
            }
            return arrResult2;
        }


        public List<Vertex> GetPathByBFS_Prev(int intStart, int intEnd)
        {
            List<Vertex> arrResult = new List<Vertex>();
            System.Collections.Queue q = new Queue();
            /*首先访问第一个节点*/
            Vertexes[intStart].IsVisited = true;
            Vertexes[intStart].NextVertex = null;
            DisplayVert(intStart);
            arrResult.Add(Vertexes[intStart]);
            q.Enqueue(intStart);
            bool bolIsFind = false;
            /*第一个节点访问结束*/

            int vert1, vert2;
            while (q.Count > 0)
            {
                /*首先访问同层级第一个节点*/
                vert1 = (int)q.Dequeue();
                var V_vert1 = Vertexes[vert1];

                vert2 = GetAdjUnvisitedVertex_Prev(vert1);
                if (bolIsFind == true) break;
                /*结束*/

                while (vert2 != -1)
                {
                    /*首先访问第二个节点*/
                    var V_vert2 = Vertexes[vert2];

                    if (vert2 == intEnd)
                    {
                        V_vert2.NextVertex = V_vert1;
                        arrResult.Add(V_vert2);
                        bolIsFind = true;
                        break;
                    }

                    V_vert2.IsVisited = true;
                    V_vert2.NextVertex = V_vert1;
                    DisplayVert(vert2);
                    arrResult.Add(V_vert2);
                    q.Enqueue(vert2);
                    //寻找邻接的
                    vert2 = GetAdjUnvisitedVertex_Prev(vert1);


                }
            }
            if (bolIsFind == false)
            {
                throw new Exception("在起止结点之间未找到通路！");
            }
            List<Vertex> arrResult2 = new List<Vertex>();

            Vertex vert_Curr = arrResult[arrResult.Count - 1];
            arrResult2.Add(vert_Curr);
            Vertex vert_next = vert_Curr.NextVertex;

            while (vert_next != null)
            {
                arrResult2.Add(vert_next);
                vert_next = vert_next.PrevVertex;
            }
            //for (int iLast = arrResult.Count-2; iLast>=0; iLast--)
            //{
            //    Vertex a= arrResult[iLast];
            //    if (IsHasEdge(a, vert_Curr))
            //    {
            //        arrResult2.Add(a);
            //        vert_Curr = a;
            //    }

            //}
            arrResult2.Reverse();

            //重置所有节点为未访问过
            for (int u = 0; u < NumVerts; u++)
            {
                Vertexes[u].IsVisited = false;
            }
            return arrResult2;
        }
        /// <summary>
        /// 获取所有的连接子图
        /// </summary>
        /// <returns></returns>
        public List<Vertex> GetAllConnectedSubGroup()
        {
            List<Vertex> arrAllSubGroup = new List<Vertex>();
            int intSubGraphIndex = 1;
            for(int i=0; i<NumVerts; i++)
            {
                if (vertexes[i].IsVisited == false)
                {
                    List<Vertex> arrSubGroup = GetConnectedNodeByBFS(i);
                    arrSubGroup.ForEach(x => x.SubGraph_Index = intSubGraphIndex);
                    intSubGraphIndex++;
                    arrAllSubGroup.AddRange(arrSubGroup);
                }
            }
            for (int u = 0; u < NumVerts; u++)
            {
                Vertexes[u].IsVisited = false;
            }
            return arrAllSubGroup;
        }

        public List<Vertex> GetConnectedNodeByBFS(int intStart)
        {
            List<Vertex> arrResult = new List<Vertex>();
            System.Collections.Queue q = new Queue();
            /*首先访问第一个节点*/
            Vertexes[intStart].IsVisited = true;
            Vertexes[intStart].PrevVertex = null;
            DisplayVert(intStart);
            arrResult.Add(Vertexes[intStart]);
            q.Enqueue(intStart);
            /*第一个节点访问结束*/

            int vert1, vert2;
            while (q.Count > 0)
            {
                /*首先访问同层级第一个节点*/
                vert1 = (int)q.Dequeue();
                var V_vert1 = Vertexes[vert1];

                vert2 = GetAdjUnvisitedVertex(vert1);

                /*结束*/

                while (vert2 != -1)
                {
                    var V_vert2 = Vertexes[vert2];

                    /*首先访问第二个节点*/
                    V_vert2.IsVisited = true;
                    V_vert2.PrevVertex = V_vert1;
                    DisplayVert(vert2);
                    arrResult.Add(V_vert2);
                    q.Enqueue(vert2);
                    //寻找邻接的
                    vert2 = GetAdjUnvisitedVertex(vert1);
                                        
                }
            }
            //arrResult.RemoveAt(0);


            //重置所有节点为未访问过
            //for (int u = 0; u < NumVerts; u++)
            //{
            //    Vertexes[u].IsVisited = false;
            //}
            return arrResult;
        }

        public List<Vertex> GetConnectedNodeByBFS_Prev(int intStart)
        {
            List<Vertex> arrResult = new List<Vertex>();
            System.Collections.Queue q = new Queue();
            /*首先访问第一个节点*/
            Vertexes[intStart].IsVisited = true;
            Vertexes[intStart].Depth = 0;
            Vertexes[intStart].NextVertex = null;
            DisplayVert(intStart);
            arrResult.Add(Vertexes[intStart]);
            q.Enqueue(intStart);
            /*第一个节点访问结束*/

            int vert1, vert2;
            while (q.Count > 0)
            {
                /*首先访问同层级第一个节点*/
                vert1 = (int)q.Dequeue();
                var V_vert1 = Vertexes[vert1];

                vert2 = GetAdjUnvisitedVertex_Prev(vert1);

                /*结束*/

                while (vert2 != -1)
                {
                    var V_vert2 = Vertexes[vert2];

                    /*首先访问第二个节点*/
                    V_vert2.IsVisited = true;
                    V_vert2.NextVertex = V_vert1;
                    V_vert2.Depth = V_vert1.Depth + 1;
                    DisplayVert(vert2);
                    arrResult.Add(V_vert2);
                    q.Enqueue(vert2);
                    //寻找邻接的
                    vert2 = GetAdjUnvisitedVertex_Prev(vert1);

                }
            }
            arrResult.RemoveAt(0);


            //重置所有节点为未访问过
            for (int u = 0; u < NumVerts; u++)
            {
                Vertexes[u].IsVisited = false;
            }
            return arrResult;
        }



        public List<Vertex> GetAllSuccessorDFS(int intVertex)
        {
            //声明一个存储临时结果的栈
            List<Vertex> arrResult = new List<Vertex>();
            System.Collections.Stack s = new Stack();
            //先访问第一个节点
            Vertexes[intVertex].IsVisited = true;
    
            arrResult.Add(Vertexes[intVertex]);
            s.Push(intVertex);

            int v;

            while (s.Count > 0)
            {
                //获得和当前节点连接的未访问过节点的序号
                int intCurrVertex = (int)s.Peek();
                v = GetAdjUnvisitedVertex(intCurrVertex);
                if (v == -1)
                {
                    s.Pop();
                }
                else
                {

                    //标记为已经被访问过
                    Vertexes[v].IsVisited = true;

                    DisplayVert(v);
                    arrResult.Add(Vertexes[v]);
                    s.Push(v);
                }
            }
            //重置所有节点为未访问过
            for (int u = 0; u < NumVerts; u++)
            {
                Vertexes[u].IsVisited = false;
            }
            return arrResult;

        }
        public bool IsHasEdge(Vertex a, Vertex b)
        {
            if (adjmatrix[a.index, b.index] == 1) return true;
            return false;
        }

        /// <summary>
        /// 获取相关后续顶点，用广度优先遍历
        /// </summary>
        /// <returns></returns>
        public List<Vertex> GetAllSuccessorBFS(int intVertex)
        {
            List<Vertex> arrResult = new List<Vertex>();
            System.Collections.Queue q = new Queue();
            /*首先访问第一个节点*/
            Vertexes[intVertex].IsVisited = true;
      
            arrResult.Add(Vertexes[intVertex]);
            q.Enqueue(intVertex);

            /*第一个节点访问结束*/

            int vert1, vert2;
            while (q.Count > 0)
            {
                /*首先访问同层级第一个节点*/
                vert1 = (int)q.Dequeue();
                vert2 = GetAdjUnvisitedVertex(vert1);

                /*结束*/

                while (vert2 != -1)
                {
                    /*首先访问第二个节点*/
                    Vertexes[vert2].IsVisited = true;

                    arrResult.Add(Vertexes[vert2]);
                    q.Enqueue(vert2);
                    //寻找邻接的
                    vert2 = GetAdjUnvisitedVertex(vert1);

                }
            }
            //重置所有节点为未访问过
            for (int u = 0; u < NumVerts; u++)
            {
                Vertexes[u].IsVisited = false;
            }
            return arrResult;
        }

        // 求图中顶点的入度  
        public void inDegree()
        {
            int i, j, inD;
            for (j = 0; j < NumVerts; j++) // 列  
            {
                inD = 0;
                for (i = 0; i < NumVerts; i++) // 行  
                {
                    if (0 != adjmatrix[i, j])
                    {
                        inD++;
                    }
                }
                //cout << "顶点" << j << "的入度为:" << inD << endl;
                Vertexes[j].InDegree = inD;
            }
        }

        // 求图中顶点的出度  
        public void outDegree()
        {
            int i, j, outD;
            for (i = 0; i < NumVerts; i++) // 行  
            {
                outD = 0;
                for (j = 0; j < NumVerts; j++) // 列  
                {
                    if (0 != adjmatrix[i, j])
                    {
                        outD++;
                    }
                }
                Vertexes[i].OutDegree = outD;
                //cout << "顶点" << j << "的出度为:" << outD << endl;
            }
        }

        
            /// <summary>
            /// 计算深度
            /// </summary>
        public void CalcDepth()
        {
            int i, j;
            for (i = 0; i < NumVerts; i++) // 行  
            {             
                for (j = 0; j < NumVerts; j++) // 列  
                {
                    if (0 != adjmatrix[i, j])
                    {
                        if (vertexes[j].Depth <= vertexes[i].Depth + 1)
                        {
                            vertexes[j].Depth = vertexes[i].Depth + 1;
                        }
                    }
                }
             
                //cout << "顶点" << j << "的出度为:" << outD << endl;
            }
        }
    }
}