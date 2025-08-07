using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGC.FunClass
{

    /// <summary>
    /// 定义delegate对象类型，它有两个参数，第一个参数是事件发送者对象，第二个参数是事件参数类对象
    /// 声明一个:发生在单击登录之后的事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void OnDlEditParaClick(object sender, clsEventArgs4EditPara e);
    ///// <summary>
    ///// 用event关键字定义事件对象，它同时也是一个delegate对象:
    /////       发生在单击登录之后的事件
    ///// </summary>
    //public event OnGvEditTabFieldsClick myGvEditTabFieldsClick;
    /// <summary>
    /// 用于删除的事件参数
    /// </summary>
    public class clsEventArgs4EditPara : EventArgs
    {     
        private string mstrKeyId;
        /// <summary>
        /// 表关键字
        /// </summary>
        public string KeyId
        {
            get { return mstrKeyId; }
            set { mstrKeyId = value; }
        }

    }
}
