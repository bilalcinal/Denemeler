using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Primitives;
using UdemyNet.Middlewares;

namespace UdemyNet
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Controller => View
            // HomeController => home
            // Index() => index.cshtml

            // Localhost/home/Index
            
             app.UseRouting();
             app.UseStaticFiles();
             app.UseStaticFiles(new StaticFileOptions
             {
                 RequestPath = "/nodem_modules",
                 FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules"))
             });
             app.UseEndpoints(endpoints=>
           {  
            
            //   endpoints.MapControllerRoute(
            //   name: "productRoute",
            //   pattern: "Bilal/{action}",
            //   defaults: new {Controller="Home"}
            //   );


             
              endpoints.MapControllerRoute(
                    name:"default",
                    pattern:"{Controller}/{Action}/{id?}",
                    defaults: new {Controller="Home",Action="Index"}
              );
             

        });
            // app.UseMiddleware<ResponseEditingMiddleware>();
            // IApplicationBuilder applicationBuilder = app.UseMiddleware<RequestEdittingMiddleware>();

           // app.UseEndpoints(endpoints =>
           // {
          //      endpoints.MapGet("/", async context =>
          //      {
          //          await context.Response.WriteAsync("Hello World!");
          //     });
          //  });
        }
    }

   
}
