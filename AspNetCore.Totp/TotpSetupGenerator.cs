using System;
using System.Text;
using AspNetCore.Totp.Helper;
using AspNetCore.Totp.Interface;
using AspNetCore.Totp.Interface.Models;
using QRCoder;
using static QRCoder.PayloadGenerator;
using static QRCoder.PayloadGenerator.OneTimePassword;

namespace AspNetCore.Totp
{
    public class TotpSetupGenerator : ITotpSetupGenerator
    {
        public TotpSetup Generate(string issuer, string accountIdentity, string accountSecretKey, int qrCodePixelsPerModule = 20)
        {
            Guard.NotNull(issuer);
            Guard.NotNull(accountIdentity);
            Guard.NotNull(accountSecretKey);

            accountIdentity = accountIdentity.Replace(" ", string.Empty);
            var encodedSecretKey = Base32.Encode(accountSecretKey);

            var qrCodeImage = string.Empty;
            try
            {
                var oneTimePassword = new OneTimePassword
                {
                    Secret = encodedSecretKey,
                    Issuer = issuer,
                    Label = accountIdentity,
                };

                qrCodeImage = GetQrImage(oneTimePassword, qrCodePixelsPerModule);
            }
            catch (Exception)
            {
                // Allow execution to continue, as we can still return the manual setup key.
            }

            var totpSetup = new TotpSetup
            {
                QrCodeImage = qrCodeImage,
                ManualSetupKey = encodedSecretKey
            };

            return totpSetup;
        }

        private string GetQrImage(OneTimePassword oneTimePassword, int qrCodePixelsPerModule)
        {
            var qrCodeImageStringBuilder = new StringBuilder();
            qrCodeImageStringBuilder.Append("data:image/png;base64,");

            var payload = oneTimePassword.ToString();

            var qrCodeGenerator = new QRCodeGenerator();
            var qrCodeData = qrCodeGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q, true);
            var qrCode = new Base64QRCode(qrCodeData);
            var base64QrGraphic = qrCode.GetGraphic(qrCodePixelsPerModule);
            qrCodeImageStringBuilder.Append(base64QrGraphic);

            return qrCodeImageStringBuilder.ToString();
        }
    }
}