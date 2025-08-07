using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AgcMvc3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务
            var cors = new EnableCorsAttribute("http://localhost:3002,http://localhost:39540,http://localhost:49550, http://localhost:39550,http://101.251.68.133:8082,", "*", "*");
            //[EnableCors(origins: "http://localhost:49540", headers: "*", methods: "*")]
            config.EnableCors(cors);
            //config.EnableCors();

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
