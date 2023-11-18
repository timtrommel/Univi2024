using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Univi.Server.Data;
using Univi.Server.Models;
using Univi.Server.Services.BuildingService;
using Univi.Server.Services.HandoverService;
using Univi.Server.Services.KeyService;
using Univi.Server.Services.KindofMalfunctionService;
using Univi.Server.Services.KindofReportService;
using Univi.Server.Services.MalfunctionService;
using Univi.Server.Services.ReportService;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddSwaggerGen();

//Add the new created services
builder.Services.AddScoped<IHandoverService, HandoverService>();
builder.Services.AddScoped<IReportService,ReportService>();
builder.Services.AddScoped<IKeyservice,KeyService>();
builder.Services.AddScoped<IBuildingService, BuildingService>();
builder.Services.AddScoped<IKindofReportService, KindofReportService>();
builder.Services.AddScoped<IMalfunctionService, MalfunctionService>();
builder.Services.AddScoped<IKindofMalfunctionService,KindofMalfunctionService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
policy =>
{
    policy
    .AllowAnyHeader()
    .AllowAnyOrigin()
    .AllowAnyMethod();
});
});


//Add the new created services
builder.Services.AddScoped<IHandoverService, HandoverService>();

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddIdentityServer()
    .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

builder.Services.AddAuthentication()
    .AddIdentityServerJwt();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blazor API V1");
});




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
