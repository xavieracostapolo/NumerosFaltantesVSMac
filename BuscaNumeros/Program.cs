/*
    Ing. Xavier Acosta Polo
    23 de mayo de 2018
*/

namespace BuscaNumeros
{
    using System;
    using People.Num.Bl;

    /// <summary>
    /// Main class.
    /// </summary>
    class MainClass
    {

        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite n:");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite array A, números separados por espacios:");
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

                Console.WriteLine("Digite m:");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite array B, números separados por espacios:");
                int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp));

                //Ordenar segunda lista.
                Array.Sort(brr);

                //Ordenar el primer array
                Array.Sort(arr);

                //Configuracion Constraints
                if (!(n <= m))
                {

                    Console.WriteLine("La primera lista debe ser menor que la segunda.");

                }
                else if (!((n >= 1) && (m <= 200000)))
                {

                    Console.WriteLine("La primera lista debe ser mayor a 1 y la segunda menor a 2000000");

                }
                else if (!((arr[0] - arr[n - 1] <= 100) && (brr[0] - brr[m - 1] <= 100)))
                {

                    Console.WriteLine("La diferencia entre el maximo y minimo valor de las listas debe ser 100");

                }
                else
                {
                    Console.WriteLine("El resultado es:");
                    int[] result = BusquedaNumero.GetBusquedaNumero(arr, brr);
                    Console.WriteLine(string.Join(" ", result));

                }
            }
            catch (BusinessException bex)
            {
                Console.WriteLine(String.Format("Error en la capa de negocio - {0}", bex.Message));
            }
            catch (Exception ex)
            {
                Console.WriteLine(String.Format("Error para ejecutar la aplicacion - {0}", ex.Message));
            }

            Console.ReadLine();
        }
    }
}
