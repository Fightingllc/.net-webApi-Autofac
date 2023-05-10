using Microsoft.AspNetCore.Mvc;

namespace AutofacDemo_Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IIocService _iocService;

    public WeatherForecastController(IIocService iocService)
    {
        this._iocService = iocService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    [CtmActionFilter]
    public string Get()
    {
        // return _iocService.UserService.GetUserName();

        var b = Check();
        if(b)
          ToCar();
        return null;
    }

    private bool Check()
    {
        return true;
    }
    private string ToCar()
    {
        if(Check())
            return "上车";
        return null;
    }
   
}
