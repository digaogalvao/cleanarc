using FinancialManagement.Infrastructure.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using FinancialManagement.Api.Controllers;
using FinancialManagement.Application.Services;
using FinancialManagement.Domain.Interfaces;
using FinancialManagement.Infrastructure.Repositories;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using FinancialManagement.Infrastructure;

namespace FinancialManagement.Api
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
            services.AddControllers();

            services.ConfigureInfrastructureApp(Configuration);

            //Registro no container conexão banco de dados
            /*services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));*/

            /*services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("FinancialManagement.Infrastructure")));*/

            //Registro no container interface e classe concreta
            /*services.AddScoped<ITransacaoService, TransacaoService>();
            services.AddScoped<ITransacaoRepository, TransacaoRepository>();
            services.AddTransient<FinanceiroController>();*/

            //Permissão React fazer solicitação cruzada a API
            services.AddCors();

            //Registro no container do Swagger doc Api
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Financial Management", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options =>
            {
                options.WithOrigins("http://localhost:3000");
                options.AllowAnyMethod();
                options.AllowAnyHeader();
            });

            //Configura Swagger doc Api
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "Financial Management V1");
            });

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
