namespace AspNetCore.Totp.Interface
{
    public interface ITotpValidator
    {
        /// <summary>
        /// Validates a given TOTP. 
        /// </summary>
        /// <param name="accountSecretKey">User's secret key. Same as used to create the setup.</param>
        /// <param name="clientTotp">Number provided by the user which is to be validated.</param>
        /// <param name="timeToleranceInSeconds">Time tolerance in seconds. Default is 60 to accept 60 seconds before and after now.</param>
        /// <returns><see cref="bool"/>.</returns>
        bool IsValid(string accountSecretKey, int clientTotp, int timeToleranceInSeconds = 60);
    }
}