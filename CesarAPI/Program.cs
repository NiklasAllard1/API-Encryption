using System;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Welcome to Cesar decryption!");
                });

                endpoints.MapGet("/krypterad", async context =>
                {
                    string originalText = context.Request.Query["text"];
                    if (string.IsNullOrEmpty(originalText))
                    {
                        await context.Response.WriteAsync("Please provide a valid 'text' parameter.");
                        return;
                    }

                    string encryptedText = Encrypt(originalText);

                    await context.Response.WriteAsync(encryptedText);
                });

                endpoints.MapGet("/avkrypterad", async context =>
                {
                    string ciphertext = context.Request.Query["ciphertext"];
                    if (string.IsNullOrEmpty(ciphertext))
                    {
                        await context.Response.WriteAsync("Please provide a valid 'ciphertext' parameter.");
                        return;
                    }

                    string decryptedText = Decrypt(ciphertext);

                    await context.Response.WriteAsync(decryptedText);
                });
            });
        }

        public string Encrypt(string plaintext)
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

public string Decrypt(string ciphertext)
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

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
