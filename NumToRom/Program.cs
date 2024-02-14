using System.Text;

public static class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Please enter a number to convert to Roman numerals: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string numRoman = NumToRoman(number);
            Console.WriteLine("The Roman number is: " + numRoman);
        }
        catch (Exception)
        {
            Console.WriteLine("Ha ocurrido un error formateando el numero");
        }
    }

    public static string NumToRoman(int num)
    {
        if (num < 1 || num > 3999)
            return "Número ingresado fuera de rango";

        StringBuilder romanNumber = new StringBuilder();
        
        var romanNumList  = new[]
        {
            new {Arabic = 1000, Roman = "M"},
            new {Arabic = 900, Roman = "CM"},
            new {Arabic = 500, Roman = "D"},
            new {Arabic = 400, Roman = "CD"},
            new {Arabic = 100, Roman = "C"},
            new {Arabic = 90, Roman = "XC"},
            new {Arabic = 50, Roman = "L"},
            new {Arabic = 40, Roman = "XL"},
            new {Arabic = 10, Roman = "X"},
            new {Arabic = 9, Roman = "IX"},
            new {Arabic = 5, Roman = "V"},
            new {Arabic = 4, Roman = "IV"},
            new {Arabic = 1, Roman = "I"}
        };

        foreach (var numeral in romanNumList)
        {
            while (num >= numeral.Arabic)
            {
                num -= numeral.Arabic;
                romanNumber.Append(numeral.Roman);
            }
        }

        return romanNumber.ToString();
    }
}
