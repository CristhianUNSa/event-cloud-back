using Abp.MultiTenancy;
using Sianca.Olh.Authorization.Users;

namespace Sianca.Olh.MultiTenancy
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
