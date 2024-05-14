using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTestAppMT.Services.Interfaces;

namespace RazorPagesTestAppMT.Pages.Account
{
    public class ForgotPasswordConfirmationModel : PageModel
    {
        private readonly IForgotPasswordConfirmationEmailSender _emailSender;

        public ForgotPasswordConfirmationModel(IForgotPasswordConfirmationEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public async Task<IActionResult> OnGetAsync(string email, string callbackUrl)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(callbackUrl))
            {
                return RedirectToPage("/Index");
            }

            await _emailSender.SendResetPasswordEmailAsync(email, callbackUrl);

            return Page();
        }
    }
}
