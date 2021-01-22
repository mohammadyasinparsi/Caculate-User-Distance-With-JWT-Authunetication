# aspnet-core-3-signup-verification-api
To keep the api code as simple as possible, it is configured to use the EF Core InMemory database.

Starting in debug mode
You can also start the application in debug mode in VS Code by opening the project root folder in VS Code and pressing F5 or by selecting Debug -> Start Debugging from the top menu.

Before running make sure that you update the Secret property in the appsettings.json file, it is used to sign and verify JWT tokens for authentication, change it to a random string to ensure nobody else can generate a JWT with the same secret and gain unauthorized access to your api. A quick and easy way is join a couple of GUIDs together to make a long random string (e.g. from https://www.guidgenerator.com/).

Configure SMTP settings for email within the AppSettings section in the /appsettings.json file. For testing you can create a free account in one click at https://ethereal.email/ and copy the options below the title SMTP configuration.
