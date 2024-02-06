using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.Text;

namespace API
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); // Lägg till UseRouting här

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Welcome to Cesar cipher API!");
                });

                endpoints.MapGet("/encrypt", async context =>
                {
                    string originalText = context.Request.Query["text"];
                    if (string.IsNullOrEmpty(originalText))
                    {
                        await context.Response.WriteAsync("Please provide a valid 'text' parameter.");
                        return;
                    }

                    string encryptedText = CesarCipher.Encrypt(originalText);

                    await context.Response.WriteAsync(encryptedText);
                });

                endpoints.MapGet("/decrypt", async context =>
                {
                    string ciphertext = context.Request.Query["cipher"];
                    if (string.IsNullOrEmpty(ciphertext))
                    {
                        await context.Response.WriteAsync("Please provide a valid 'cipher' parameter.");
                        return;
                    }

                    string decryptedText = CesarCipher.Decrypt(ciphertext);

                    await context.Response.WriteAsync(decryptedText);
                });
            });
        }
    }

    public static class CesarCipher
    {
        public static string Encrypt(string plaintext)
        {
            StringBuilder encryptedText = new StringBuilder();
            bool use3Steps = true;

            foreach (char c in plaintext)
            {
                int shift = use3Steps ? 3 : 5;

                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char shiftedChar = (char)(((c - baseChar + shift) % 26) + baseChar);
                    encryptedText.Append(shiftedChar);
                }
                else
                {
                    encryptedText.Append(c);
                }

                use3Steps = !use3Steps; // Växla mellan 3 och 5 steg
            }

            return encryptedText.ToString();
        }

        public static string Decrypt(string ciphertext)
        {
            StringBuilder decryptedText = new StringBuilder();
            bool use3Steps = true;

            foreach (char c in ciphertext)
            {
                int shift = use3Steps ? 3 : 5;

                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char shiftedChar = (char)(((c - baseChar - shift + 26) % 26) + baseChar);
                    decryptedText.Append(shiftedChar);
                    use3Steps = !use3Steps; // Växla mellan 3 och 5 steg för nästa tecken
                }
                else
                {
                    decryptedText.Append(c);
                }
            }

            return decryptedText.ToString();
        }
    }
}
