using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AgcWA;
using AgcWA.Controllers;
using com.taishsoft.common;
using com.taishsoft.syspara;
using Comm.PubFun;
using Comm.WebApi;
using GeneralPlatform.Entity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using SpecData;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
// Configure Serilog
//Log.Logger = new LoggerConfiguration()
//    .MinimumLevel.Information()
//    .WriteTo.Console()
//    .CreateLogger();
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug() // 设置最低日志级别
    .WriteTo.Console()    // 输出到控制台
    .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day) // 输出到文件，按天滚动
    .CreateLogger();

//builder.Host.UseSerilog(); // Add Serilog
// Add Serilog to the logging providers
builder.Logging.ClearProviders();
builder.Logging.AddSerilog();
// Add services to the container.

//builder.Services.AddControllers();
builder.Services.AddControllers(options =>
{
    options.Filters.Add(typeof(ApiAuthorizeAttributeV4));
});
builder.Services.AddCors(options =>
{
    //options.AddPolicy("AllowAll",
    //builder =>
    //{
    //    builder.AllowAnyOrigin()
    //            .AllowAnyMethod()
    //    .AllowAnyHeader();
    //});
    options.AddPolicy("AllowSpecificOrigin",
       builder => builder.WithOrigins("http://localhost:8099")
                         .AllowAnyHeader()
                         .AllowAnyMethod());
});
// Register IMemoryCache service
builder.Services.AddMemoryCache();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(auth =>
{
    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    var signingKey = builder.Configuration["JwtSettings:SigningKey"];
    if (signingKey == null || signingKey.Length < 32)
    {
        throw new Exception("SigningKey length must be at least 32 bytes.");
    }
    options.TokenValidationParameters = new TokenValidationParameters
  {
      ValidateIssuer = true,
      ValidateAudience = true,
      ValidateLifetime = true,
      ValidateIssuerSigningKey = true,
      ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
      ValidAudience = builder.Configuration["JwtSettings:Audience"],
      IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:SigningKey"]))
  };
});

// Initialize ConfigHelper
ConfigHelper._Init(builder.Configuration);

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
AGC.Entity.clsSysParaEN.spConnectString_GP = builder.Configuration["ConnectionString4GP"];
Console.WriteLine($"ConnectionString = {builder.Configuration["ConnectionString"]}");
Console.WriteLine($"providerName = {builder.Configuration["providerName"]}");
clsSpecSQL.strConnectString = builder.Configuration["ConnectionString"];
clsStartup.SetConnStr4GP();
clsPubFun4BLEx.SetCommFun4BL();
clsDetailRegionFldsBL.relatedActions = new RelatedActions_DetailRegionFldsEx();
clsPrjTabFldBL.relatedActions = new RelatedActions_PrjTabFldEx();

var app = builder.Build();

// Log all requests
app.Use(async (context, next) =>
{
    // Log request headers
    var request = context.Request;
    var logger = app.Services.GetRequiredService<ILogger<Program>>();
    logger.LogInformation($"申请服务:Request {request.Method} {request.Path}");
    // Log request body

    try
    {
        if (request.Method == HttpMethods.Post || request.Method == HttpMethods.Put)
        {
            request.EnableBuffering();
            using var reader = new StreamReader(request.Body, Encoding.UTF8, true, 1024, true);
            var body = await reader.ReadToEndAsync();
            request.Body.Position = 0; // Reset the stream position
            logger.LogInformation($"申请主体:Request Body: {body}");
        }
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "阅读申请体出错:Error reading request body");
    }
    await next.Invoke();
});
app.UseCors("AllowSpecificOrigin");
//app.UseCors("AllowAll");


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.UseDefaultFiles(); // 👈 在 UseStaticFiles 前面加这一行

app.UseStaticFiles(); // 👈 添加这一行
app.MapControllers();
app.Run();

