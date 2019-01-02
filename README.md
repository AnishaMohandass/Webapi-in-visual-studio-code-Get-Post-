# Webapi-in-visual-studio-code-Get-Post-

Refer these files - Product.cs , ProductService.cs , ProductController.cs

To create new webapi project in Visual Studio code:

   step 1 - Create a new folder (Webapi).
   step 2 - Open cmd prompt and type the command,
      c:\Users\IS7063\Desktop\Webapi>dotnet new webapi
      
      
To build the webapi project:

   c:\Users\IS7063\Desktop\Webapi>dotnet build
   

To run the webapi project:

   c:\Users\IS7063\Desktop\Webapi>dotnet run
   
   
To change localhost portnumber:

1) In project folder, Go to Properties folder.
2) Then open launchSettings.json file,
     "Webapi": {
      "commandName": "Project",
      "launchBrowser": true,
      "launchUrl": "api/values",
      "applicationUrl": "http://localhost:8060",        //change the port number
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
  
