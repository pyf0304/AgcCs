using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AgcWA.Controllers;
using com.taishsoft.common;
using com.taishsoft.syspara;
using Comm.PubFun;
using Comm.WebApi;
using GeneralPlatform.Entity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SpecData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace AGCWA
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            ConfigHelper._Init(configuration); //配置ConfigHelper
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddRazorPages();
            //services.AddControllers();
            services.AddControllers(options =>
            {
                options.Filters.Add(typeof(ApiAuthorizeAttributeV3));
            });
            // Add CORS policy
            
            services.AddCors(options =>
            {
                //options.AddPolicy("AllowAll",
                //builder =>
                //{
                //    builder.AllowAnyOrigin()
                //            .AllowAnyMethod()
                //    .AllowAnyHeader();
                //});
                options.AddPolicy("AllowSpecificOrigin",
                   builder => builder.WithOrigins("http://localhost:8089")
                                     .AllowAnyHeader()
                                     .AllowAnyMethod());
            });
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                //c.SwaggerDoc("v1", new OpenApiInfo { Title = "AgcWA", Version = "v1" });
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AgcWA", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
            });



            clsDebugBase_Sql.IsDebug = true;
            clsDebugBase_Sql.LogDir4Debug = @"D:\Log\AgcWA\";
            clsDebugBase_Sql.LogFile4Debug = "Log4DataBase";
            clsDebugBase_Sql.TraceLevel = 4;
            clsDebugBase_Pub.TraceLevel = 4;
            clsPubVar4BLEx.objLog4Error = new clsLog(@"D:\Log\AgcWA\", "Debug4BLEx");
            clsPubVar4BLEx.objLog4GC = new clsLog(@"D:\Log\AgcWA\", "Log4GC");
            AGC.Entity.clsSysParaEN.objErrorLog = new clsLog(@"D:\Log\AgcWA\", "errorMsg");            
            AGC.Entity.clsSysParaEN_Local.objLog = new clsLog(@"D:\Log\AgcWA\", "Debug4SysPara");
            AGC.Entity.clsSysParaEN_Local.objLog4GCError = new clsLog(@"D:\Log\AgcWA\", "Error4GeneCode");
            GeneralPlatform.Entity.clsSysParaEN.objLog = new clsLog(@"D:\Log\AgcWA_GP\", "Debug4SysPara");
            GeneralPlatform.Entity.clsSysParaEN.objErrorLog = new clsLog(@"D:\Log\AgcWA_GP\", "errorMsg");
            GeneralPlatform.Entity.clsSysParaEN_Local.objLog = new clsLog(@"D:\Log\AgcWA_GP\", "Debug4SysPara");
            GeneralPlatform.BusinessLogicEx.clsPubVar4BLEx.objLog = new clsLog(@"D:\Log\AgcWA_GP\", "Debug4BLEx");

            //GeneralPlatform.Entity.clsSysParaEN_Local.objLog4GCError = new clsLog(@"D:\Log\AgcWA\", "Error4GeneCode");


            clsPubVar_WebApi.objLog = new clsLog(@"D:\Log\AgcWA\", @"Log4Dubug_WebApi");



            com.taishsoft.commdb.clsSpecSQLforSql.IsUseEncrypt = false;
            com.taishsoft.commdb.clsSpecSQLforSql.AppType = "NetCoreWebApi";
            AGC.Entity.clsSysParaEN.spConnectString_GP = Configuration["ConnectionString4GP"];
            Console.WriteLine($"ConnectionString = {Configuration["ConnectionString"]}");
            Console.WriteLine($"providerName = {Configuration["providerName"]}");
            clsSpecSQL.strConnectString = Configuration["ConnectionString"];
            SetConnStr4GP();
            clsPubFun4BLEx.SetCommFun4BL();
            clsDetailRegionFldsBL.relatedActions = new RelatedActions_DetailRegionFldsEx();
            clsPrjTabFldBL.relatedActions = new RelatedActions_PrjTabFldEx();

            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
          .AddJwtBearer(options =>
          {
              options.TokenValidationParameters = new TokenValidationParameters
              {
                  ValidateIssuer = true,
                  ValidateAudience = true,
                  ValidateLifetime = true,
                  ValidateIssuerSigningKey = true,
                  ValidIssuer = Configuration["JwtSettings:Issuer"],
                  ValidAudience = Configuration["JwtSettings:Audience"],
                  IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSettings:SigningKey"]))
              };
          });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseSession();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AgcWA v1"));
                app.UseSwaggerUI();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            //app.UseCors("AllowAll");
            // Use CORS policy
            app.UseCors("AllowSpecificOrigin");

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                      name: "default",
                       pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //--------------
            app.UseHttpsRedirection();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
            //==============


        }


        public DataTable GetDataTable(string strSql, string p_sConnectString)
        {
            //by davidfujian (李顺道)
            //2004-2-28 Night
            //获得并返回表

            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable dtTab;
            var m_oConn = getConnectObj(p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = strSql;
                sqlCmd.CommandTimeout = 9600;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                dtTab = new DataTable();
                sqlAdp.Fill(dtTab);

                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtTab.Rows.Count);
                        //s1trMsg += string.Format("|底层函数:[GetDataTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetDataTable]", objException.Message, strSql);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }

                }

                //m_oConn.CloseB();
                return dtTab;
            }
            catch (Exception objException)
            {
                System.Console.Out.WriteLine("strSql = " + strSql);
                //LogError(objException, strSql);
                string strMsg = "";
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw new Exception(strMsg); //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);

            }
            finally
            {
                m_oConn.Close();
            }
        }
        public SqlConnection getConnectObj(string strConnectString)
        {
            SqlConnection objSqlConnect = null;
            try
            {
                objSqlConnect = new SqlConnection(strConnectString);
                objSqlConnect.Open();
                return objSqlConnect;
            }
            catch (Exception objException)
            {
                objSqlConnect.Dispose();
                objSqlConnect = null;
                //LogError(objException, "打开连接失败!");


                StringBuilder sbMessage = new StringBuilder();
                sbMessage.Append(objException.Message);
                sbMessage.Append("\r\n");
                sbMessage.Append("打开连接失败!请检查连接串!\r\n");
                string[] strItems = strConnectString.Split(';');
                //foreach (string strItem in strItems)
                //{
                //    string[] strKeyValue = strItem.Split('=');
                //    if (strKeyValue[0].Equals("server", StringComparison.CurrentCultureIgnoreCase) == true)
                //    {
                //        m_sServer = strKeyValue[1];
                //    }
                //    else if (strKeyValue[0].Equals("database", StringComparison.CurrentCultureIgnoreCase) == true)
                //    {
                //        m_sDatabase = strKeyValue[1];
                //    }
                //    else if (strKeyValue[0].Equals("uid", StringComparison.CurrentCultureIgnoreCase) == true)
                //    {
                //        m_sUid = strKeyValue[1];
                //    }
                //}
                //if (string.IsNullOrEmpty(m_sServer) == false)
                //{
                //    sbMessage.AppendFormat("打开的服务器：{0}，\r\n数据库：{1}。", //，\r\n用户名：{2}。",
                //        m_sServer,
                //        m_sDatabase,
                //        m_sUid);
                //}
                //if (clsDebugBase_Sql.IsDebug == true)
                //{
                //    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, sbMessage.ToString());
                //    StackTrace trace = new StackTrace();
                //    int intCurrLevel = 0;
                //    foreach (StackFrame frame in trace.GetFrames())
                //    {
                //        string strFileName = frame.GetFileName();
                //        string strMothodName = frame.GetMethod().Name;
                //        if (frame.GetMethod().DeclaringType == null) break;
                //        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                //        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                //        intCurrLevel++;
                //        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                //    }
                //    clsDebugBase_Sql.WriteLog(strMsg);
                //}
                //				sbMessage.Append("打开连接失败!请检查连接串!");
                throw new Exception(sbMessage.ToString(), objException);
                //				dtTab=new DataTable();
                //				return dtTab;	
            }
            //finally
            //{
            //}
        }
        public bool SetConnStr4GP()
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
        public List<string> GetTabName4GP()
        {
            var arrTabName = new List<string>();
            arrTabName.Add("A");
            return arrTabName;
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.


    }
}
