using System;

namespace try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int sayi1 = 1;
                int sayi2 = 0;
                int sonuc;
                sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);
            }
            catch(FormatException fe)
            {
                throw fe;
            }
            catch(DivideByZeroException dbze)
            {
                throw dbze;
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
              
            }
            finally
            {
                Console.WriteLine("Finally kod bloger");
            }
        }
    }
}
