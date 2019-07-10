using NUnit.Framework;
using Juego;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestRevive()
        {
            //Arrange
            bool estadoActual = false;
            byte num = 3;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsTrue(estado);
        }

        [Test]
        public void TestSigueViva2()
        {
            //Arrange
            bool estadoActual = true;
            byte num = 2;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsTrue(estado);
        }

        [Test]
        public void TestSigueViva3()
        {
            //Arrange
            bool estadoActual = true;
            byte num = 3;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsTrue(estado);
        }

        [Test]
        public void TestMuere1()
        {
            //Arrange
            bool estadoActual = true;
            byte num = 1;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsFalse(estado);
        }

        [Test]
        public void TestMuere4()
        {
            //Arrange
            bool estadoActual = true;
            byte num = 4;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsFalse(estado);
        }

        [Test]
        public void TestMuere5()
        {
            //Arrange
            bool estadoActual = true;
            byte num = 5;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsFalse(estado);
        }

        [Test]
        public void TestMuere6()
        {
            //Arrange
            bool estadoActual = true;
            byte num = 6;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsFalse(estado);
        }

        [Test]
        public void TestMuere7()
        {
            //Arrange
            bool estadoActual = true;
            byte num = 7;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsFalse(estado);
        }

        [Test]
        public void TestMuere8()
        {
            //Arrange
            bool estadoActual = true;
            byte num = 8;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsFalse(estado);
        }


        [Test]
        public void TestSigueMuerta1()
        {
            //Arrange
            bool estadoActual = false;
            byte num = 1;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsFalse(estado);
        }

        [Test]
        public void TestSigueMuerta4()
        {
            //Arrange
            bool estadoActual = false;
            byte num = 4;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsFalse(estado);
        }

        [Test]
        public void TestSigueMuerta5()
        {
            //Arrange
            bool estadoActual = false;
            byte num = 5;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsFalse(estado);
        }

        [Test]
        public void TestSigueMuerta6()
        {
            //Arrange
            bool estadoActual = false;
            byte num = 6;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsFalse(estado);
        }

        [Test]
        public void TestSigueMuerta7()
        {
            //Arrange
            bool estadoActual = false;
            byte num = 7;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsFalse(estado);
        }

        [Test]
        public void TestSigueMuerta8()
        {
            //Arrange
            bool estadoActual = false;
            byte num = 8;
            bool estado;

            //Act
            estado = Celula.SigueViva(estadoActual, num);

            //Assert
            Assert.IsFalse(estado);
        }
    }
}