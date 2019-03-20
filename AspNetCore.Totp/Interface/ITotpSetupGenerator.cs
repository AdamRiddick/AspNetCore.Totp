using AspNetCore.Totp.Interface.Models;

namespace AspNetCore.Totp.Interface
{
    public interface ITotpSetupGenerator
    {
        /// <summary>
        /// Generates a <see cref="TotpSetup"/> for a user so they can setup a TOTP Authenticator app.
        /// </summary>
        /// <param name="issuer">Your app name or company for example.</param>
        /// <param name="accountIdentity">Name, Email or Id of the user, without spaces, this will be shown in the authenticator app.</param>
        /// <param name="accountSecretKey">A secret key which will be used to generate one time passwords. This key is the same needed for validating a passed TOTP.</param>
        /// <param name="qrCodePixelsPerModule">The amount of pixels to which each black and white block of the QR code will be drawn. Default is 20px.</param>
        /// <returns><see cref="TotpSetup"/>.</returns>
        TotpSetup Generate(string issuer, string accountIdentity, string accountSecretKey, int qrCodePixelsPerModule = 20);
    }
}