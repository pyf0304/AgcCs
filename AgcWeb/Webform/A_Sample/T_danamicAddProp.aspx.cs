using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgcMvc3.Webform.A_Sample
{
    public class AppSetings
    {
        private string textID;
        private string textName;
        private Size textSize;

        [DisplayName("文本ID")]
        public string TextID
        {
            get { return textID; }
            set { textID = value; }
        }

        public string TextName
        {
            get { return textName; }
            set { textName = value; }
        }

        public Size TextSize
        {
            get { return textSize; }
            set { textSize = value; }
        }

    }
    public partial class T_danamicAddProp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AppSetings appSeting = new AppSetings();
            PropertyDescriptorCollection appSetingAttributes = TypeDescriptor.GetProperties(appSeting);
            Type displayType = typeof(DisplayNameAttribute);
            FieldInfo fieldInfo = displayType.GetField("_displayName", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.CreateInstance);
            fieldInfo.SetValue(appSetingAttributes["TextID"].Attributes[displayType], "修改后的文本ID");

            //propertyGrid1.SelectedObject = appSeting;
        }
    }
}