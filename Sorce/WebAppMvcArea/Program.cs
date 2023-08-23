// O builder � respons�vel por fornecer os m�todos de controle
// dos servi�os e demais funcionalidades na configura��o da App
using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);

// Adicionando suporte a mudan�a de conven��o da rota das areas.
//builder.Services.Configure<RazorViewEngineOptions>(options =>
//{
//    options.AreaViewLocationFormats.Clear();
//    options.AreaViewLocationFormats.Add("/Modulos/{2}/Views/{1}/{0}.cshtml");
//    options.AreaViewLocationFormats.Add("/Modulos/{2}/Views/Shared/{0}.cshtml");
//    options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
//});

// Daqui para baixo � conte�do que vinha dentro do m�todo  ConfigureServices() na antiga Startup.cs
// Nesta area adicionamos servi�os ao pipeline

// Essa � a nova forma de adicionar o MVC ao projeto
// N�o se usa mais services.AddMvc();
builder.Services.AddControllersWithViews();

// Essa linha precisa sempre ficar por �ltimo na configura��o dos servi�os
var app = builder.Build();


// Daqui para baixo � conte�do que vinha dentro do m�todo Configure() na antiga Startup.cs
// Aqui se configura comportamentos do request dentro do pipeline
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

//app.MapControllerRoute("areas","{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute("AreaProdutos", "Produtos", "Produtos/{controller=Cadastro}/{action=Index}/{id?}");
app.MapAreaControllerRoute("AreaVendas", "Vendas", "Vendas/{controller=Cadastro}/{action=Index}/{id?}");

// Note a ligeira mudan�a na declara��o da rota padr�o
// No caso de precisar mapear mais de uma rota duplique o c�digo abaixo
app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");

// Essa linha precisa sempre ficar por �ltimo na configura��o do request pipeline
app.Run();
