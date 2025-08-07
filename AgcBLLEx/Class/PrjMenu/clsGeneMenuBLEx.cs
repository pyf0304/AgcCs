
using AGC.Entity;
using GeneralPlatform.Entity;
using GeneralPlatform4WApi;
using GP4WApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsGeneMenuBLEx
    {
        public static string GetUserMenuHTML2(string strCurrPrjId, string strCurrSelPrjId, string strCurrPrjDataBaseId, string strCurrUserRoleId, string strUserId)
        {

            //System.Data.DataTable objDTUpMenu = null, objDTSubMenu = null;
            //List<clsvRoleMenusEN> arrUpMenu = null, arrSubMenu = null;
            //操作步骤：
            //1、从SESSION取出当前的用户ID(在每个界面上添加一个用户ID的属性，免除每次都必须操作SESSION)。
            //2、从用户表得出当前用户的角色ID。	
            //3、从Web.Config取出当前的工程ID			
            //4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
            //   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
            //       并且按OrderNum排序；
            //   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
            //   获取的表作为DATATABLE(objDT)返回。					
            //5、根据获取的用户菜单列表，组织成HTML菜单串。						
            //6、把菜单HTML菜单串显示到界面上。						
            //7、结束。


            List<string> arrList = new List<string>();
            //clsPrjMenusBLEx objPrjMenuEx = new clsPrjMenusBLEx();
            StringBuilder strCondition = new StringBuilder();
            StringBuilder strHtml = new StringBuilder();		//需要插入的HTML代码
            StringBuilder strMenuSubItem = new StringBuilder();
            //int intMainMenuRow;
            //bool bolIsUseRoleMenu;		//判断当前用户是否用角色菜单。

            //操作步骤CODE实现：

            //4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
            //   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
            //       并且按OrderNum排序；
            //   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
            //   获取的表作为DATATABLE(objDT)返回。	
            //   

            //string strTemp = "true";

            
            List<clsvQxRoleMenusEN> arrPrjUpMenu = null, arrPrjSubMenu = null;

            //获取顶层菜单
            arrPrjUpMenu = clsvQxRoleMenusExWApi.GetUpMenuObjList(strCurrUserRoleId, strCurrPrjId, "0025");
            //获取子菜单
            arrPrjSubMenu = clsvQxRoleMenusExWApi.GetSubMenuObjList(strCurrUserRoleId, strCurrPrjId, "0025");

            //strCondition = new StringBuilder();
            //    strCondition.AppendFormat("RoleId = '{0}'", strCurrUserRoleId);
            //    strCondition.AppendFormat(" and PrjId = '{0}'", strCurrPrjId);
            //    strCondition.Append(" AND UpMenuId = '00000000'");
            //    strCondition.Append(" order by OrderNum");
            //    arrUpMenu = clsvRoleMenusBL.GetvRoleMenusObjList(strCondition.ToString());
                /////获取子菜单
                //strCondition = new StringBuilder();
                //strCondition.AppendFormat("RoleId = '{0}'", strCurrUserRoleId);
                //strCondition.AppendFormat(" and PrjId = '{0}'", strCurrPrjId);
                //strCondition.Append(" AND UpMenuId <> '00000000'");
                //strCondition.Append(" order by OrderNum");

                //arrSubMenu = clsQxRoleMenusWS.GetvRoleMenusObjList(strCondition.ToString());
            //}
            //else
            //{
            //    return "";
            //}
            //5、根据获取的用户菜单列表，组织成HTML菜单串。						
            //intMainMenuRow = 101;
            //int MainRow = 0;
            strHtml.AppendFormat("\n<li class=\"menu-header menu-item\">主菜单</li>\n");
            foreach (clsvQxRoleMenusEN objMainMenuRow in arrPrjUpMenu)
            {

                if (objMainMenuRow.InUse == false) continue;
                strHtml.AppendFormat("\n<li class=\"menu-item\">\n");
                strHtml.AppendFormat("<a href=\"\"><i class=\"icon-font\"></i><span>{0}</span><i class=\"icon-font icon-right\"></i></a>\n", objMainMenuRow.MenuName);
                //strHtml.AppendFormat("<i class=\"icon-font\"></i><span>{0}</span><i class=\"icon-font icon-right\"></i>\n", objMainMenuRow.MenuName);

                strHtml.AppendFormat("<ul  class=\"menu-item-child\" style=\"display: none\">\n");


               
                BindSubMenu(arrPrjSubMenu, objMainMenuRow.MenuId, ref strHtml, strCurrPrjId, strCurrSelPrjId, strCurrPrjDataBaseId, strCurrUserRoleId, strUserId);
                strHtml.Append("</ul>\n");

                strHtml.Append("</li>\n");


               
            }

            //6、把菜单HTML菜单串显示到界面上。						
            return strHtml.ToString();
        }

        private static void BindSubMenu(List<clsvQxRoleMenusEN> arrSubMenu, string strUpMenuId, ref StringBuilder strHtml, string strCurrPrjId, string strCurrSelPrjId, string strCurrPrjDataBaseId, string strCurrUserRoleId, string strUserId)
        {
            int intSubMenuRow = 0;
            foreach (clsvQxRoleMenusEN objSubMenuRow in arrSubMenu)
            {
                if (objSubMenuRow.InUse == false) continue;
                if (strUpMenuId != objSubMenuRow.UpMenuId) continue;
                intSubMenuRow++;
                if (objSubMenuRow.IsLeafNode == true) //叶子结点
                {
                    strHtml.Append("<li>\n");
                    if (objSubMenuRow.LinkFile.Length>4 && objSubMenuRow.LinkFile.Substring(0, 4) == "http")
                    {
                        StringBuilder sbParas = new StringBuilder();
                        sbParas.AppendFormat("UserId={0}&CurrPrjId={1}&CurrUserRoleId={2}&CurrPrjDataBaseId={3}&CurrSelPrjId={4}", 
                            strUserId, strCurrPrjId, strCurrUserRoleId, strCurrPrjDataBaseId, strCurrSelPrjId);
                        if (string.IsNullOrEmpty(objSubMenuRow.qsParameters) == true)
                        {
                            strHtml.AppendFormat("<a href=\"{0}?{2}\"><i class=\"icon-font\"></i><span>{1}</span></a>\n",
                              objSubMenuRow.LinkFile, objSubMenuRow.MenuName, sbParas.ToString());
                        }
                        else
                        {
                            strHtml.AppendFormat("<a href=\"{0}?{2}&{3}\"><i class=\"icon-font\"></i><span>{1}</span></a>\n",
                              objSubMenuRow.LinkFile, objSubMenuRow.MenuName, objSubMenuRow.qsParameters, sbParas.ToString());
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(objSubMenuRow.qsParameters) == true)
                        {
                            strHtml.AppendFormat("<a href=\"../../{0}\"><i class=\"icon-font\"></i><span>{1}</span></a>\n",
                              objSubMenuRow.LinkFile, objSubMenuRow.MenuName);
                        }
                        else
                        {
                            strHtml.AppendFormat("<a href=\"../../{0}?{2}\"><i class=\"icon-font\"></i><span>{1}</span></a>\n",
                              objSubMenuRow.LinkFile, objSubMenuRow.MenuName, objSubMenuRow.qsParameters);
                        }
                    }
                    strHtml.Append("</li>\n");

                }
            } 
        }
    }
}
