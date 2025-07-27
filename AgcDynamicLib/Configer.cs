using System.IO;
using System.Xml;

namespace AgcDynamicLib
{
    public class Configer
    {
        #region   私有成员

        private string version; //版本号
        private string updatetime; //更新时间
        private string isautoupdate; //是否自动更新
        private string funbtnwidth; //功能区按钮宽度
        private string funbtnheight; //功能区按钮高度
        private string expandbtnwidth; //扩展区按钮宽度
        private string expandbtnheight; //扩展区按钮高度

        //private string btnname; //按钮名称
        //private string btntext; //按钮显示文本
        //private string btntype; //按钮类型
        //private string btnleft; //左边距
        //private string btntop; //上边距
        //private string btnreturntype; //返回值类型
        //private string btncode; //调用代码

        private string arrange; //扩展区按钮布局
        private string firstleft; //第一个按钮的左边距
        private string firsttop; //第一个按钮的上边距
        private string horizontal; //水平间距
        private string vertical; //垂直间距

        private string filePath; //文件路径
        private static Configer current; //唯一实例

        #endregion

        /// <summary>
        /// 因为不需要多个实例，所以采用了单例模式，由Current属性来获取唯一的实例
        /// </summary>
        /// <param name="filepath">文件Url</param>
        private Configer(string filepath)
        {
            this.filePath = filepath;
        }

        /// <summary>
        /// 获取当前配置。
        /// </summary>
        /// <param name="filepath">配置文件路径</param>
        /// <returns>返回唯一实例</returns>
        public static Configer Current(string filepath)
        {
            if (current == null)
            {
                current = new Configer(filepath);
            }
            //current = new Configer(filepath);
            return current;
        }

        /// <summary>
        /// 为节点列表的特定属性写入相同的值
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="nodeProperty">属性名</param>
        public string[] GetAssembly(string path, string nodeProperty)
        {
            if (!File.Exists(filePath)) return null;
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            string[] assemblies = null;

            //获取节点列表
            XmlNodeList nodelist = xmlDoc.SelectNodes(path);
            if (nodelist != null)
            {
                //根据节点个数,实例化数组,用于存在引用的dll名称
                assemblies = new string[nodelist.Count];

                for (int i = 0; i < nodelist.Count; i++)//遍历列表
                {
                    var element = (XmlElement)nodelist[i];
                    assemblies[i] = element.GetAttribute(nodeProperty);//装载dll到数组中
                }
            }
            return assemblies;//返回数组
        }

        /// <summary>                                                                         
        /// 获取节点值 
        /// </summary>
        /// <param name="path">节点路径</param>
        /// <param name="nodeProperty">节点名称</param>
        /// <returns>属性值</returns>
        public string GetNodeProperty(string path, string nodeProperty)
        {
            XmlDocument doc = new XmlDocument();
            //加载文件
            doc.Load(filePath);

            XmlElement element = null;

            //节点元素
            element = (XmlElement)(doc.SelectSingleNode(path));

            if (element != null)
            {
                return element.GetAttribute(nodeProperty);
            }
            else
            {
                return " ";
            }
        }

        /// <summary> 
        /// 写入属性值
        /// </summary> 
        /// <param name="path">节点路径</param>
        /// <param   name= "nodeProperty"> 属性名称</param>
        /// <param   name= "nodeValue">属性值</param> 
        public void SetNodeProperty(string path, string nodeProperty, string nodeValue)
        {
            var doc = new XmlDocument();
            //加载文件
            doc.Load(filePath);

            XmlElement element = null;

            //获取版本信息
            element = (XmlElement)(doc.SelectSingleNode(path));

            if (element != null)
            {
                //给某个属性写入值
                element.SetAttribute(nodeProperty, nodeValue);
            }
            doc.Save(filePath);
        }

        /// <summary>
        /// 获取节点值 
        /// </summary>
        /// <param name="path">节点路径</param>
        /// <param name="nodeProperty">节点名称</param>
        /// <returns>属性值</returns>
        public string GetNodeValue(string path, string nodeProperty)
        {
            XmlDocument doc = new XmlDocument();
            //加载文件
            doc.Load(filePath);

            XmlNode node = null;

            //获取节点
            node = (doc.SelectSingleNode(path));

            if (node != null)
            {
                //返回节点内容
                return node.Value;
            }
            else
            {
                return " ";
            }
        }

        /// <summary> 
        /// 写入节点值
        /// </summary> 
        /// <param name="path">节点路径</param>
        /// <param   name= "nodeProperty"> 属性名称</param>
        /// <param   name= "nodeValue">属性值</param> 
        public void SetNodeValue(string path, string nodeProperty, string nodeValue)
        {
            var doc = new XmlDocument();
            //加载文件
            doc.Load(filePath);

            XmlNode node = null;

            //获取节点
            node = (doc.SelectSingleNode(path));

            if (node != null)
            {
                //在节点中写入内容
                node.Value = nodeValue;
            }
            doc.Save(filePath);
        }

        /// <summary>
        /// 为节点列表的特定属性写入相同的值
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="nodeProperty">属性名</param>
        /// <param name="nodeValue">属性值</param>
        public void SetAllNodeProperty(string path, string nodeProperty, string nodeValue)
        {
            if (!File.Exists(filePath)) return;
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            //获取节点列表
            var selectSingleNode = xmlDoc.SelectNodes(path);
            if (selectSingleNode != null)
            {
                XmlNodeList nodelist = selectSingleNode;

                foreach (var VARIABLE in nodelist)//遍历列表
                {
                    XmlElement element = (XmlElement)VARIABLE;
                    //((XmlElement)VARIABLE).Attributes[nodeProperty].Value = nodeValue;
                    element.SetAttribute(nodeProperty, nodeValue);
                }
            }
            xmlDoc.Save(filePath);
        }

        /// <summary>
        /// 创建节点
        /// </summary>
        /// <param name="path">父节点路径</param>
        /// <param name="name">节点名称</param>
        /// <param name="nodeProperties">属性数组</param>
        /// <param name="nodeValues">属性值数组</param>
        public void CreateNode(string path, string name, string[] nodeProperties, string[] nodeValues)
        {
            if (!File.Exists(filePath)) return;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            //获取按钮信息设置
            var selectSingleNode = xmlDoc.SelectSingleNode(path);
            if (selectSingleNode != null)
            {
                XmlElement xmlElement = xmlDoc.CreateElement(name);

                //遍历属性数组，一次添加
                for (int i = 0; i < nodeProperties.Length; i++)
                {
                    //添加属性
                    xmlElement.SetAttribute(nodeProperties[i], nodeValues[i]);
                }
                selectSingleNode.AppendChild(xmlElement);
            }
            xmlDoc.Save(filePath);//保存
        }

        /// <summary>
        /// 移除节点
        /// </summary>
        /// <param name="path">父节点路径</param>
        /// <param name="name">子节点名称</param>
        public void RemoveNode(string path, string name)
        {
            if (!File.Exists(filePath)) return;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            //获取父节点
            var selectSingleNode = xmlDoc.SelectSingleNode(path);
            if (selectSingleNode != null)
            {
                //获取子节点
                var node = selectSingleNode.SelectSingleNode(name);

                if (node != null)
                {
                    selectSingleNode.RemoveChild(node);
                }
            }
            xmlDoc.Save(filePath);//保存
        }
    }
}