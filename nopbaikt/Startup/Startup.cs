// Startup.cs
using Microsoft.EntityFrameworkCore;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        services.AddAutoMapper(typeof(MappingProfile));

        // Other configurations, services, and middleware
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        // App configuration
    }
}
