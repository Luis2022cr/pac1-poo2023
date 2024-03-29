using GestionRecursosHumanos.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IRepositorioCargos, RepositorioCargos>();
builder.Services.AddTransient<IRepositorioEmpleados, RepositorioEmpleados>();
builder.Services.AddTransient<IRepositorioSalarios, RepositorioSalarios>();
builder.Services.AddTransient<IRepositorioDepartamentos, RepositorioDepartamentos>();
builder.Services.AddTransient<IRepositorioCapacitaciones, RepositorioCapacitaciones>();
builder.Services.AddTransient<IServicioUsuarios, ServicioUsuarios>();

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
