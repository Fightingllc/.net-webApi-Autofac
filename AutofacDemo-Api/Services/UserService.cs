namespace AutofacDemo_Api;

public class UserService: IUserService
{
    public string GetUserName()
    {
        return "Morning";
    }

    public string GetUserAge()
    {
        return "233";
    }
}
