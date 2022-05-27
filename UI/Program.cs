using Autofac;
using FluentValidation.AspNetCore;
using Autofac.Extensions.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection;
using CommandsAndQueries;
using UI;
using Microsoft.AspNetCore.Identity;
using Entities;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddIdentityServer()
//    .AddInMemoryApiResources(new List)

//builder.Services.AddDefaultIdentity<IdentityUser>(options =>
//    {
//        options.Password.RequireDigit = false;
//        options.Password.RequiredLength = 5;
//        options.Password.RequireUppercase = false;
//        options.User.RequireUniqueEmail = true;
//        options.SignIn.RequireConfirmedEmail = false;
//    })
//    .AddRoles<IdentityRole>()
//    .AddEntityFrameworkStores<Database.DatabaseContext>();

builder.Services.AddControllers();

builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddRazorPages();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Services.AddFluentValidation(fv =>
    fv.RegisterValidatorsFromAssembly(typeof(Program).Assembly));

builder.Services.AddSwaggerGen();

builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterAssemblyModules(typeof(CommandsAndQueriesModule).Assembly);
    containerBuilder.RegisterAssemblyModules(typeof(ModulesDAL.DatabaseModule).Assembly);
    containerBuilder.RegisterModule<ModelMappingModule>();
    containerBuilder.RegisterMediatR(typeof(Program).Assembly);
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();

app.UseSwaggerUI(config =>
{
    //config.RoutePrefix = string.Empty;
    //config.SwaggerEndpoint("swagger/v1/swagger.json", "Resumes&Vacancies API");
});

app.UseRouting();
//app.UseIdentityServer();
app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors("AllowAll");
app.UseAuthentication();
app.MapControllers();
app.MapRazorPages();
app.Run();

