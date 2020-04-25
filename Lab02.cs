using System;

    public class Lab02
    {
        public static void Main()
        {
            double Single_Prescription_Glass = 40.00;
            double Non_Prescription_Sunglass = 25.00;
            double Anti_Glare_Coating = 12.50;
            double Brown_Tint_Coating = 9.99;

            Console.WriteLine("What kind of glasses would you like: ");//Console.WriteLine() is used for printing out the given msg
            Console.WriteLine("1 -> Prescription, 2 -> Non-Prescription : ");

        int  client_pref= int.Parse(Console.ReadLine());//Console.ReadLine() provides the interface for reading data
            if (client_pref < 1 || client_pref > 2)
            {
                Console.WriteLine("1 -> Prescription, 2 -> Non-Prescription : ");
            client_pref = int.Parse(Console.ReadLine());
            }
            double product_price = 0.0; //Double represents the fractional value

                if (client_pref == 1)
                product_price = Single_Prescription_Glass;
                else
                product_price = Non_Prescription_Sunglass;

            Console.WriteLine("What kind of coating would you like: ");
            Console.WriteLine("1 -> Anti-glare, 2 -> Brown tint : ");

            client_pref = int.Parse(Console.ReadLine());

            if (client_pref < 1 || client_pref > 2)
            {
                Console.WriteLine("1 -> Anti-glare, 2 -> Brown tint : ");
            client_pref = int.Parse(Console.ReadLine());

            }
            if (client_pref == 1)
            product_price = product_price + Anti_Glare_Coating;
            else
            product_price = product_price + Brown_Tint_Coating;

            Console.WriteLine("\nYour total cost us is $" + product_price);
            Console.ReadLine();
        }
    }

