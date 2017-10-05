using System;


namespace Cipher
{
	class Program
	{
		static void Main(string[] args)
		{
			string cipher = Cipher("Hello", 6);
			Console.WriteLine(cipher);

			string decipher = Decipher(cipher, 6);
			Console.WriteLine(decipher);

			Console.ReadKey();
		}
		static string Cipher(string OriginalText, int Shift)
		{
			char[] originalTextArr = OriginalText.ToCharArray();
			int FirstCharIdx = 'a';
			int Offset = ('Z' - 'a') + 1;

			for (int i = 0; i < originalTextArr.Length; i++)
			{
				char OldCharIdx = originalTextArr[i];
				int OldIdxInAlphabet = OldCharIdx - FirstCharIdx;
				int NewIdxInAlphabet = (OldIdxInAlphabet + Shift) % Offset;

				char NewCharIdx = (char)(FirstCharIdx + NewIdxInAlphabet);
				originalTextArr[i] = NewCharIdx;
			}

			return new string(originalTextArr);
		}

		static string Decipher(string CipheredText, int Shift)
		{
			return Cipher(CipheredText, Shift * -1);
		}
	}
}
