using SQLApplication.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

///Allows to connect with Azure App configuration
var connectionString = "Endpoint=https://appconfigforapp.azconfig.io;Id=+dwR;Secret=duLts2WatRk7Eqb6L50u3D/d1BiBHxqqLrVL0CF1H20=";


builder.Host.ConfigureAppConfiguration(builder =>
{
    builder.AddAzureAppConfiguration(connectionString);
});

/// Allows to connect with Azure App configuration
/// 



builder.Services.AddTransient<IProductService, ProductService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
