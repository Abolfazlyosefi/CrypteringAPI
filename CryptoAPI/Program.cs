var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Skapa instans av CipherService
var cipherService = new CryptoAPI.Services.CipherService();

// V�lkomst-API med instruktioner
app.MapGet("/", () => "Welcome to API for Caesar Cipher!\n\n" +
    "For encrypting use: /encrypt?input=<text>\n" +
    "For decrypting use: /decrypt?dinput=<text>");

// Endpoint f�r kryptering
app.MapGet("/encrypt", (string input) => cipherService.Encrypt(input));

// Endpoint f�r avkryptering
app.MapGet("/decrypt", (string dinput) => cipherService.Decrypt(dinput));

app.Run();
