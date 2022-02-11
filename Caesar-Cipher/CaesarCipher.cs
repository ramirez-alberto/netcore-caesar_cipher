using System;

namespace Caesar_Cipher
{
    public class CaesarCipher
    {
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private string cipherWord = string.Empty;
        public string CipherThisText(string word, int shiftFactor)
        {
            if (shiftFactor < 0) return "ERROR";
            foreach (var character in word)
            {
                char cipherChar = character;
                int indexCharInAlphabet =
                        alphabet.IndexOf(character, StringComparison.CurrentCultureIgnoreCase);
                if (indexCharInAlphabet >= 0)
                {
                    int shiftChar =
                        (indexCharInAlphabet + shiftFactor) > alphabet.Length
                        ? (indexCharInAlphabet + shiftFactor) - alphabet.Length
                        : indexCharInAlphabet + shiftFactor;

                    if (char.IsLower(character))
                    {
                        cipherChar = alphabet[shiftChar];
                    }
                    else if (char.IsUpper(character))
                    {
                        cipherChar = alphabet.ToUpper()[shiftChar];
                    }
                }
                cipherWord = string.Concat(cipherWord, cipherChar.ToString());
            }
            return cipherWord;

            throw new NotImplementedException("Not implemented.");
        }
    }
}
