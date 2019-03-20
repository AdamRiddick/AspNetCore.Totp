using System;
using System.Linq;
using AspNetCore.Totp.Interface;

namespace AspNetCore.Totp
{
    public class TotpValidator: ITotpValidator
    {
        private readonly ITotpGenerator totpGenerator;

        public TotpValidator(ITotpGenerator totpGenerator)
        {
            this.totpGenerator = totpGenerator;
        }

        public bool IsValid(string accountSecretKey, int clientTotp, int timeToleranceInSeconds = 60)
        {
            var codes = this.totpGenerator.GetValidTotps(accountSecretKey, TimeSpan.FromSeconds(timeToleranceInSeconds));
            return codes.Any(c => c == clientTotp);
        }
    }
}