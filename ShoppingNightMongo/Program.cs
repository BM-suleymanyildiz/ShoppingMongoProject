using Microsoft.Extensions.Options;
using ShoppingNightMongo.Services.CategoryServices;
using ShoppingNightMongo.Services.CustomerServices;
using ShoppingNightMongo.Services.MailSenderService;
using ShoppingNightMongo.Services.ProductDetailService;
using ShoppingNightMongo.Services.ProductServices;
using ShoppingNightMongo.Services.SliderServices;
using ShoppingNightMongo.Settings;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IMailSender, MailSender>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IProductDetailService, ProductDetailService>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettingsKey"));


builder.Services.AddScoped<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
