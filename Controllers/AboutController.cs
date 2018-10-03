using Microsoft.AspNetCore.Mvc;

namespace TestNetCoreWebApp.Controllers
{
	[Route("company/[controller]/[action]")]
    public class AboutController : Controller
    {
    	public string Phone()
    	{
    		return "1-999-777-8888";
    	}

    	public string Address()
    	{
    		return "Somewhere in south florida";
    	}
	
    }
}