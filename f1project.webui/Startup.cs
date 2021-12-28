using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using f1project.business.Abstract;
using f1project.business.Concrete;
using f1project.data.Abstract;
using f1project.data.Concrete.EfCore;
using f1project.data.SeedDatabase;
using f1project.webui.EmailServices;
using f1project.webui.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace f1project.webui
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
            services.AddDbContext<ApplicationContext>(options=>options.UseSqlServer(Configuration.GetConnectionString("MsSqlConnection")));
            services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
            
            services.AddScoped<ICountryService,CountryManager>();
            services.AddScoped<IF1TeamService,F1TeamManager>();
            services.AddScoped<IF1DriverService,F1DriverManager>();
            services.AddScoped<IPostService,PostManager>();
            

            services.AddScoped<ICountryDal,EfCoreCountryDal>();
            services.AddScoped<IF1TeamDal,EfCoreF1TeamDal>();
            services.AddScoped<IF1DriverDal,EfCoreF1DriverDal>();
            services.AddScoped<IPostDal,EfCorePostDal>();
            

            services.AddScoped<IEmailSender,SmtpEmailSender>(i=>
                new SmtpEmailSender(
                    Configuration["EmailSend:Host"],
                    Configuration.GetValue<int>("EmailSend:Port"),
                    Configuration.GetValue<bool>("EmailSend:EnableSsl"),
                    Configuration["EmailSend:username"],
                    Configuration["EmailSend:password"])
            );



            services.AddControllersWithViews();


            services.Configure<IdentityOptions>(options=>{
                options.Password.RequireDigit=true;
                options.Password.RequiredLength=6;
                options.Password.RequiredUniqueChars=1;
                options.Password.RequireLowercase=true;
                options.Password.RequireUppercase=true;
                

                options.SignIn.RequireConfirmedAccount=false;
                options.SignIn.RequireConfirmedEmail=true;
                options.SignIn.RequireConfirmedPhoneNumber=false;

                options.Lockout.AllowedForNewUsers=true;
                options.Lockout.DefaultLockoutTimeSpan=TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts=3;

                options.User.RequireUniqueEmail=true;
                
            });
            services.ConfigureApplicationCookie(options=>{
                options.LoginPath="/account/login";
                options.LogoutPath="/";
                options.AccessDeniedPath="/account/accessdenied";

                options.Cookie = new CookieBuilder{
                    HttpOnly=true,
                    Name=".F1Project.security.cookie",
                    SameSite = SameSiteMode.Strict
                };
                options.SlidingExpiration=true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
            });
            services.Configure<DataProtectionTokenProviderOptions>(options=>{
                options.TokenLifespan = TimeSpan.FromHours(1);
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IConfiguration configuration,UserManager<User> userManager,RoleManager<IdentityRole> roleManager,IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                DataSeeding.Seed();
                
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions{
                FileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory()+"/node_modules"),
                RequestPath="/modules"
            });
            app.UseStaticFiles(new StaticFileOptions{
                FileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory()+"/wwwroot/images"),
                RequestPath = "/images"
            });
            app.UseStaticFiles(new StaticFileOptions{
                FileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory()+"/wwwroot/css"),
                RequestPath = "/css"
            });


            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name:"haber",
                    pattern:"/Haber/{id}",
                    defaults:new{controller="Home",action="Post"}
                );
            
                endpoints.MapControllerRoute(
                    name:"resmisil",
                    pattern:"/resmisil",
                    defaults:new{controller="Settings",action="DeleteImage"}
                );

                endpoints.MapControllerRoute(
                    name:"resimler",
                    pattern:"/resimler",
                    defaults:new{controller="Settings",action="Images"}
                );

                endpoints.MapControllerRoute(
                    name:"takimekle",
                    pattern:"/takimekle",
                    defaults:new{controller="Settings",action="AddTeam"}
                );

                endpoints.MapControllerRoute(
                    name:"pilotekle",
                    pattern:"/pilotekle",
                    defaults:new{controller="Settings",action="AddDriver"}
                );

                endpoints.MapControllerRoute(
                    name:"rolekle",
                    pattern:"/rolekle",
                    defaults:new{controller="Admin",action="AddRole"}
                );

                endpoints.MapControllerRoute(
                    name:"roller",
                    pattern:"/roller",
                    defaults:new{controller="Admin",action="Roles"}
                );
                endpoints.MapControllerRoute(
                    name:"rolid",
                    pattern:"/roller/{name}",
                    defaults:new{controller="Admin",action="GetRole"}
                );

                endpoints.MapControllerRoute(
                    name:"getcountries",
                    pattern:"/ülkeleridüzenle",
                    defaults:new{controller="Settings",action="GetCountries"}
                );

                endpoints.MapControllerRoute(
                    name:"getcountries",
                    pattern:"/ülkeleridüzenle/{id}",
                    defaults:new{controller="Settings",action="GetCountry"}
                );

                endpoints.MapControllerRoute(
                    name:"getteams",
                    pattern:"/kullanıcılarıdüzenle",
                    defaults:new{controller="Admin",action="GetUsers"}
                );
                endpoints.MapControllerRoute(
                    name:"getteamid",
                    pattern:"/kullanıcılarıdüzenle/{id}",
                    defaults:new{controller="Admin",action="GetUser"}
                );
                endpoints.MapControllerRoute(
                    name:"postpaylaş",
                    pattern:"/postpaylaş",
                    defaults:new{controller="Settings",action="AddPost"}
                );

                endpoints.MapControllerRoute(
                    name:"postlarıdüzenle",
                    pattern:"/postlarıdüzenle",
                    defaults:new{controller="Settings",action="GetPosts"}
                );
                endpoints.MapControllerRoute(
                    name:"getpostid",
                    pattern:"/postlarıdüzenle/{id}",
                    defaults:new{controller="Settings",action="GetPost"}
                );

                endpoints.MapControllerRoute(
                    name:"getpilots",
                    pattern:"/pilotlarıdüzenle",
                    defaults:new{controller="Settings",action="GetDrivers"}
                );
                endpoints.MapControllerRoute(
                    name:"getpilotid",
                    pattern:"/pilotlarıdüzenle/{id}",
                    defaults:new{controller="Settings",action="GetDriver"}
                );

                endpoints.MapControllerRoute(
                    name:"getteams",
                    pattern:"/takımlarıdüzenle",
                    defaults:new{controller="Settings",action="GetTeams"}
                );
                endpoints.MapControllerRoute(
                    name:"getteamid",
                    pattern:"/takımlarıdüzenle/{id}",
                    defaults:new{controller="Settings",action="GetTeam"}
                );

                endpoints.MapControllerRoute(
                    name:"managed",
                    pattern:"/hesapyonetimi",
                    defaults:new{controller="Account",action="Managed"}
                );

                endpoints.MapControllerRoute(
                    name:"teamid",
                    pattern:"/Takım/{id}",
                    defaults:new{controller="Home",action="Team"}
                );
                endpoints.MapControllerRoute(
                    name:"teams",
                    pattern:"/Takım",
                    defaults:new{controller="Home",action="Teams"}
                );

                endpoints.MapControllerRoute(
                    name:"pilotid",
                    pattern:"/Pilot/{id}",
                    defaults:new{controller="Home",Action="Pilot"}
                );
                endpoints.MapControllerRoute(
                    name:"pilots",
                    pattern:"/Pilot",
                    defaults:new{controller="Home",Action="Pilots"}
                );
                
                endpoints.MapControllerRoute(
                    name:"girisyap",
                    pattern:"/girişyap",
                    defaults:new{controller="Account",action="Login"}
                );
                endpoints.MapControllerRoute(
                    name:"kayıtol",
                    pattern:"/kayıtol",
                    defaults:new{controller="Account",action="Register"}
                );
                endpoints.MapControllerRoute(
                    name:"profilayarları",
                    pattern:"/profilayarları",
                    defaults:new{controller="Account",action="ChangeProfileSettings"}
                );
                endpoints.MapControllerRoute(
                    name:"sifremidegistir",
                    pattern:"/sifremidegistir",
                    defaults:new{controller="Account",action="ChangePassword"}
                );
                endpoints.MapControllerRoute(
                    name:"şifremiunuttum",
                    pattern:"/şifremiunuttum",
                    defaults:new{controller="Account",action="ForgotPassword"}
                );
                

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            SeedIdentity.Seed(userManager,roleManager,configuration).Wait();
        }
    }
}
