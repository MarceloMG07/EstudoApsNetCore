using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAppMvcScaffold.Data;
// O builder � respons�vel por fornecer os m�todos de controle
// dos servi�os e demais funcionalidades na configura��o da App
var builder = WebApplication.CreateBuilder(args);
// O builder � respons�vel por fornecer os m�todos de controle
// dos servi�os e demais funcionalidades na configura��o da App
builder.Services.AddDbContext<WebAppMvcScaffoldContext>(options =>
// O builder � respons�vel por fornecer os m�todos de controle
// dos servi�os e demais funcionalidades na configura��o da App
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebAppMvcScaffoldContext") ?? throw new InvalidOperationException("Connection string 'WebAppMvcScaffoldContext' not found.")));

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

// Note a ligeira mudan�a na declara��o da rota padr�o
// No caso de precisar mapear mais de uma rota duplique o c�digo abaixo
app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");

// Essa linha precisa sempre ficar por �ltimo na configura��o do request pipeline
app.Run();
