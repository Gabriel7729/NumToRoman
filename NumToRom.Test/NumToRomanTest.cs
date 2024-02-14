namespace NumToRom.Test
{
    public class NumToRomanTest
    {
        [Fact]
        public void Should_Valid_Numer_2023_To_Return_MMXXIII()
        {
            Assert.Equal("MMXXIII", Program.NumToRoman(2023));
        }

        [Fact]
        public void Should_Valid_Numer_4_To_Return_IV()
        {
            Assert.Equal("IV", Program.NumToRoman(4));
        }

        [Fact]
        public void Should_Valid_Numer_1994_To_Return_MCMXCIV()
        {
            Assert.Equal("MCMXCIV", Program.NumToRoman(1994));
        }

        [Fact]
        public void Should_Return_ErrorMessage_If_Number_Is_Out_Of_Range()
        {
            Assert.Equal("Número ingresado fuera de rango", Program.NumToRoman(5000));
        }

        [Fact]
        public void Should_Valid_Numer_5_To_Return_V()
        {
            Assert.Equal("V", Program.NumToRoman(5));
        }
    }
}