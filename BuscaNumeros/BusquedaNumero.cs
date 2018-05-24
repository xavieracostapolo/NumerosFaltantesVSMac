/*
    Ing. Xavier Acosta Polo
    23 de mayo de 2018
*/

namespace BuscaNumeros
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
            //Array para agregar el resultado que se desea obtener
            List<int> result = new List<int>();

            //Recorrer la segunda lista
            int ib = 0;

            //Recorrer la primera lista
            for (int ia = 0; ia < arr.Length; ia++){
                if(arr[ia] != brr[ib]){
                    if(!result.Contains(brr[ib])){
                        result.Add(brr[ib]);
                    }

                    ia -= 1;
                }

                ib += 1;
            }

            int[] arrayResult = result.ToArray();
            Array.Sort(arrayResult);
            return arrayResult;
        }
    }
}
