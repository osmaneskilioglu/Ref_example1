using System;

namespace Ref_example1
{
    class Referans
    {
        // Argümanı değiştiren metot
        // ref'in kullanımı önemli
        public void Kare(ref int i, ref int k)
        {
            i = i * k;
        }
    }

    class RefOrnek
    {
        static void Main()
        {
            Referans rf = new Referans();

            int a = 10;
            int b = 20;
            Console.WriteLine("Çağrıdan önce: " + a);

            // ref'in kullanımı önemli 
            rf.Kare(ref a, ref b);

            Console.WriteLine("Çağrıdan sonra: " + a);
        }
    }

}