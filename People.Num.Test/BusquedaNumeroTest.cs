/*
    Ing. Xavier Acosta Polo
    23 de mayo de 2018
*/
namespace People.Num.Test
{
    using System;
    using NUnit.Framework;
    using People.Num.Bl;

    /// <summary>
    /// Busqueda numero test.
    /// </summary>
    [TestFixture]
    public class BusquedaNumeroTest
    {
        /// <summary>
        /// Cuandos the se encuentra los numeros.
        /// </summary>
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
            int[] result = BusquedaNumero.GetBusquedaNumero(arr, brr);

            //Validar la prueba
            Assert.AreEqual(result, resultadoOK);
        }

        /// <summary>
        /// Cuandos the se encuentra los numeros.
        /// </summary>
        [Test]
        public void Cuando_SeEncuentraLosNumeros2()
        {
            //Array con el resultado
            int[] resultadoOK = { 40, 50, 60, 70 };

            //Primer listado con los numeros perdidos
            int[] arr = { 10, 20, 30 };

            //Segundo listado con la permutacion completa de numeros
            int[] brr = { 40, 50, 60, 70 };

            //Ordenar segunda lista.
            Array.Sort(brr);

            //Ordenar el primer array
            Array.Sort(arr);

            //Llamar metodo a probar
            int[] result = BusquedaNumero.GetBusquedaNumero(arr, brr);

            //Validar la prueba
            Assert.AreEqual(result, resultadoOK);
        }
    }
}
