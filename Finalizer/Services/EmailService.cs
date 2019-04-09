using Microsoft.Extensions.Logging;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalizer.Services
{
    public class EmailService : Microsoft.AspNetCore.Identity.UI.Services.IEmailSender
    {
        private ISendGridClient _sendGridClient;
        private ILogger<EmailService> _logger;

        public EmailService(ISendGridClient sendGridClient, ILogger<EmailService> logger)
        {
            _sendGridClient = sendGridClient;
            _logger = logger;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            try
            {
                var msg = new SendGridMessage()
                {
                    From = new EmailAddress("orders@gmail.com", "The Finalizer"),
                    Subject = subject,
                    PlainTextContent = htmlMessage,
                    HtmlContent = htmlMessage
                };
                msg.AddTo(new EmailAddress(email));
                msg.SetClickTracking(false, false);
                Response response = await _sendGridClient.SendEmailAsync(msg);
                if (response.StatusCode != System.Net.HttpStatusCode.Accepted)
                {
                    throw new ApplicationException("SendGrid error: " + await response.Body.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
               
            }
        }
    }
}