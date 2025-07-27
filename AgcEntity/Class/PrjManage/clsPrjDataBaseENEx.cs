using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsPrjDataBaseENEx : clsPrjDataBaseEN
    {
        public clsPrjDataBaseENEx(string strPrjDataBaseId)
            : base(strPrjDataBaseId)
        {
        }

        public clsPrjDataBaseENEx(clsPrjDataBaseEN objPrjDataBaseEN)
        {
            this.PrjDataBaseId = objPrjDataBaseEN.PrjDataBaseId; //项目数据库Id
            this.PrjDataBaseName = objPrjDataBaseEN.PrjDataBaseName; //项目数据库名
            this.DataBaseName = objPrjDataBaseEN.DataBaseName; //数据库名
            this.DatabaseOwner = objPrjDataBaseEN.DatabaseOwner; //数据库拥有者
            this.DataBasePwd = objPrjDataBaseEN.DataBasePwd; //数据库的用户口令
            this.DataBaseTypeId = objPrjDataBaseEN.DataBaseTypeId; //数据库类型ID
            this.DataBaseUserId = objPrjDataBaseEN.DataBaseUserId; //数据库的用户ID
            this.IpAddress = objPrjDataBaseEN.IpAddress; //服务器
            this.Sid = objPrjDataBaseEN.Sid; //Sid
            this.TableSpace = objPrjDataBaseEN.TableSpace; //表空间
            this.UseStateId = objPrjDataBaseEN.UseStateId; //使用状态Id
            this.UserId = objPrjDataBaseEN.UserId; //用户ID
            this.UpdDate = objPrjDataBaseEN.UpdDate; //修改日期
            this.Memo = objPrjDataBaseEN.Memo; //说明
        }
        public string ConnectString
        {
            get
            {
                //获得连接字符串
                StringBuilder sbConnectString = new StringBuilder();
                if (this.mstrDataBaseTypeId == "01" || this.mstrDataBaseTypeId == "02")
                {
                    sbConnectString.AppendFormat("server={0};", this.mstrIpAddress);
                    sbConnectString.AppendFormat("database={0};", this.mstrDataBaseName);
                    sbConnectString.AppendFormat("uid={0};", this.mstrDataBaseUserId);
                    sbConnectString.AppendFormat("pwd={0};", this.mstrDataBasePwd);
                }
                else if (this.mstrDataBaseTypeId == "03")
                {
                    if (ConnectWay == 2)
                    {
                        sbConnectString.Append("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)");
                        sbConnectString.AppendFormat("(HOST={0})",
                            this.mstrIpAddress);
                        sbConnectString.Append("(PORT=1521)))");
                        sbConnectString.AppendFormat("(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={0})));",
                            this.mstrSid);
                        sbConnectString.AppendFormat("User Id={0};Password={1};",
                            this.mstrDataBaseUserId,
                            this.mstrDataBasePwd);
                    }
                    else
                    {
                        sbConnectString.AppendFormat("Data Source={0};Persist Security Info=True;", this.mstrSid);
                        sbConnectString.AppendFormat("User Id={0};Password={1};Unicode=True;",
                           this.mstrDataBaseUserId,
                           this.mstrDataBasePwd);
                    }
                }
                else
                {
                    return "";
                }
                return sbConnectString.ToString();

            }
        }
        private int mintConnectWay;

        public int ConnectWay
        {
            get { return mintConnectWay; }
            set { mintConnectWay = value; }
        }
    }
}
