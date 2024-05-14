using RazorPagesTestAppMT.Services.Interfaces;
using System.Text.Encodings.Web;

namespace RazorPagesTestAppMT.Services.Implementations
{
    public class ForgotPasswordConfirmationEmailSender : IForgotPasswordConfirmationEmailSender
    {
        private readonly IEmailSender _emailSender;

        public ForgotPasswordConfirmationEmailSender(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public async Task SendResetPasswordEmailAsync(string email, string callbackUrl)
        {
            await _emailSender.SendEmailAsync(
                email,
                "Reset Password",
                $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
        }
    }
}
