using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;

namespace DateNow.Test.Test;

public class WebApplication : WebApplicationFactory<Program>
{
   protected override IHost CreateHost(IHostBuilder builder)
    {       
        return base.CreateHost(builder);
    }
}