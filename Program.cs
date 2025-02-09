var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Skapa instans av CipherService
var cipherService = new CryptoAPI.Services.CipherService();

// Välkomst-API med instruktioner
app.MapGet("/", () => "Welcome to API for Caesar Cipher!\n\n" +
    "For encrypting use: /encrypt?input=<text>\n" +
    "For decrypting use: /decrypt?dinput=<text>");

// Endpoint för kryptering
app.MapGet("/encrypt", (string input) => cipherService.Encrypt(input));

// Endpoint för avkryptering
app.MapGet("/decrypt", (string dinput) => cipherService.Decrypt(dinput));

app.Run();
