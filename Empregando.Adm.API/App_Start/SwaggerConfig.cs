using System.Web.Http;
using WebActivatorEx;
using Empregando.API;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Empregando.API
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Empregando.API");
                    c.PrettyPrint();
                    c.UseFullTypeNameInSchemaIds();
                    c.IncludeXmlComments(string.Format(@"{0}\bin\Empregando.API.xml",
                           System.AppDomain.CurrentDomain.BaseDirectory));
                })
                .EnableSwaggerUi();
        }        
    }
}
