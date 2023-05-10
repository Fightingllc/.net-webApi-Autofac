namespace AutofacDemo_Api
{
    public interface ITestService<T>
    {
        string GetName();
    }
    public interface ITestService
    {
        string GetName();
    }
}