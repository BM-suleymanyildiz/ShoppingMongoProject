﻿namespace ShoppingNightMongo.Services.MailSenderService
{
    public interface IMailSender
    {
        Task SendEmailAsync(string email, string subject, string message);

    }
}
