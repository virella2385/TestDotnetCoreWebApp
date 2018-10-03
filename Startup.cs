using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace TestNetCoreWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IGreeter conf, ILogger<Startup> logger)
        {
            /* if (env.IsDevelopment())
             {
                 app.UseDeveloperExceptionPage();
             }*/
            app.Use(next =>
            {
                return async context =>
                {
                    logger.LogInformation("My own mothatfucking middleware!");
                    if (context.Request.Path.StartsWithSegments("/mym"))
                    {
                        await context.Response.WriteAsync("");
                        logger.LogInformation("request came in");
                    }
                    else 
                    {
                        await next(context);
                        logger.LogInformation("request pased on");
                    }
                };
                });
            app.UseWelcomePage(new WelcomePageOptions
            {
                Path = "/wp"
            });


            app.Run(async (context) =>
            {
                var greeting = conf.GetMessageOfTheDay();
                await context.Response.WriteAsync(greeting);
            });
        }
    }
}
