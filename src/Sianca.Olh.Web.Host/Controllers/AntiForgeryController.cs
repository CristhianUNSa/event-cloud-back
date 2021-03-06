using Microsoft.AspNetCore.Antiforgery;
using Sianca.Olh.Controllers;

namespace Sianca.Olh.Web.Host.Controllers
{
    public class AntiForgeryController : OlhControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
