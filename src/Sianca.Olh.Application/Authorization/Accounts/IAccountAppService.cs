using System.Threading.Tasks;
using Abp.Application.Services;
using Sianca.Olh.Authorization.Accounts.Dto;

namespace Sianca.Olh.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
