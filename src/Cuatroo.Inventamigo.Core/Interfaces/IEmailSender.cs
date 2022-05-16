﻿using System.Threading.Tasks;

namespace Cuatroo.Inventamigo.Core.Interfaces;

public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}
