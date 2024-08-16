using UserService.Core.Models.EmailModels;

namespace UserService.Core.Templates.EmailTemplates;
public partial class EmailTemplates
{
  public EmailContent BuildMFAContent(string code)
  {
    // Describe template
    string subject = $"[{_settings.DisplayName}] - A MFA Code have sent to you";
    string body = @$"
      <!DOCTYPE html>
      <html lang=""en"">
        <head>
          <meta charset=""UTF-8"" />
          <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
          <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
          <title>Document</title>
          <style>
            .container {{
              width: 500px;
              font-family: ""Segoe UI"", Tahoma, Geneva, Verdana, sans-serif;
              background-color: whitesmoke;
              border-radius: 4px;
              margin: auto;
            }}
            .code-box {{
              width: 256px;
              height: 56px;
              background-color: #0100cb;
              border-radius: 4px;
            }}
            .code-text {{
              font-size: xx-large;
              font-weight: bold;
              color: white;
              text-align: center;
              line-height: 56px;
            }}
          </style>
        </head>
        <body>
          <table class=""container"" cellspacing=""0"" cellpadding=""16"" border=""0"">
            <tr>
              <td>
                <h1 style=""color: #11285b"">{_settings.DisplayName}</h1>
                <p>Thank you for using our Website.</p>
                <p>Your Multi-Factor Authentication (MFA) code is:</p>
                <table class=""code-box"" cellspacing=""0"" cellpadding=""0"" border=""0"">
                  <tr>
                    <td class=""code-text"">{code}</td>
                  </tr>
                </table>
                <p>Please enter this code to complete your authentication process.</p>
                <p>Thank you,</p>
                <p>{_settings.DisplayName}</p>
              </td>
            </tr>
          </table>
        </body>
      </html>
    ";

    // Build email content
    var result = new EmailContent
    {
      Subject = subject,
      Body = body
    };

    // Returns
    return result;
  }
}
