namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2024, 05, 28, 01, 53, 00);
            Console.WriteLine(dt.ElapsedTime());

            DateTime MeuNascimento = new DateTime(2004, 03, 02, 07, 43, 00);
            Console.WriteLine(MeuNascimento.ElapsedTime());

            DateTime dt3 = new DateTime(2003, 09, 19, 09, 00, 00);
            Console.WriteLine(dt3.ElapsedTime());

            DateTime dt4 = new DateTime(1968, 08, 28, 10, 00, 00);
            Console.WriteLine(dt4.ElapsedTime());

            DateTime dt5 = new DateTime(1970, 09, 19, 09, 00, 00);
            Console.WriteLine(dt5.ElapsedTime());

        }
    }
}
