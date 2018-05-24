using System;
using NUnit.Framework;

namespace BuscaNumeros
{

    [TestFixture]
    public class BusquedaNumeroTest
    {

        [Test]
        public void Cuando_SeEncuentraLosNumeros()
        {
            //Array con el resultado
            int[] resultadoOK = { 204, 205, 206 };

            //Primer listado con los numeros perdidos
            int[] arr = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };

            //Segundo listado con la permutacion completa de numeros
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };

            //Ordenar segunda lista.
            Array.Sort(brr);

            //Ordenar el primer array
            Array.Sort(arr);

            //Llamar metodo a probar
            int[] result = BuscaNumeros.BusquedaNumero.GetBusquedaNumero(arr, brr);

            //Validar la prueba
            Assert.AreEqual(result, resultadoOK);
        }
    }
}
