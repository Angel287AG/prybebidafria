namespace prybebidafria
{
    internal class Program
    {
        static void Main(string[] args) 
        {

            List<bebidas> pedido = new List<bebidas>();

            pedido.Add(new bebida_caliente("Café Americano", "Grande", 90.5f, 45.00f));
            pedido.Add(new bebidafria("Capuchino", "Mediano", 5, 60.00f));
            pedido.Add(new bebida_caliente("Té de manzanilla ", "Chico", 85.0f, 40.00f));
            pedido.Add(new bebidafria("agua de frutas", "Grande", 6, 48.50f));
            pedido.Add(new bebida_caliente("bebida de chocolate", "Grande", 92.0f, 55.00f));

            Console.WriteLine("PRODUCCIÓN");

            for (int i = 0; i <5; i++)
            {
                Console.WriteLine(pedido[i].Prepararbebida());

                if (pedido[i] is bebida_caliente caliente && caliente.temperatura > 88)
                {
                    Console.WriteLine("\tCuidado, bebida muy caliente");
                }
                Console.WriteLine();
            }

            float costoTotal = 0;
            for (int i = 0; i < pedido.Count; i++)
            {
                costoTotal = costoTotal+ pedido[i].Precio;
            }


            Console.WriteLine("total de la orden: " + costoTotal.ToString("C"));



            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
    
}
