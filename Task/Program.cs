using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("default")
                       ?? throw new InvalidOperationException("No Connection String Was Found");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICustomersService, CustomersService>();
builder.Services.AddScoped<IProductsService, ProductsService>();
builder.Services.AddScoped<IPurchaseInvoicesService, PurchaseInvoicesService>();
builder.Services.AddScoped<IJwtTokenManager, JwtTokenManager>();


var Configkey = builder.Configuration.GetValue<string>("JwtConfig:Key")
              ?? throw new InvalidOperationException("No JWT Key Was Found");
var key = Encoding.ASCII.GetBytes(Configkey);
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false
        };

        // Read token from cookie
        options.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                context.Token = context.Request.Cookies["BearerToken"];
                return Task.CompletedTask;
            }
        };
    });

//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie()
//.AddJwtBearer(jwtOptions =>
//{
//    var key = builder.Configuration.GetValue<string>("JwtConfig:Key") 
//                      ?? throw new InvalidOperationException("No JWT Key Was Found");
//    var keyBytes = Encoding.ASCII.GetBytes(key);
//    jwtOptions.SaveToken = true;
//    jwtOptions.TokenValidationParameters = new TokenValidationParameters
//    {
//        IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
//        ValidateLifetime = true,
//        ValidateAudience = false,
//        ValidateIssuer = false,
//        ClockSkew = TimeSpan.Zero
//    };
//});
builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".MyApp.Session";
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddAuthorization();
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
});

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();

