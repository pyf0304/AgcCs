using AGC.BusinessLogic;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.file;
using com.taishsoft.sql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace AGC.BusinessLogicEx
{
  public class clsSqlDataSynBLEx
  {


    /// <summary>
    /// 导入Sql表,For数据同步,从本系统(代码生成系统)中。
    /// 姓名:潘以锋
    /// 日期:2014-06-10
    /// </summary>
    /// <param name = "strPrjId">工程Id</param>
    /// <param name = "strTabTypeId">表类型Id</param>
    /// <param name = "strUserId">操作用户Id</param>
    /// <returns>是否成功</returns>
    public static int ImportSqlTab4Synch(string strPrjId, string strTabTypeId, string strUserId)
    {
      int intRecCount = 0;
      string strCondition = string.Format("PrjId = '{0}' And SqlDsTypeId = '{1}' And TabStateId = '01' And TabTypeId = '{2}'",
        strPrjId, clsSQLDSTypeENEx.SQLTAB, strTabTypeId);
      string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
      List<clsPrjTabEN> arrPrjTabObjLst = clsPrjTabBL.GetObjLst(strCondition);
      foreach (clsPrjTabEN objPrjTabEN in arrPrjTabObjLst)
      {
        string strCondition4Tab = string.Format("PrjId = '{0}' And TabId = '{1}'", strPrjId, objPrjTabEN.TabId);
        clsSqlDataSynEN objSqlDataSynEN = null;
        bool bolIsExist = false;
        if (clsSqlDataSynBL.IsExistRecord(strCondition4Tab) == true)
        {
          objSqlDataSynEN = clsSqlDataSynBL.GetFirstObj_S(strCondition4Tab);
          bolIsExist = true;
        }
        else
        {
          bolIsExist = false;
          objSqlDataSynEN = new clsSqlDataSynEN();
          objSqlDataSynEN.TabId = objPrjTabEN.TabId;
        }
        objSqlDataSynEN.TabName = objPrjTabEN.TabName;
        objSqlDataSynEN.TabCnName = objPrjTabEN.TabCnName;
        objSqlDataSynEN.TabEnName = objPrjTabEN.TabEnName;
        objSqlDataSynEN.SqlCommandTypeId = "01";
        objSqlDataSynEN.SqlCommandText = string.Format("Select * from {0} Where 1 = 1", objPrjTabEN.TabName);
        objSqlDataSynEN.TextResouce = "无";
        objSqlDataSynEN.TextResourceTypeId = "00";
        objSqlDataSynEN.RecExclusiveWayId = "0001";
        string strPrimaryTypeId = clsPrjTabFldBLEx.GetPrimaryTypeIdByTabId(objPrjTabEN.TabId);
        objSqlDataSynEN.PrimaryTypeId = strPrimaryTypeId;

        objSqlDataSynEN.PrjId = strPrjId;

        objSqlDataSynEN.UpdDate = strCurrDate14;
        objSqlDataSynEN.UpdUserId = strUserId;
        if (bolIsExist == true)
        {
          //clsSqlDataSynBL.UpdateBySql2(objSqlDataSynEN);
        }
        else
        {
          clsSqlDataSynBL.AddNewRecordBySql2(objSqlDataSynEN);
          intRecCount++;
        }
      }
      return intRecCount;
    }

    /// <summary>
    /// 从Sql服务器中导入Sql视图
    /// </summary>
    /// <param name = "strPrjId">工程Id</param>
    /// <param name = "strUserId">操作用户Id</param>
    /// <param name = "strPrjDataBaseId">工程数据库Id</param>
    /// <returns>是否成功</returns>
    public static bool ImportSqlDataFromSqlServer(string strPrjId, string strTabId, string strUserId, string strPrjDataBaseId)
    {
      string strCondition = string.Format("PrjId = '{0}' And TabId = '{1}'", strPrjId, strTabId);
      string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
      clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
      
      List<clsSqlDataSynEN> arrSqlDataSynObjLst = clsSqlDataSynBL.GetObjLst(strCondition);
      foreach (clsSqlDataSynEN objSqlDataSynEN in arrSqlDataSynObjLst)
      {

        if (string.IsNullOrEmpty(objSqlDataSynEN.SqlCommandText) == true)
        {
          objSqlDataSynEN.SqlData = "Sql命令内容为空,不能获取数据!";
          objSqlDataSynEN.AnalysisDate = clsDateTime.getTodayDateTimeStr(1);
          clsSqlDataSynBL.UpdateBySql2(objSqlDataSynEN);
          continue;
        }
        try
        {

          clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);
          DataTable objDT = objSQL.GetDataTable(objSqlDataSynEN.SqlCommandText);
          DataSet objDS = new DataSet();
          objDS.Tables.Add(objDT);

          string strXmlFile = clsSysParaEN.TempFileFolder + "\\AAA.XML";
          strXmlFile = strXmlFile.Replace("\\\\", "\\");
          objDS.WriteXml(strXmlFile, XmlWriteMode.WriteSchema);
          Encoding MyEncoding = Encoding.UTF8;
          string strXML = clsFile.GetContentFromTextFile(strXmlFile, MyEncoding);
          objSqlDataSynEN.SqlData = strXML;
          objSqlDataSynEN.SqlDataRecNum = objDT.Rows.Count;
          objSqlDataSynEN.AnalysisDate = clsDateTime.getTodayDateTimeStr(1);
          objSqlDataSynEN.ErrMsg = "";
          clsSqlDataSynBL.UpdateBySql2(objSqlDataSynEN);
          continue;
        }
        catch (Exception objException)
        {
          objSqlDataSynEN.ErrMsg = "Sql命令出错:" + objException.Message;
          objSqlDataSynEN.SqlData = "Sql命令出错:" + objException.Message;
          objSqlDataSynEN.AnalysisDate = clsDateTime.getTodayDateTimeStr(1);
          objSqlDataSynEN.UpdDate = strCurrDate14;
          objSqlDataSynEN.UpdUserId = strUserId;
          objSqlDataSynEN.TextResouce = objPrjDataBase.IpAddress + ": " + objPrjDataBase.DataBaseName;
          objSqlDataSynEN.TextResourceTypeId = "01";
          clsSqlDataSynBL.UpdateBySql2(objSqlDataSynEN);
         
          continue;
        }


      }


      return true;
    }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strTabId"></param>
        /// <returns></returns>
    public static DataTable GetDataTableBySqlData(string strTabId)
    {
      clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN(strTabId);
      clsSqlDataSynBL.GetSqlDataSyn(ref objSqlDataSynEN);
      string xmlText = objSqlDataSynEN.SqlData;// "<xml>my data</xml>";
      StringReader strReader = new StringReader(xmlText);
      XmlTextReader reader = new XmlTextReader(strReader);

      DataSet objDS = new DataSet();
      objDS.ReadXml(reader);
      DataTable objDT = objDS.Tables[0];
      return objDT;
    }

    ///导入字段到表FieldTab中
    public static int ImportFldToPrjField(string strTabId_T)
    {



      clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId_T);

      string strTabName_T = objPrjTabEN.TabEnName;
      string strTabName_S = objPrjTabEN.TabName;

      int intLoadFldNum = 0;




      List<clsPrjTabFldEN> arrTabFldObjList = null;
      string strCondition = string.Format("TabId = '{0}'", strTabId_T);
      arrTabFldObjList = clsPrjTabFldBL.GetObjLst(strCondition);
      if (arrTabFldObjList.Count == 0)
      {
        return 0;
      }
      else
      {
        int intIndex = 1;

        foreach (clsPrjTabFldEN objPrjTabFldEN in arrTabFldObjList)
        {

          clsTabFieldRelaBLEx.CreateTabFldRelation(objPrjTabFldEN, intIndex);

          intIndex++;
          intLoadFldNum++;
        }

      }

      return intLoadFldNum;
    }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="strPrjDataBaseId"></param>
        /// <param name="strPrjId"></param>
        /// <param name="strTabId"></param>
        /// <param name="bolIsUpdateSamIdentityRecord"></param>
    public static void ImportTab_comm02(string strPrjDataBaseId, string strPrjId, string strTabId, bool bolIsUpdateSamIdentityRecord)
    {
      string strToday = clsDateTime.getTodayStr(0);
      string strConnectString_T = "";
      string strDataBaseTypeId_T = "";
      StringBuilder sbInsertIntoCode = null;
      string[] sstrFieldCode = null;
      string strFieldListCode = null;

      string[] sstrValuesCode = null;
      string strValuesListCode = null;

      //选择的工作单
      //string strResult = "";
      int intRecIndex = 0;  //记录遍历变量
      int intRecCount; //记录数
      string strFldName_T = "";  //目标表字段名
      string strFldName_S = ""; //源表字段名
      string strFldValue_S = "";   //源表字段值
      string strIdentityFldValue = "";
      string strKeyValue_S = "";//源表行的关键字值
      string strKeyValue_T = "";//目标表行的关键字值

      string strExclusiveCondition = ""; //排他条件
      Hashtable hashFld_Value = null;
      StringBuilder sbMessage = null;
      bool bolIsExistSameIdentityValue = false;
      StringBuilder sbSQL_S = new StringBuilder();
      DataTable objDT_S = null;
      ArrayList arrFieldCodes = null;
      ArrayList arrValuesCodes = null;
      string strKeyFldType_S = "";
      bool bolIsNeedQuote4KeyFld_S;  //针对关键字字段类型是否需要引号
      clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
  
      strDataBaseTypeId_T = objPrjDataBase.DataBaseTypeId;
      clsSpecSQLforSql objSQL_T = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);
      strConnectString_T = objSQL_T.ConnectionString;
      clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN(strTabId);
      clsvSqlDataSynBL.GetvSqlDataSyn(ref objvSqlDataSynEN);


      string strTabName_T = objvSqlDataSynEN.TabName;
      clsvPrjTabFldEN objvPrjTabFld4KeyFld = clsPrjTabFldBLEx.GetKeyvPrjTabFldENByTabId(strTabId);
      string strKeyWord_T = objvPrjTabFld4KeyFld.FldName;
      clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objvPrjTabFld4KeyFld.DataTypeId);

      strKeyFldType_S = objDataTypeAbbrEN.DataTypeName;
      bolIsNeedQuote4KeyFld_S = clsSqlObject.IsNeedQuotes(strKeyFldType_S);


      //步骤:
      //1、检查关键字的字段长度
      //2、获取需要导入的记录数
      //3、获取该表相关字段对象列表
      //4、组织源表记录的SQL串
      //5、获取源表记录的记录集(DataTable)

      //1、检查关键字的字段长度
      int intKeyFldLength_T = objvPrjTabFld4KeyFld.FldLength; ;
      if (intKeyFldLength_T == 0)
      {
        throw new Exception("关键字字段长度为0,出错!请检查。");
      }

      //2、获取需要导入的记录数
      StringBuilder sbCondition = new StringBuilder();
      //计算条件
      sbCondition.Append(" 1 = 1 ");

      //获取记录数


      intRecIndex = 0;
      //初始化导入状态


      //4、组织源表记录的SQL串
      //5、获取源表记录的记录集(DataTable)


      objDT_S = GetDataTableBySqlData(strTabId);
      intRecCount = objDT_S.Rows.Count;
      List<clsvTabFieldRelaEN> arrTabFldRelaObjLst = null;  //所有字段对象列表
      arrTabFldRelaObjLst = clsvTabFieldRelaBL.GetObjLst("TabId = '" + strTabId + "' order by SequenceNumber");
      if (arrTabFldRelaObjLst.Count == 0)
      {
        clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
        string strMsg = string.Format("表:{0}({1})的同步字段数为0,请先添加同步字段。", objPrjTabEN.TabName, objPrjTabEN.TabId);
        throw new Exception(strMsg);
      }

      //遍历源表所有记录------------------------------
      foreach (DataRow objRow_S in objDT_S.Rows)
      {
        hashFld_Value = new Hashtable();

        //获取目标表的数据行
        //DataRow objDR_T = GetNewDataRow_T(mstrConnectString_T);
        arrFieldCodes = new ArrayList();
        arrValuesCodes = new ArrayList();
        foreach (clsvTabFieldRelaEN objvTabFieldRela in arrTabFldRelaObjLst)
        {
          //操作步骤:
          //1、获取目标字段名
          //2、获取源表字段名
          //3、处理源表字段名为空的情况
          //   3.1 如果有缺省值就处理
          //   3.2 如果没有缺省值就继续
          //4、记录源表记录的关键字值
          //5、把源表字段值转换成相应的目标表字段值。
          //   根据3种情况:
          //   5.1 关键字
          //   5.2 非关键字,但需要转换
          //   5.3 不是关键字,但不需要转换
          //6、计算排他记录的条件串。
          //     判断在目标表是否存在该关键字值的记录
          //7、检查排他性条件串是否为空,不能为空。
          //8、检查排他性条件串相关记录数是否唯一,如果不唯一修改记录就发生问题。
          //9、设置目标表的导入日期
          //10、根据目标表中是否存在排他条件串记录来决定插入与修改
          //   10.1 如果不存在就插入
          //     10.1.1 组织插入记录SQL串
          //     10.1.2 记录插入到目标表中
          //11、标记源表记录的导入标记与导入日期


          //1、获取目标字段名
          strFldName_T = objvTabFieldRela.FldName;
          //2、获取源表字段名
          strFldName_S = objvTabFieldRela.SqlFldName;
          //4、记录源表记录的关键字值
          //     如果源字段名就是关键字,就记录下关键字的值
          if (strFldName_S.Equals(strKeyWord_T, StringComparison.InvariantCultureIgnoreCase) == true)
          {
            strKeyValue_S = objRow_S[strFldName_S].ToString().Trim();
          }
          //检查是否是主键
          if (objvTabFieldRela.IsTabPrimary == true) //如果是主键字段
          {
           
//00	非关键字	
//01	关键字	一般的字符型关键字
//02	identity	主要针对整型、长整型类型的字段
//03	字符型自增主键	NULL
//04	一般整型主键	NULL
            if (objvSqlDataSynEN.PrimaryTypeId == "02") //Identity主键,mptPrimaryType = TZPrimaryType.IdentityPrimaryKey)
            {
              //strKeyValue_T = "";

              //strFldValue_S = objRow_S[strFldName_S].ToString().Trim();
              //strKeyValue_T = strFldValue_S;
              //arrFieldCodes.Add(strFldName_T);
              //arrValuesCodes.Add(strFldValue_S);
              
            }
            else if (objvSqlDataSynEN.PrimaryTypeId == "03") //字符型自增主键,mptPrimaryType = TZPrimaryType.StrIncrementPrimaryKey)
            {
              string strMaxStrId = "";

              strMaxStrId = objSQL_T.GetMaxStrId(strTabName_T,
                 strKeyWord_T, intKeyFldLength_T, "");

              if (string.IsNullOrEmpty(strMaxStrId) == true)
              {
                sbMessage = new StringBuilder();
                sbMessage.AppendFormat("获取字符型自增主键的值为空!表:{0}", objvSqlDataSynEN.TabName);
                throw new Exception(sbMessage.ToString());
              }
              strKeyValue_T = strMaxStrId;
              arrFieldCodes.Add(strFldName_T);
              arrValuesCodes.Add("'" + strMaxStrId + "'");

              hashFld_Value.Add(strFldName_T, strKeyValue_T);
            }
            else if (objvSqlDataSynEN.PrimaryTypeId == "01")//一般字符型主键,mptPrimaryType = TZPrimaryType.OrdinaryPrimaryKey)
            {
              strFldValue_S = objRow_S[strFldName_S].ToString().Trim();
              strKeyValue_T = strFldValue_S;
              arrFieldCodes.Add(strFldName_T);
              arrValuesCodes.Add("'" + strFldValue_S + "'");

              hashFld_Value.Add(strFldName_T, strFldValue_S);
            }
            else if (objvSqlDataSynEN.PrimaryTypeId == "04")//一般整型主键
            {
              strFldValue_S = objRow_S[strFldName_S].ToString().Trim();
              strKeyValue_T = strFldValue_S;
              arrFieldCodes.Add(strFldName_T);
              arrValuesCodes.Add(strFldValue_S);

              hashFld_Value.Add(strFldName_T, strFldValue_S);
            }
            continue;
          }

          //3、处理源表字段名为空的情况
          if (strFldName_S == "")//如果目标字段无对应的源字段就继续,不处理该字段
          {
            //   3.2 如果没有缺省值就继续
            if (string.IsNullOrEmpty(objvTabFieldRela.DefaultValue) == true)
            {
              continue;
            }
            else
            {
              //   3.1 如果有缺省值就处理
              strFldValue_S = objvTabFieldRela.DefaultValue;
              if (objvTabFieldRela.IsNeedTrans)
              {
                //根据转换方式去转换值
                strFldValue_S = TransValueByTransWay(strFldValue_S, objvTabFieldRela.TransWayId);
              }
              //objDR_T[strFldName_T] = strFldValue_S;
              arrFieldCodes.Add(strFldName_T);
              if (objvTabFieldRela.DataTypeName == "bit")
              {
                strFldValue_S = strFldValue_S == "False" ? "0" : "1";
              }
              if (clsSqlObject.IsNeedQuotes(objvTabFieldRela.DataTypeName) == true)
              {
                strFldValue_S = TransValueStrForSql(strFldValue_S);
                arrValuesCodes.Add("'" + strFldValue_S + "'");
              }
              else
              {
                arrValuesCodes.Add(strFldValue_S);
              }
              hashFld_Value.Add(strFldName_T, strFldValue_S);
              continue;

            }
          }

          //5、把源表字段值转换成相应的目标表字段值。
          //   根据3种情况:
          //   5.1 关键字
          //   5.2 非关键字,但需要转换
          //   5.3 不是关键字,但不需要转换

          //   5.2 非关键字,但需要转换
          if (objvTabFieldRela.IsNeedTrans == true)  //如果该字段需要转换
          {
            if (objvTabFieldRela.TransWayId == "01")//标准日期(10)转换成8位日期串
            {
              strFldValue_S = objRow_S[strFldName_S].ToString().Trim();
              if (clsDateTime.IsDate(strFldValue_S) == true)
              {
                DateTime objDateTime = new DateTime();
                objDateTime = DateTime.Parse(strFldValue_S);
                string strFldValue_S2 = clsDateTime.ChangeDateToDate8(objDateTime);
                //objDR_T[strFldName_T] = strFldValue_S2;
                arrFieldCodes.Add(strFldName_T);
                if (clsSqlObject.IsNeedQuotes(objvTabFieldRela.DataTypeName) == true)
                {
                  arrValuesCodes.Add("'" + strFldValue_S2 + "'");
                }
                else
                {
                  arrValuesCodes.Add(strFldValue_S2);
                }
                hashFld_Value.Add(strFldName_T, strFldValue_S2);

              }
            }
            else if (objvTabFieldRela.TransWayId == "02")//8位日期串转换成标准日期(10)
            {
              strFldValue_S = objRow_S[strFldName_S].ToString().Trim();
              if (clsDateTime.IsDate(strFldValue_S) == true)
              {
                string strFldValue_S2 = clsDateTime.ChangeDateToDate10(strFldName_S);
                //objDR_T[strFldName_T] = strFldValue_S2;
                arrFieldCodes.Add(strFldName_T);
                if (clsSqlObject.IsNeedQuotes(objvTabFieldRela.DataTypeName) == true)
                {
                  arrValuesCodes.Add("'" + strFldValue_S2 + "'");

                }
                else
                {
                  arrValuesCodes.Add(strFldValue_S2);
                }
                hashFld_Value.Add(strFldName_T, strFldValue_S2);

              }
            }
            else if (objvTabFieldRela.TransWayId == "04")//8位日期串转换成标准日期(10)
            {
              strFldValue_S = objRow_S[strFldName_S].ToString().Trim();
              //objDR_T[strFldName_T] = strFldValue_S2;
              arrFieldCodes.Add(strFldName_T);
              arrValuesCodes.Add("'" + strFldValue_S + "'");
              hashFld_Value.Add(strFldName_T, strFldValue_S);


            }
            else
            {


              string strId_Value = "";
              int intFieldCount = strFldName_S.Split(",".ToCharArray()).GetLength(0);
              if (intFieldCount > 1)
              {
                string[] sstrFldName = strFldName_S.Split(",".ToCharArray());
                string[] sstrFldValue = new string[intFieldCount];
                for (int i = 0; i < intFieldCount; i++)
                {
                  sstrFldValue[i] = objRow_S[sstrFldName[i]].ToString().Trim();
                }
                strFldValue_S = string.Join(",", sstrFldValue);
                strId_Value = TransFldValueForMultiField(objvTabFieldRela.TransTabName,
                    objvTabFieldRela.TransInFldName, objvTabFieldRela.TransOutFldName, strFldValue_S, strConnectString_T); // clsDepartmentInfoEx.GetId_ClgByClgId(strFldValue_S);                
              }
              else
              {
                strFldValue_S = objRow_S[strFldName_S].ToString().Trim();
                strId_Value = TransFldValue(objvTabFieldRela.TransTabName,
                    objvTabFieldRela.TransInFldName, objvTabFieldRela.TransOutFldName, strFldValue_S, strConnectString_T); // clsDepartmentInfoEx.GetId_ClgByClgId(strFldValue_S);

              }
              //strFldValue_S = objRow_S[strFldName_S].ToString().Trim();
              //string strId_Value = TransFldValue(objvTabFieldRela.TransTabName,
              //  objvTabFieldRela.TransInFldName, objvTabFieldRela.TransOutFldName, strFldValue_S); // clsDepartmentInfoEx.GetId_ClgByClgId(strFldValue_S);
              //如果转换失败,并且转换失败值不为空,就把转换失败值作为转换结果值。
              if (string.IsNullOrEmpty(strId_Value) == true && string.IsNullOrEmpty(objvTabFieldRela.TransMissingValue) == false)
              {
                strId_Value = objvTabFieldRela.TransMissingValue;
              }
              if (string.IsNullOrEmpty(strId_Value) == true)
              {
                sbMessage = new StringBuilder();
                sbMessage.AppendFormat("<{0}>: = '{1}'在数据表<{2}>中不存在,请先添加该记录!",
                  objvTabFieldRela.TransInFldName, strFldValue_S, objvTabFieldRela.TransTabName);
                throw new Exception(sbMessage.ToString());
                //return;
              }
              arrFieldCodes.Add(strFldName_T);
              if (clsSqlObject.IsNeedQuotes(objvTabFieldRela.DataTypeName) == true)
              {
                strId_Value = TransValueStrForSql(strId_Value);
                if (objvTabFieldRela.DataTypeName == "bit")
                {
                  strId_Value = (strId_Value == "True" ? "1" : "0");
                }
                arrValuesCodes.Add("'" + strId_Value + "'");
              }
              else
              {
                arrValuesCodes.Add(strId_Value);
              }
              hashFld_Value.Add(strFldName_T, strId_Value);
            }
            continue;

          }
          //   5.3 不是关键字,但不需要转换
          //object obj = objRow_S[strFldName_S];
          if (objRow_S[strFldName_S] == System.DBNull.Value)
          {
            strFldValue_S = objRow_S[strFldName_S].ToString().Trim();

            hashFld_Value.Add(strFldName_T, strFldValue_S);
          }
          else
          {
            //检查字段长度
            //{
            //}
            strFldValue_S = objRow_S[strFldName_S].ToString().Trim();
            //char[] cc = strFldValue_S.ToCharArray();//ascii = 160为全角空格
            strFldValue_S = clsString.ToDBC_S160(strFldValue_S);

            arrFieldCodes.Add(strFldName_T);
            if (objvTabFieldRela.DataTypeName == "bit")
            {
              strFldValue_S = strFldValue_S == "False" ? "0" : "1";
            }
            if (clsSqlObject.IsNeedQuotes(objvTabFieldRela.DataTypeName) == true)
            {
              strFldValue_S = TransValueStrForSql(strFldValue_S);
              arrValuesCodes.Add("'" + strFldValue_S + "'");
            }
            else
            {
              arrValuesCodes.Add(strFldValue_S);
            }
            //检查字段值长度
            if (objvTabFieldRela.DataTypeName == "varchar" || objvTabFieldRela.DataTypeName == "char")
            {
              CheckFldValueLength(strFldValue_S, objvTabFieldRela.FldLength ?? 0, strFldName_S, strFldName_T);
            }
            hashFld_Value.Add(strFldName_T, strFldValue_S);
          }
        }
          //获取是否存在相同标记记录
        bolIsExistSameIdentityValue = GetIsExistSameRecord(arrTabFldRelaObjLst, objvSqlDataSynEN, strKeyWord_T,
          strKeyValue_T, hashFld_Value, objSQL_T, ref strExclusiveCondition);
        //6、计算排他记录的条件串。
        //     判断在目标表是否存在该关键字值的记录
        //       根据排他关键字方式来设置条件串
        //9、设置目标表的导入日期
        


        //10、根据目标表中是否存在排他条件串记录来决定插入与修改
        //   10.1 如果不存在就插入
        //     10.1.1 组织插入记录SQL串
        //     10.1.2 记录插入到目标表中
        //   10.2 如果存在就修改
        //     10.2.1 组织插入记录SQL串
        //     10.2.2 记录插入到目标表中
        if (bolIsExistSameIdentityValue == false)
        {
          //     10.1.1 组织插入记录SQL串
          sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
          strFieldListCode = string.Join(",", sstrFieldCode);

          sstrValuesCode = (string[])(arrValuesCodes.ToArray(System.Type.GetType("System.String")));
          strValuesListCode = string.Join(",", sstrValuesCode);

          sbInsertIntoCode = new StringBuilder();
          sbInsertIntoCode.AppendFormat("Insert into {0}", strTabName_T);
          sbInsertIntoCode.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
          //     10.1.2 记录插入到目标表中
           
          //Clipboard.SetDataObject(sbInsertIntoCode.ToString(), true);
          try
          {

            objSQL_T.ExecSql(sbInsertIntoCode.ToString());

          }
          catch (Exception objException)
          {
            sbMessage = new StringBuilder();
            sbMessage.AppendFormat("插入记录出错!SQL = {0}; 出错信息:{1}\n\r", sbInsertIntoCode.ToString(), objException.Message);
            sbMessage.AppendFormat("新字段:<{0}>;SQL字段:<{1}>;SQL字段值:<{2}>;标识字段值:<{3}>.",
              strFldName_T, strFldName_S, strFldValue_S, strIdentityFldValue);
            throw new Exception(sbMessage.ToString());
            //M/essageBox.Show(sbMessage.ToString());
          }
        }
        //   10.2 如果存在就修改---------------------------
        //     10.2.1 组织插入记录SQL串
        //     10.2.2 记录插入到目标表中
        else  //如果存在
        {
          if (bolIsExistSameIdentityValue == true)
          {
            string strOldKeyValue = null;
            try
            {

              strOldKeyValue = objSQL_T.GetFldDataOfTable(objvSqlDataSynEN.TabName,
                             strKeyWord_T,
                       strExclusiveCondition)[0].ToString();

              //for (int i = 0; i < arrFieldCodes.Count; i++)
              //{
              //  if (arrFieldCodes[i].ToString() == objvSqlDataSynEN.Keyword_T)
              //  {
              //    arrValuesCodes[i] = strOldKeyValue;
              //  }
              //}
              Update_Sql(arrTabFldRelaObjLst,
                arrFieldCodes,
                arrValuesCodes,
                objvSqlDataSynEN.Keyword,
                strExclusiveCondition,
                objvSqlDataSynEN.TabName,
                strConnectString_T,
                objvSqlDataSynEN.RecExclusiveWayId,
                strDataBaseTypeId_T);
            }
            catch (Exception objException)
            {
              sbMessage = new StringBuilder();
              sbMessage.AppendFormat("{0}\n\r", objException.Message);
              sbMessage.AppendFormat("新字段:<{0}>;SQL字段:<{1}>;SQL字段值:<{2}>;标识字段值:<{3}>.",
                strFldName_T, strFldName_S, strFldValue_S, strIdentityFldValue);
              throw new Exception(sbMessage.ToString());
              //M/essageBox.Show(sbMessage.ToString());
            }
          }
        }
        //   10.2 如果存在就修改 == == == == == == == = 




        //          Debug.Assert(intRecIndex <= 30);
        //设置导入状态
        intRecIndex++;


      }//foreach (DataRow objRow_S in objDT_S.Rows)

      //如果不需要标记,就不需要多次调用源表记录集

    }
    /// <summary>
    /// 转换值串中的单撇"'",使之成为双撇"''"
    /// </summary>
    /// <param name = "strSourceStr">源串</param>
    /// <returns>目标串</returns>
    public static string TransValueStrForSql(string strSourceStr)
    {
      string strTargetStr = strSourceStr.Replace("'", "''");
      return strTargetStr;
    }

    private static bool GetIsExistSameRecord(List<clsvTabFieldRelaEN> arrTabFldRelaObjLst, 
      clsvSqlDataSynEN objvSqlDataSynEN,
      string strKeyWord_T, string strKeyValue_T, Hashtable hashFld_Value,
       clsSpecSQLforSql objSQL_T, ref string strExclusiveCondition1)
    {
      string strFldName_T;
      string strFldName_S;
      string strFldValue_S;
      int intRecNum;
   StringBuilder    sbExclusiveCondition = new StringBuilder();
      if (objvSqlDataSynEN.RecExclusiveWayId == "0001") // 主键式记录排他
      {
        sbExclusiveCondition.AppendFormat(strKeyWord_T + " = '{0}'", strKeyValue_T);
      }
      else if (objvSqlDataSynEN.RecExclusiveWayId == "0002") // 组合式字段集合排他
      {
        sbExclusiveCondition.Append(" 1 = 1 ");
        foreach (clsvTabFieldRelaEN objvTabFieldRela in arrTabFldRelaObjLst)
        {
          if (objvTabFieldRela.IsTabUnique == true && objvTabFieldRela.IsTabPrimary != true)
          {
            strFldName_T = objvTabFieldRela.FldName;

            strFldName_S = objvTabFieldRela.SqlFldName;
            
            //strFldValue_S = objRow_S[strFldName_S].ToString().Trim();
            strFldValue_S = hashFld_Value[strFldName_T].ToString().Trim();
            sbExclusiveCondition.AppendFormat(" and {0} = '{1}'", strFldName_T, strFldValue_S);
          }
        }
      }
      //7、检查排他性条件串是否为空,不能为空。
      if (sbExclusiveCondition.Length <= 6)
      {
        throw new Exception(string.Format("记录排他性条件为空({0},请为某些字段设置唯一性!", sbExclusiveCondition));
      }
      //8、检查排他性条件串相关记录数是否唯一,如果不唯一修改记录就发生问题。
    

      intRecNum = objSQL_T.GetRecCount(objvSqlDataSynEN.TabName, sbExclusiveCondition.ToString());
      

      if (intRecNum > 1)
      {
        throw new Exception(string.Format("同一条件:({0}所对应的记录数:{1}大于1条,不符合排他性条件,请为某些字段设置唯一性!", sbExclusiveCondition, intRecNum));
      }
      bool bolIsExistSameIdentityValue = intRecNum == 1 ? true : false;

      strExclusiveCondition1 = sbExclusiveCondition.ToString();
      return bolIsExistSameIdentityValue;
    }


    public static bool Update_Sql(List<clsvTabFieldRelaEN> arrTabFieldRelaObjList,
    ArrayList arrFieldCodes,
    ArrayList arrValuesCodes,
    string strKeyWord,
    string strWhereCond,
    string strTabName,
    string strConnectString,
    string strRecExclusiveWayId,
    string strDataBaseTypeId)
    {
      StringBuilder sbSQL = new StringBuilder();
      clsSpecSQLforSql objSQL = null;
      
        objSQL = new clsSpecSQLforSql(strConnectString);
      
      sbSQL.AppendFormat("Update {0} set ", strTabName);
      int intFieldNum = arrFieldCodes.Count;
      bool bolIsHaveSetField = false;
      for (int intRec = 0; intRec < intFieldNum; intRec++)
      {
        //当前字段名
        string strFieldName = arrFieldCodes[intRec].ToString();
        if (strFieldName == strKeyWord)
        {
          continue;
        }
        clsvTabFieldRelaEN objTabFieldRela = GetTabFieldRelaObj(arrTabFieldRelaObjList, strFieldName);
        if (objTabFieldRela == null)
        {
          sbSQL.AppendFormat("{0} = {1},", arrFieldCodes[intRec].ToString(), arrValuesCodes[intRec].ToString());
        }
        else
        {
          string strUpdateFieldName = GetUpdateFieldName(objTabFieldRela, strRecExclusiveWayId);
          if (string.IsNullOrEmpty(strUpdateFieldName) == false)
          {

            sbSQL.AppendFormat("{0} = {1},", strUpdateFieldName, arrValuesCodes[intRec].ToString());
            bolIsHaveSetField = true;
          }
        }
      }
      if (bolIsHaveSetField == false)
      {
        return true;
      }
      sbSQL.Remove(sbSQL.Length - 1, 1);
      sbSQL.AppendFormat(" where {0}", strWhereCond);

      try
      {
        string strSQL = sbSQL.ToString();
        strSQL = strSQL.Replace("'null'", "null");
        //objViewInfoENEx.SqlStatement = strSQL.ToString();
        
          objSQL.ExecSql(strSQL.ToString());
        
      }
      catch (Exception objException)
      {
        clsGeneralTab.LogErrorS(objException, "clsSqlTabTrans_Update_Sql");
        StringBuilder sbMessage = new StringBuilder();
        sbMessage.AppendFormat("修改记录出错!SQL = {0}; 出错信息:{1}\n\r", sbSQL.ToString(), objException.Message);
        throw new Exception(sbMessage.ToString());
        //        M/essageBox.Show(sbMessage.ToString());
      }

      finally
      {
      }
      return true;
    }

    private static string GetUpdateFieldName(clsvTabFieldRelaEN objvTabFieldRela, string strRecExclusiveWayId)
    {
      string strFldName_T = objvTabFieldRela.FldName;

      if (strRecExclusiveWayId == "0001") // 主键式记录排他
      {
        if (objvTabFieldRela.IsTabPrimary == false)
        {
          return strFldName_T;
        }
        else
        {
          return "";
        }
      }
      else if (strRecExclusiveWayId == "0002") // 组合式字段集合排他
      {
        if (objvTabFieldRela.IsTabUnique = false && objvTabFieldRela.IsTabPrimary == false)
        {
          return strFldName_T;
        }
        else
        {
          return "";
        }
      }
      return "";
    }
    private static clsvTabFieldRelaEN GetTabFieldRelaObj(List<clsvTabFieldRelaEN> arrTabFieldRelaObjList, string strFieldName)
    {
      foreach (clsvTabFieldRelaEN objTabFieldRela in arrTabFieldRelaObjList)
      {
        if (objTabFieldRela.FldName.ToLower() == strFieldName.ToLower())
        {
          return objTabFieldRela;
        }
      }
      return null;
    }

    /// <summary>
    /// 检查字段值长度
    /// </summary>
    /// <param name = "strFldValue">字段值</param>
    /// <param name = "intLength">最大字段长度</param>
    /// <param name = "strFldName_S">源字段名</param>
    /// <param name = "strFldName_T">目标字段名</param>
    /// <returns>是否成功</returns>
    private static bool CheckFldValueLength(string strFldValue, int intLength, string strFldName_S, string strFldName_T)
    {
      int intFldValueLength = clsString.getStrLenS(strFldValue);
      if (intFldValueLength > intLength)
      {
        StringBuilder sbMessage = new StringBuilder();
        sbMessage.AppendFormat("目标字段:<{0}>;源字段:<{1}>;源字段值:<{2}>;源字段长度:<{3}>,最大长度:{4}.",
          strFldName_T, strFldName_S, strFldValue, intFldValueLength, intLength);
        throw new Exception(sbMessage.ToString());
      }
      return true;
    }

    /// <summary>
    /// 根据转换方式来转换值
    /// </summary>
    /// <param name = "strValue"></param>
    /// <param name = "strTransWayId"></param>
    /// <returns></returns>
    private static string TransValueByTransWay(string strValue, string strTransWayId)
    {
      string strTransValue = null;
      if (strTransWayId == "04")
      {
        strTransValue = strValue == "0" ? "False" : "True";
      }
      return strTransValue;
    }




    private static string TransFldValue(string strTransTabName, string strTrans_InFld, 
      string strTrans_OutFld, string strTrans_InFldValue,
      string strConnectString_T)
    {
      string strTrans_OutFldValue = "";
      clsSpecSQLforSql objSQL_T = new clsSpecSQLforSql(strConnectString_T);
      StringBuilder sbCondition = new StringBuilder();
      sbCondition.AppendFormat("{0} = '{1}'", strTrans_InFld, strTrans_InFldValue);

      strTrans_OutFldValue = objSQL_T.GetFirstFldValueOfTable(strTransTabName, strTrans_OutFld, sbCondition.ToString());
      return strTrans_OutFldValue;

    }
    private static string TransFldValueForMultiField(string strTransTabName, string strTrans_InFld, 
      string strTrans_OutFld, string strTrans_InFldValue,
       string strConnectString_T)
    {
      string strTrans_OutFldValue = "";
      clsSpecSQLforSql objSQL_T = new clsSpecSQLforSql(strConnectString_T);
      //StringBuilder sbCondition = new StringBuilder();
      string[] sstrTrans_InFld = strTrans_InFld.Split(",".ToCharArray());
      string[] sstrTrans_InFldValue = strTrans_InFldValue.Split(",".ToCharArray());
      int intFieldCount = sstrTrans_InFld.GetLength(0);
      string[] sstrEqual = new string[intFieldCount];
      for (int i = 0; i < intFieldCount; i++)
      {
        sstrEqual[i] = string.Format("{0} = '{1}'", sstrTrans_InFld[i], sstrTrans_InFldValue[i]);
      }
      //sbCondition.AppendFormat("{0} = '{1}'", strTrans_InFld, strTrans_InFldValue);
      string strCondition = string.Join(" AND ", sstrEqual);
      try
      {
        strTrans_OutFldValue = objSQL_T.GetFirstFldValueOfTable(strTransTabName, strTrans_OutFld, strCondition);
      }
      catch (Exception objException)
      {
        throw new Exception(string.Format("转换数据出错!查询条件:{0}。错误信息:{1}", strCondition, objException.Message));
      }
      return strTrans_OutFldValue;

    }
    //private static string TransFldValueByHash(int intHashIndex, string strTrans_InFldValue)
    //{
    //  string strTrans_OutFldValue = "";
    //  switch (intHashIndex)
    //  {
    //    case 1:
    //      strTrans_OutFldValue = hashDict_NameToId1[strTrans_InFldValue].ToString();
    //      break;
    //    case 2:
    //      strTrans_OutFldValue = hashDict_NameToId2[strTrans_InFldValue].ToString();
    //      break;
    //    case 3:
    //      strTrans_OutFldValue = hashDict_NameToId3[strTrans_InFldValue].ToString();
    //      break;
    //    case 4:
    //      strTrans_OutFldValue = hashDict_NameToId4[strTrans_InFldValue].ToString();
    //      break;
    //    case 5:
    //      strTrans_OutFldValue = hashDict_NameToId5[strTrans_InFldValue].ToString();
    //      break;
    //    case 6:
    //      strTrans_OutFldValue = hashDict_NameToId6[strTrans_InFldValue].ToString();
    //      break;
    //    case 7:
    //      strTrans_OutFldValue = hashDict_NameToId7[strTrans_InFldValue].ToString();
    //      break;
    //    case 8:
    //      strTrans_OutFldValue = hashDict_NameToId8[strTrans_InFldValue].ToString();
    //      break;
    //    case 9:
    //      strTrans_OutFldValue = hashDict_NameToId9[strTrans_InFldValue].ToString();
    //      break;
    //    case 10:
    //      strTrans_OutFldValue = hashDict_NameToId10[strTrans_InFldValue].ToString();
    //      break;
    //    case 11:
    //      strTrans_OutFldValue = hashDict_NameToId11[strTrans_InFldValue].ToString();
    //      break;
    //    case 12:
    //      strTrans_OutFldValue = hashDict_NameToId12[strTrans_InFldValue].ToString();
    //      break;
    //    case 13:
    //      strTrans_OutFldValue = hashDict_NameToId13[strTrans_InFldValue].ToString();
    //      break;
    //    case 14:
    //      strTrans_OutFldValue = hashDict_NameToId14[strTrans_InFldValue].ToString();
    //      break;
    //    case 15:
    //      strTrans_OutFldValue = hashDict_NameToId15[strTrans_InFldValue].ToString();
    //      break;

    //  }
    //  return strTrans_OutFldValue;

    //}
 
  }
}
