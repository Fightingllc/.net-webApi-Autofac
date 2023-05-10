using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutofacDemo_Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 原始容器
// builder.Services.AddTransient<IUserService,UserService>();

// 将原始容器替换会Autofac 
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => {
    // autofac中也可以使用生命周期
    // PropertiesAutowired允许属性注入
    // builder.RegisterType<UserService>().As<IUserService>().SingleInstance();
    // builder.RegisterType<IocService>().As<IIocService>().InstancePerLifetimeScope().PropertiesAutowired();
    builder.AddAutofacDemoApiModule();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
