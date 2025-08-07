using System;


namespace AGC.BusinessLogicEx
{
	/// <summary>
	/// clsViewPotenceEx 的摘要说明。
	/// </summary>
	public class clsViewPotenceBLEx 
	{
		

		public System.Data.DataTable GetViewPotence1(string strViewId)
		{
			//操作步骤:
			//1、检查关键字是否为空；
			//2、IF (检查该关键字的记录在ViewPotence中是否存在)？
			///   {
			///        从ViewPotence中获取该关键字的记录信息
			///   }
			///   ELSE IF (检查该关键字的记录在ViewInfo中是否存在)
			///   {
			///			从ViewInfo中获取该关键字的记录信息
			///   }
			///   ELSE
			///   {
			///         返回NULL
			///   }

			//1、检查关键字是否为空；
//			if (strViewId  ==  "") return null;		//如果关键字为空就返回退出
//			//2、IF (检查该关键字的记录在ViewPotence中是否存在)？
//			///   {
//
//			///        从ViewPotence中获取该关键字的记录信息
//			///   }
//			if (clsViewPotence.IsExist(strViewId)  ==  true)		//检查该关键字的记录是否存在
//			{
//				ViewId = strViewId;
//				return  base.GetViewPotence();
//			}
//			else if (clsViewInfoBL.IsExist(strViewId)  ==  true)
//			{
//				///   ELSE IF (检查该关键字的记录在ViewInfo中是否存在)
//				///   {
//				///			从ViewInfo中获取该关键字的记录信息
//				///   }
//				return	clsViewInfoBL.GetViewInfo(string.Format("ViewId = '{0}'", strViewId));
//				
//			}
//			///   ELSE
//			///   {
//			///         返回NULL
//			///   }
//
//			
//			if (clsViewInfoBL.IsExist(strViewId)  ==  false)		//检查该关键字的记录是否存在
//			{
//				string ss = "关键字为:" + strViewId + "的不存在!";
//				Response.Write("<script>alert('" + ss + "')</script>");
//				return ;
//			}
//			//3、用提供的关键字初始化一个类对象；
//			clsViewInfoEN objViewInfo = new clsViewInfoEN(strViewId);
//			//4、获取类对象的所有属性；
//			objViewInfo.GetViewInfo();
//			Session.Add("objViewInfo", objViewInfo);
//			//5、把该对象的所有属性显示在界面上,在这里显示在表控件中
//			GetDataFromViewInfoClass(objViewInfo);
return null;
		}
	}
}
