using Autofac;
using Autofac.Extensions.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterAssemblyModules(typeof(ModulesAPI.CommandsModule).Assembly);
    containerBuilder.RegisterAssemblyModules(typeof(ModulesBLL.ServicesModule).Assembly);
    containerBuilder.RegisterAssemblyModules(typeof(ModulesDAL.UnitOfWorkModule).Assembly);
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

if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.UseAuthentication();
app.MapControllers();
app.Run();

