using System;

namespace Conta_Poup
{


    class Program
    {
    
        static void Main(string[] args)
        {
        
            {
            
            
                Poupança poup1 = new Poupança(2000M);
                Poupança poup2 = new Poupança(3000M);
                
                decimal saldoPoup1 = 0.0M;
                decimal saldoPoup2 = 0.0M;




                Console.WriteLine("Taxa de Juros = 4%");
                Poupança.AlterarTaxa(0.04);




                saldoPoup1 = poup1.CalcularJurosMensal();
                saldoPoup2 = poup2.CalcularJurosMensal();
                
                Console.WriteLine("   Poup 1 = {0:C}", saldoPoup1);
                Console.WriteLine("   Poup 2 = {0:C}", saldoPoup2);


                Console.WriteLine("\nTaxa de Juros = 5%");
                Poupança.AlterarTaxa(0.05);
                

                saldoPoup1 = poup1.CalcularJurosMensal();
                saldoPoup2 = poup2.CalcularJurosMensal();
                
                Console.WriteLine("   Poup 1 = {0:C}", saldoPoup1);
                Console.WriteLine("   Poup 2 = {0:C}", saldoPoup2);


                Console.Write("\n\nPress any key to exit . . .");
                
                Console.ReadKey(true);

            }
        }
    }
}
