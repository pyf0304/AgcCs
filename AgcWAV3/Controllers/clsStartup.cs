using GeneralPlatform.Entity;

namespace AgcWA
{
    public class clsStartup
    {
        public static bool SetConnStr4GP()
        {

            clsQxPrjMenuSetEN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxPrjMenusEN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxPrjMenusV2EN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxPrjPotenceV2EN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxProjectsEN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxRoleMenusEN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxRoleMenusV2EN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxRolePotenceV2EN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxRolesV2EN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxUserIdentityEN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxUserLoginNameEN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxUserRoleRelationV2EN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxRolesEN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxUsersEN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxUsersV2EN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;
            clsQxUserStateEN._ConnectString = AGC.Entity.clsSysParaEN.spConnectString_GP;

            return true;
        }
        public static List<string> GetTabName4GP()
        {
            var arrTabName = new List<string>();
            arrTabName.Add("A");
            return arrTabName;
        }
    }
}
