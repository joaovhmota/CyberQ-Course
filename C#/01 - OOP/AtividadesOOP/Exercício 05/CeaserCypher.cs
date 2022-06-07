using System;

namespace Exercício_05
{
	internal class CeaserCypher
	{
		private string _InputString = "";
		private string _DecrypedString = "";
		private string _EncriptedString = "";
		
		public CeaserCypher Update(string str)
		{
			_InputString = str.ToLower();
			return this;
		}

		public string Encrypt(int key = 1)
		{
			foreach(Char c in _InputString)
			{
				int ascii = c;
				if (c + key <= 122)
					_EncriptedString += (char)(ascii + key);
				else
					_EncriptedString += (char)(ascii % key) + 96;
			}
			return _EncriptedString;
		}

		public string Decrypt(int key = 1)
		{
			foreach(Char c in _InputString)
			{
				int ascii = c;
				if (c - key >= 97)
				{
					_DecrypedString += (char) (ascii - key);
				}
				else
					_DecrypedString += (char)(ascii + 26 - key);
			}
			return _DecrypedString;
		}
	}
}
