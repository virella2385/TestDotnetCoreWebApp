using Microsoft.Extensions.Configuration;

namespace TestNetCoreWebApp
{
	// this is just to test commit in https
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
    	private IConfiguration _conf;

    	public Greeter(IConfiguration conf)
    	{
    		_conf = conf;
    	}

    	public string GetMessageOfTheDay()
    	{
    		return _conf["Greeting"];
    	}
    }
}