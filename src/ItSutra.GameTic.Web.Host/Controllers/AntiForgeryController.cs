using Microsoft.AspNetCore.Antiforgery;
using ItSutra.GameTic.Controllers;

namespace ItSutra.GameTic.Web.Host.Controllers
{
    public class AntiForgeryController : GameTicControllerBase
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
