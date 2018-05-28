using Microsoft.AspNetCore.Antiforgery;
using Clare.ECommerce.Controllers;

namespace Clare.ECommerce.Web.Host.Controllers
{
    public class AntiForgeryController : ECommerceControllerBase
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
