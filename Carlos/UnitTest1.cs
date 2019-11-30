using System;
using camacho;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Carlos
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAhorro()
        {
            //Organizar
            Person person = new Person("Luis", 1000);
            double valoresperado = 1500;

            //Actuar
            person.Save(500);
            double valorobtenido = person.SaveMoney;


            //Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);


        }

        [TestMethod]
        public void TestNombre()
        {
            //Organizar
            Person person = new Person("Fernando", 100);
            string nombreesperado = "Eduardo";

            //Actuar

            person.ChangeName("Eduardo");
            string nombreobtenido = person.Name;


            //Afirmar

            Assert.AreEqual(nombreesperado, nombreobtenido);
        }
    }
}
