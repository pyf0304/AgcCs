using System;
using System.Collections.Generic;
using System.Collections;

namespace DynamicCompilerWin
{

    /// <summary>
    /// Tree 的摘要说明。
    /// when traverse, traversaltype cant be changed,or throw a exception
    /// 支持枚举、比较、深度复制
    /// </summary>
    public abstract class Tree : IEnumerable, IComparable
    {
        public Tree()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        protected Queue keyqueue = new Queue();//仅仅用于枚举时存放数据，不参与Equals实现中的比较
        //protected Queue<Tree> arrChildNode = null;
        protected TraversalType traversaltype = TraversalType.Breadth;// choose a traversal type,and DepthFirst is default

        //protected uint degree=0;//degree of the tree, init it as 0

        //protected uint height=0;//height of the tree, init it as 0



        //枚举不同的遍历类型

        public enum TraversalType
        {
            Breadth = 1,//广度遍历
            PreDepth = 2,//前序遍历
            InDepth = 3,//中序遍历
            PostDepth = 4//后序遍历
        };

        //public virtual abstract object Key{}
        public abstract Tree this[uint _index] { get; set; }//if I only use get, can I change it later?

        public abstract object Key { get; set; }

        public abstract uint Degree { get; }

        //public abstract uint Height{get;}

        public void SetTraversalType(TraversalType _type) { traversaltype = _type; }//set a traversal a type, if its not set manually, DepthFirst will be chosen in default

        public abstract bool IsEmpty();// property takes the place of IsEmpty()

        public abstract bool IsLeaf();



        //Only Visit, neednt queue

            /// <summary>
            /// 深度搜索
            /// </summary>
            /// <param name="_vis"></param>
        public virtual void DepthFirstTraversal(IPrePostVisitor _vis)//middle depthfirst traversal
        {
            //通过_vis使用不同的访问者来进行前序、后序、中序遍历
            if (!IsEmpty())
            {
                _vis.PreVisit(this.Key);
                if (this.Degree >= 1)
                {
                    if (this.Degree >= 2)
                    {
                        for (uint i = 0; i < (this.Degree - 1); i++)//
                        {
                            this[i].DepthFirstTraversal(_vis);//recursive call
                            //_vis.Visit(this.Key);
                        }
                    }
                    this[this.Degree - 1].DepthFirstTraversal(_vis);
                }
                _vis.PostVisit(this.Key);
            }
        }

        public virtual void BreadthFirstTraversal(IVisitor _vis)//breadth first traversal
        {
            Queue<object> tmpQueue = new Queue<object>();//used to help BreadthFirstTraversal
            //this.keyqueue=new Queue();//store keys
            if (!this.IsEmpty())
                tmpQueue.Enqueue(this);//enqueue the root node at first
            while (tmpQueue.Count != 0)//until the number of the queue is zero
            {
                Tree headTree = (Tree)tmpQueue.Dequeue();
                //this.keyqueue.Enqueue(headTree.Key);
                _vis.Visit(headTree.Key);
                for (uint i = 0; i < headTree.Degree; i++)
                {
                    Tree childTree = headTree[i];
                    if (!childTree.IsEmpty())
                        tmpQueue.Enqueue(childTree);
                }
            }
        }
        //------------------------------------------------end------------------------------------

        //内部成员类 用于提供不同遍历类型的访问者

        public class PreOrder : IPrePostVisitor
        {
            private IVisitor visitor;
            public PreOrder(IVisitor _vis) { visitor = _vis; }
            #region IPrePostVisitor 成员
            public void PreVisit(object _obj)
            {
                // TODO: 添加 PreOrder.PreVisit 实现
                this.visitor.Visit(_obj);
            }

            public void Visit(object _obj)
            {
                // TODO: 添加 PreOrder.Visit 实现
            }

            public void PostVisit(object _obj)
            {
                // TODO: 添加 PreOrder.PostVisitor 实现
            }

            #endregion
        }

        public class InOrder : IPrePostVisitor
        {
            private IVisitor visitor;
            public InOrder(IVisitor _vis)
            {
                visitor = _vis;
            }
            #region IPrePostVisitor 成员

            public void PreVisit(object _obj)
            {
                // TODO: 添加 InOrder.PreVisit 实现
            }

            public void Visit(object _obj)
            {
                // TODO: 添加 InOrder.Visit 实现
                this.visitor.Visit(_obj);
            }

            public void PostVisit(object _obj)
            {
                // TODO: 添加 InOrder.PostVisitor 实现
            }
            #endregion
        }

        public class PostOrder : IPrePostVisitor
        {
            private IVisitor visitor;
            public PostOrder(IVisitor _vis)
            {
                visitor = _vis;
            }

            #region IPrePostVisitor 成员

            public void PreVisit(object _obj)
            {
                // TODO: 添加 PostOrder.PreVisit 实现
            }

            public void Visit(object _obj)
            {
                // TODO: 添加 PostOrder.Visit 实现
            }

            public void PostVisit(object _obj)
            {
                // TODO: 添加 PostOrder.PostVisitor 实现
                this.visitor.Visit(_obj);
            }
            #endregion
        }

        protected class EnumVisitor : IVisitor
        {
            Queue thisQueue;
            public EnumVisitor(Queue _que)
            {
                this.thisQueue = _que;
            }
            #region IVisitor 成员

            public void Visit(object _obj)
            {
                // TODO: 添加 EnumVisitor.Visit 实现
                this.thisQueue.Enqueue(_obj);
            }
            #endregion
        }


        #region IEnumerable 成员
        public IEnumerator GetEnumerator()
        {
            // TODO: 添加 Tree.GetEnumerator 实现
            EnumVisitor vis = new EnumVisitor(this.keyqueue);
            switch (this.traversaltype)
            {
                case TraversalType.Breadth:
                    BreadthFirstTraversal(vis);
                    break;
                case TraversalType.PreDepth:
                    PreOrder preVis = new PreOrder(vis);
                    DepthFirstTraversal(preVis);
                    break;
                case TraversalType.InDepth:
                    InOrder inVis = new InOrder(vis);
                    DepthFirstTraversal(inVis);
                    break;
                case TraversalType.PostDepth:
                    PostOrder postVis = new PostOrder(vis);
                    DepthFirstTraversal(postVis);
                    break;
                default:
                    Console.WriteLine("WARNING:please set a travel type first!--void SetTraversalType(TraversalType _type) ");

                    //throw new Exception("WARNING:please set a travel type first!");//if not set a type, a exception will happen
                    break;
            }
            return this.keyqueue.GetEnumerator();
        }

        #endregion

        //overwrite Object.Equals() --- reference type realization

        public override bool Equals(object _obj)
        {

            if (_obj == null)

                return false;//因为this不可能为null

            if (!(this.GetType() == _obj.GetType()))

                return false;//类型不相等也不相等

            Tree tmpObj = (Tree)_obj;

            //比较引用成员

            if (!Object.Equals(this.Key, tmpObj.Key))

                return false;
            //比较值类型成员

            if (!this.Degree.Equals(tmpObj.Degree))

                return false;

            //if( !this.Height.Equals(tmpObj.Height) )

            //return false;
            return true;
        }

        //在此重载 ==,!= 后， 在以后继承的类中不必实现了

        public static bool operator ==(Tree _treeA, Tree _treeB)
        {
            return Object.Equals(_treeA, _treeB);
        }

        public static bool operator !=(Tree _treeA, Tree _treeB)
        {
            return !(_treeA == _treeB);
        }

        #region IComparable 成员
        public virtual int CompareTo(object obj)
        {
            // TODO: 添加 Tree.CompareTo 实现
            return 0;
        }
        #endregion

    }
}

