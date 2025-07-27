using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AGC.Entity;

namespace Agc_CsWin.frm.Test
{
    public partial class frm获取对象属性列表 : Form
    {
        public frm获取对象属性列表()
        {
            InitializeComponent();
        }

        private void btnGetAttrLstOfObject_Click(object sender, EventArgs e)
        {
            StringBuilder sbMsg = new StringBuilder();

            Type type = typeof(clsCodeTypeEN);
            FieldInfo[] arrFields = type.GetFields();
            PropertyInfo[] arrPropertyInfo = type.GetProperties();
            foreach (FieldInfo f in arrFields)
            {
                listBox1.Items.Add(string.Format("\r\n{0}:{1}", f.Name, f.FieldType));
                sbMsg.AppendFormat("\r\n{0}:{1}", f.Name, f.FieldType);
                Console.WriteLine(f.Name);//id name
            }
            foreach (PropertyInfo f in arrPropertyInfo)
            {
                listBox2.Items.Add(string.Format("\r\n{0}:{1}", f.Name, f.PropertyType));
                //sbMsg.AppendFormat("\r\n{0}:{1}", f.Name, f.FieldType);
                Console.WriteLine(f.Name);//id name
            }
            PropertyInfo f2 = arrPropertyInfo.Where(x => x.Name == "CodeTypeId").First();
            if (f2 != null) MessageBox.Show(f2.PropertyType.FullName);
            //            Object strTT = wucTreeView1.GetPropertyValue(objNodeData, "TT");
            //MessageBox.Show(sbMsg.ToString());
        }
    }
}
