using System;

namespace Caesar_Cipher
{
    public class CaesarCipher
    {
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private string cipherWord = "";
        public string CipherThisText(string word,int shiftFactor)
        {
            foreach(var character in word){
                int indexCharInAlphabet = alphabet.IndexOf(character);
                char charByShiftFactor = alphabet[indexCharInAlphabet + shiftFactor];
                cipherWord += charByShiftFactor.ToString();
            }
            return cipherWord;

            throw new NotImplementedException("Not implemented.");
        }
    }
}
