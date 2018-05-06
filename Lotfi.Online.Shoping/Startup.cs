using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using Lotfi.OnlineShoping.Filters;
using Lotfi.OnlineShoping.Infrastructure.AppService;
using Lotfi.OnlineShoping.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lotfi.OnlineShoping
{
    //this is for test commit all
    public class Startup
    {
        IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            #region MyRegion
            //services.AddDbContext<MyShopContext>(options =>
            //    options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyShop;Trusted_Connection=True;MultipleActiveResultSets=true")); 

            services.AddDbContext<MyShopContext>(options =>
                options.UseSqlServer("Server=BAMDAD-LOTFI; Initial Catalog=MyShop; Integrated Security=true", b => b.MigrationsAssembly("Lotfi.OnlineShoping")));
            #endregion

            //services.AddDbContext<MyShopContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped(typeof(ICustomerRepository), typeof(CustomerRepository));
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddScoped(typeof(IMyExceptionRepository), typeof(MyExceptionRepository));
            services.AddScoped(typeof(IVistorLogService), typeof(VisitorLogService));

            //services.AddMvc(options =>
            //{
            //    options.Filters.Add(typeof(LogVisitorsFilter)); // by type
            //    //options.Filters.Add(new LogVisitorsFilter()); // an instance
            //});
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseDatabaseErrorPage();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
