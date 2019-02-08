using System;


namespace introCsharp
{
    /// <summary>
    /// Demonstrera grunder i C#. 
    /// 
    /// Innehåll:
    /// utskrift till konsoll
    /// if-sats
    /// inläsning från tangentbord
    /// while-slinga
    /// for-slinga
    /// vektor (eng. array)
    /// foreach-slinga
    /// metodanrop
    /// metoddefinition
    /// 
    /// Version: 2019-02-08
    /// Author: Rikard Karlsson
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // att lära: skriva ut text
            // ---------------------------
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // att lära: varaibler
            // --------------------
            // datatyp variabelnamn;
            // variabelnamn = värde;
            //
            // viktigaste datatyperna:
            // int - heltal
            // double - decimaltal
            // String eller string - text
            // char - en bokstav
            // bool - true, false
            //
            // rektangel
            double bredd = 20;
            double höjd = 30;
            double area;
            area = bredd * höjd;
            Console.WriteLine("rektangel");
            Console.WriteLine("bredd: " + bredd);
            Console.WriteLine("höjd: " + höjd);
            Console.WriteLine("area: " + area);
            Console.WriteLine();

            // att lära: inmatning från tangentbordet
            // -----------------------------------
            Console.WriteLine("Vad heter du?");
            String namn = Console.ReadLine();
            Console.WriteLine("Välkommen " + namn + "!");
            Console.WriteLine();

            // att lära: if-sats
            // ----------------------
            // kasta tärning - du behöver inte förstå nästa kodrad nu
            Random randomGenerator = new Random();
            int antalTärningsögon = randomGenerator.Next(1, 7);

            Console.WriteLine("Det kostar en krona att spela tärning. Sexor ger vinst.");
            Console.WriteLine("Tärningen visar: " + antalTärningsögon);

            if (antalTärningsögon == 6)
            {
                Console.WriteLine("Grattis du vann 5kr.");
            }
            else
            {
                Console.WriteLine("Förlust.");
            }

            Console.WriteLine();

            // att lära: if med else if
            // ---------------------------
            // kasta tärning - du behöver inte förstå nästa kodrad nu
            antalTärningsögon = randomGenerator.Next(1, 7);

            Console.WriteLine("Det kostar en krona att spela tärning.");
            Console.WriteLine("Sexor ger storvinst och ettor tröstpris.");
            Console.WriteLine("Tärningen visar: " + antalTärningsögon);

            if (antalTärningsögon == 6)
            {
                Console.WriteLine("Grattis du vann 4kr.");
            }
            else if (antalTärningsögon == 1)
            {
                Console.WriteLine("Grattis du vann 1kr.");
            }
            else
            {
                Console.WriteLine("Förlust.");
            }
            Console.WriteLine();

            // att lära: while med räkare
            // --------------------
            int räknare = 0;
            while (räknare < 5)
            {
                Console.WriteLine("" + räknare);
                räknare = räknare + 1;
            }
            Console.WriteLine();
            // att lära: for-slinga
            // -----------------------
            // Ger samma utskrift som while-slingan ovan.
            for (int i = 0; i < 5; i = i + 1)
            {
                Console.WriteLine("" + räknare);
            }
            
            // att lära: while utan räknare
            // -----------------------------
            // OBS använd Equals för att jämföra text, inte ==
            String input = "j";
            while (input.Equals("j")) 
            {
                Console.WriteLine("Gör något viktigt! ...");
                Console.WriteLine("Vill du fortsätta? j/n");
                input = Console.ReadLine();
            }
            Console.WriteLine("Klart!");
            Console.WriteLine();

            // att lära: vektorer (eng. array)
            // -------------------------------
            // Kallas för fält av vissa författare.
            String[] lista = { "mjölk", "ost", "bröd" };
            Console.WriteLine(lista[0]);
            Console.WriteLine(lista[1]);
            Console.WriteLine(lista[2]);
            Console.WriteLine();

            int[] tal = new int[5];
            tal[0] = 4;
            tal[1] = 1;
            tal[2] = 3;
            tal[3] = 4;
            tal[4] = 6;

            // Att lära: foreach-slinga
            // ------------------------
            foreach(int talet in tal)
            {
                Console.Write(talet + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // Att lära: anropa (klass-)metoder
            // ------------------------
            // Det finns klass-metoder och objektmetoder. 
            // Du behöver inte kunna det nu, men vi kommer
            // att lära oss skillnaden senare.

            // anrop av metoden printHello
            printHello();

            // anrop av metoden print
            print("Anrop av metoden print.");
            print("");

            // anrop av metoden f
            int x = 0;
            Console.WriteLine("x f(x) = 2x + 1");
            while (x < 6)
            {
                double svar = f(x);
                Console.WriteLine(x + " " + svar);
                x = x + 1;
            }
            Console.WriteLine();

            Console.WriteLine("Tryck tangent för att avsluta.");
            Console.Read();

        }
        // Att lära: definera metod
        private static void printHello()
        {
            Console.WriteLine("Hej och välkommen till C#.");
            Console.WriteLine();
        }

        // Att lära: definiera metod som tar parameter.
        // Texten som måste skickas med vid anropet kallas parameter.
        private static void print(String text)
        {
            Console.WriteLine(text);
        }
        // Att lära: definiera metoder med returvärde och parameter
        // Svaret som lämnas tillbaka kallas för returvärde.
        private static double f(double value)
        {
            return 2 * value + 1;
        }
    }
}
