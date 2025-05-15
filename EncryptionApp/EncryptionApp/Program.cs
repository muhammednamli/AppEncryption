using System;
using System.Diagnostics;

class Program
{
    const string correctPassword = "1234567890"; // Buraya kendi şifreni yaz

    static void Main()
    {
        Console.Title = "App Encryption";
        

        while (true)
        {
            Console.Write("Şifreyi girin: ");
            string input = ReadPassword();

            if (input == correctPassword)
            {
                Console.WriteLine("\nŞifre doğru. Uygulama başlatılıyor...");
                try
                {
                    Process.Start("xxxxxxxxxxxxxx"); // Uygulamanın Yolunu buraya yaz
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Uygulama başlatılamadı: " + ex.Message);
                }
                break; 
            }
            else
            {
                Console.WriteLine("\nHatalı şifre! Tekrar deneyin.\n");
            }
        }
    }
    static string ReadPassword()
    {
        string password = "";
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(intercept: true);

            if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                Console.Write("\b \b");
            }
            else if (!char.IsControl(key.KeyChar))
            {
                password += key.KeyChar;
                Console.Write("*");
            }

        } while (key.Key != ConsoleKey.Enter);

        return password;
    }
}
