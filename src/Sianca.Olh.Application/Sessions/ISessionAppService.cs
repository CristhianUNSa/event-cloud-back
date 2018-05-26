using System.Threading.Tasks;
using Abp.Application.Services;
using Sianca.Olh.Sessions.Dto;

namespace Sianca.Olh.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
