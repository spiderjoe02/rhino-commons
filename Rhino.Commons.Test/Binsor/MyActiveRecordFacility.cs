using Castle.Core.Configuration;
using Castle.Facilities.ActiveRecordIntegration;

namespace Rhino.Commons.Test.Binsor
{
    public class MyActiveRecordFacility : ActiveRecordFacility
    {
        public IConfiguration GetFacilityConfig()
        {
            return base.FacilityConfig;
        }
    }
}