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
            var result = _caesarcipher.CipherThisText("plant", 1);
            Assert.Equal("qmbou", result);
        }

        [Fact]
        public void CipherThisText_InputShiftFactorMinorThan0_ReturnError()
        {
            //Arrange
            var shiftFactor = -1;

            //Act
            var result = _caesarcipher.CipherThisText("plant", shiftFactor);

            //Assert
            Assert.Equal("ERROR", result);
        }

        [Fact]
        public void CipherThisText_WorkWithUpperCaseAndSymbols_ReturnString()
        {
            var word = "PlaNT!!";
            var result = _caesarcipher.CipherThisText(word, 1);
            Assert.Equal("QmbOU!!", result);
        }

        [Fact]
        public void CipherThisText_WrapAlphabet_ReturnString()
        {
            var word = "What a string!";
            var result = _caesarcipher.CipherThisText(word, 5);
            Assert.Equal("Bmfy f xywnsl!", result);
        }
    }
}
