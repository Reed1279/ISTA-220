using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security;

namespace Password

{
	class Program
	{
		static string Encript(string value)
		{
			using (MD5CryptoServiceProvider crypto = new MD5CryptoServiceProvider())
			{
				UTF8Encoding utf8 = new UTF8Encoding();
				byte[] data = crypto.ComputeHash(utf8.GetBytes(value));
				return Convert.ToBase64String(data);
			}
		}

		static SecureString NewPassword()
		{
			Console.WriteLine("Please enter your username: ");
			string username = Console.ReadLine();
			Console.WriteLine("\nEnter a password: ");
			SecureString pass = new SecureString();
			ConsoleKeyInfo key;

			do
			{
				key = Console.ReadKey(true);
				if (!char.IsControl(key.KeyChar))
				{
					pass.AppendChar(key.KeyChar);
					Console.Write("*");
				}

				else
				{
					if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
					{
						pass.RemoveAt(pass.Length - 1);
						Console.Write("\b \b");
					}
				}
			}

			while (key.Key != ConsoleKey.Enter);
			{
				return pass;
			}
		}

		static void Main(string[] args)
			{
			SecureString pass = NewPassword();
			string password = new System.Net.NetworkCredential(string.Empty, pass).Password;
			Console.WriteLine("\nBecause the guy behind you wants to see your password");

			Console.WriteLine("We will show him your encrypted password:");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" " + Program.Encript(password));
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("\nThe password you entered was:");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(" " + password);
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("\nWould you like to change your password?");			
			Console.ReadLine();
		}
	}
}

