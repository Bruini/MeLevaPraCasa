using System;
using System.IO;
using System.Reflection;
using AngelHack.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;


namespace AngelHack.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddCors();
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1",
            //        new Info
            //        {
            //            Title = "AngelHack",
            //            Version = "v1",
            //            Description = "API da MeLevaPraCasa - AngelHack",
            //            Contact = new Contact
            //            {
            //                Name = "MeLevaPraCasa",
            //                Url = "https://github.com/Bruini/MeLevaPraCasa"
            //            }
            //        });

            //    // Usar a documentação XML dos métodos.

            //    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            //    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            //    c.IncludeXmlComments(xmlPath);


            //});

            var ioc = new IoCService();
            ioc.Register(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
                c.DisallowCredentials();

            });

            app.UseHttpsRedirection();
            app.UseMvc();

            //app.UseSwagger();
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MeLevaPraCasa API V1");
            //});



        }
    }
}
