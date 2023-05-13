using EasyShop.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using webApi;

namespace EasyShop
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
            string dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
            string connectionString = $"Server=database-3.cqcf1jsxjqpe.us-east-1.rds.amazonaws.com;Port=3306;Database=admin;User Id=admin;Password={dbPassword}";
            // Configuração do banco de dados
            services.AddDbContext<DataContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            //Dependence Injection 
            services.AddRepositories();
            services.AddServices();


            // Configuração do serviço de mapeamento de objetos
            services.AddAutoMapper(typeof(Startup));

            // Configuração da sessão
            services.AddSession(options =>
            {
                options.Cookie.Name = ".webApi.Session";
                options.IdleTimeout = System.TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            // Adiciona o serviço MVC
            services.AddControllersWithViews();

            //Swagger Config
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "webApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "webApi");
            });
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}