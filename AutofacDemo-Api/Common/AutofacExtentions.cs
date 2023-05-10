using Autofac;

namespace AutofacDemo_Api;

public static class AutofacExtentions
{
    public static void AddAutofacDemoApiModule(this ContainerBuilder builder)
    {
         // autofac中也可以使用生命周期
    // PropertiesAutowired允许属性注入
    ITestService<int> u = new TestService<int>();
    var a = typeof(TestService<int>).IsAssignableTo(typeof(ITestService<int>));
    builder.RegisterGeneric(typeof(TestService<>)).As(typeof(ITestService<>));
    builder.RegisterType<UserService>().As<IUserService>().SingleInstance();
    builder.RegisterType<IocService>().As<IIocService>().InstancePerLifetimeScope().PropertiesAutowired();
    }
}
