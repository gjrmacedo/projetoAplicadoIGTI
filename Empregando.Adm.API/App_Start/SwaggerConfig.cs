using System.Web.Http;
using WebActivatorEx;
using Empregando.API;
using Swashbuckle.Application;
using System;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Empregando.API
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Empregando.Adm.API");
                    c.PrettyPrint();
                    c.UseFullTypeNameInSchemaIds();
                    c.IncludeXmlComments(string.Format(@"{0}\bin\Swagger.XML",
                           AppDomain.CurrentDomain.BaseDirectory));
                })
                .EnableSwaggerUi();
        }        
    }
}
