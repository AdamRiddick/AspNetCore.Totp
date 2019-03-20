# AspNetCore.TotpGenerator
An ASP.NET Core library for generating and validating one time passwords for authenticator apps.

Forked from the original at https://github.com/damirkusar/AspNetCore.Totp to solve the issue that Google Image Charts has been deprecated.

# Getting Started
	```
	Install-Package AspNetCore.TotpGenerator
	```

	Use TotpSetupGenerator class to generate the QR Code to show to user.
	Use TotpGenerator class to generate a one time password like the Google authenticator does.
	Use TotpValidator class to validate the one time password supplied by the user. 

# License
[MIT License](License.md)