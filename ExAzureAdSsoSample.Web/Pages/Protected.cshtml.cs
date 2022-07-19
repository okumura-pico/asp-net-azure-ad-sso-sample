using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ExAzureAdSsoSample.Web.Pages
{
    public class ProtectedModel : PageModel
    {
        private readonly ILogger<ProtectedModel> _logger;

        public ProtectedModel(ILogger<ProtectedModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
