using Xunit;
using Caesar_Cipher;

namespace Caesar_Cipher.Tests
{
    public class CaesarCipher_CipherThisTextShouldReturn
    {
        private readonly CaesarCipher _caesarcipher;

        public CaesarCipher_CipherThisTextShouldReturn()
        {
            _caesarcipher = new CaesarCipher();
        }
        [Fact]
        public void CipherThisText_InputAStringAndShiftFactorBy1_ReturnNewString()
        {
            var caesarcipher = new CaesarCipher();
            var result = caesarcipher.CipherThisText("plant", 1);

            Assert.Equal("qmbou", result);
        }

        [Fact]
        public void CipherThisText_InputShiftFactorMinorThan0_ReturnThrowException()
        {
            //Given

            //When

            //Then
        }
    }
}
