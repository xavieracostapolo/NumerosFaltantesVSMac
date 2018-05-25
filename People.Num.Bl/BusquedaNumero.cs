/*
    Ing. Xavier Acosta Polo
    23 de mayo de 2018
*/

namespace People.Num.Bl
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Clase de Busqueda numero.
    /// </summary>
    public static class BusquedaNumero
    {
        /// <summary>
        /// Gets the busqueda numero.
        /// </summary>
        /// <returns>Array del resultado en la busqueda de los numero.</returns>
        /// <param name="arr">Arr. Primer array con los numeros perdidos</param>
        /// <param name="brr">Brr. Segundo array permutacion de la primera</param>
        public static int[] GetBusquedaNumero(int[] arr, int[] brr)
        {
            //Guardar el resultado
            List<int> numbers = new List<int>();

            int[] result = new int[201];
            int pivot = arr[0];

<<<<<<< HEAD:BuscaNumeros/BusquedaNumero.cs
            //Recorrer la primera lista
            for (int ia = 0; ia < arr.Length; ia++){
                if(arr[ia] != brr[ib]){
                    if(!result.Contains(brr[ib])){
                        //Se muestra el resultado
                        Console.WriteLine(brr[ib]);
                        result.Add(brr[ib]);
                    }
=======
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int da = arr[i] - pivot;
                    result[100 + da]--;
                }

                for (int i = 0; i < brr.Length; i++)
                {
                    int db = brr[i] - pivot;
                    result[100 + db]++;
                }
>>>>>>> 2f45005... * BuscaNumeros.sln: Manejo de capas, manejo de excepciones y ajuste   del metodo de busqueda de numeros:People.Num.Bl/BusquedaNumero.cs

                for (int i = 0; i < result.Length; i++)
                {
                    for (int j = 0; j < result[i]; j++)
                    {
                        int value = i - 100 + pivot;
                        numbers.Add(value);
                    }
                }

                //Simular excepcion
                //throw new Exception("Excepcion de prueba");
            }
            catch (Exception ex)
            {
                throw new BusinessException(String.Format("Error al realizar el calculo - {0}", ex.Message), ex);
            }

            int[] arrayResult = numbers.ToArray();
            Array.Sort(arrayResult);
            return arrayResult;
        }
    }
}
