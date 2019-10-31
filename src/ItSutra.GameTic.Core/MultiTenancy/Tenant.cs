using Abp.MultiTenancy;
using ItSutra.GameTic.Authorization.Users;

namespace ItSutra.GameTic.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
