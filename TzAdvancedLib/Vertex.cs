using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TzAdvancedLib
{
    public class Vertex
    {
        //        public string Data;
        public string KeyId;
        public int index;
        private int mintDepth;//深度
        private int mintInDegree;//入度
        private int mintOutDegree;//出度
        public Vertex PrevVertex;
        public Vertex NextVertex;
        /// <summary>
        /// 子图序号
        /// </summary>
        public int SubGraph_Index { get; set; }
        public bool IsVisited;
        public int iIsVisited;

        /// <summary>
        /// 顶点的深度
        /// </summary>
        public int Depth
        {
            get
            {
                return mintDepth;
            }

            set
            {
                mintDepth = value;
            }
        }
        /// <summary>
        /// 顶占入度
        /// </summary>
        public int InDegree
        {
            get
            {
                return mintInDegree;
            }

            set
            {
                mintInDegree = value;
            }
        }

        /// <summary>
        /// 顶点出度
        /// </summary>
        public int OutDegree
        {
            get
            {
                return mintOutDegree;
            }

            set
            {
                mintOutDegree = value;
            }
        }
        public string VertexName { get; set; }

        //public Vertex(string Vertexdata)
        //{
        //    Data = Vertexdata;
        //}
        public Vertex(string strKeyId)
        {
            KeyId = strKeyId;
        }
        public Vertex(string strKeyId, string strName)
        {
            KeyId = strKeyId;
            this.VertexName = strName;
        }
    }
}
