

namespace Mycsconsoleproject
{
    public class test
    {
        public static void Main(String[] args)
        {

            {
                Console.Write("Hej! Skriv in ett nummer först sen enter, sen ett annat nummer så adderas dom! .");



                double Svar = double.Parse(Console.ReadLine());
                double Svar2 = double.Parse(Console.ReadLine());

                Calculator calculator = new Calculator();
                calculator.Add(Svar, Svar2);

                Console.WriteLine(calculator.Add(Svar, Svar2));







            }
        }
    }
}

