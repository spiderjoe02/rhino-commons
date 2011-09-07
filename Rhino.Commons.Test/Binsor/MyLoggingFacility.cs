using Castle.Core.Configuration;
using Castle.Facilities.Logging;

namespace Rhino.Commons.Test.Binsor
{
    public class MyLoggingFacility : LoggingFacility
    {
        public IConfiguration GetFacilityConfig()
        {
            return base.FacilityConfig;
        }
    }
}