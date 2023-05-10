namespace AutofacDemo_Api;

public class TestService<T>: ITestService<T>
{
    public string GetName()
    {
        return typeof(T).Name;
    }

}
