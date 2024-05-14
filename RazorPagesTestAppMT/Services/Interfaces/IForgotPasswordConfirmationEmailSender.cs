namespace RazorPagesTestAppMT.Services.Interfaces
{
    public interface IForgotPasswordConfirmationEmailSender
    {
        Task SendResetPasswordEmailAsync(string email, string callbackUrl);
    }
}
