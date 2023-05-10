namespace AutofacDemo_Api;

public class IocService:IIocService
{

    // 正常注入
    // public IocService(IUserService userService)
    //  {
    //  }

    // 属性注入
    public IUserService UserService {get;set;}
}
