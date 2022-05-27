using Services;
using UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Конфігурація контейнера сервісів
builder.Services.AddControllersWithViews();
builder.Services.AddUnitOfWork();
builder.Services.AddServices();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Конфігурація черги HTTP запитів
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
