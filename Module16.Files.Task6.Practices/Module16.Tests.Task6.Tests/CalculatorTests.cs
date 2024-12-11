using Moq;

namespace Practices.Tests
{
    /// <summary>
    /// Тесты класса Calculator с использованием NUnit-фреймворка
    /// </summary>
    [TestFixture]
    public class CalculatorTests
    {
        /// <summary>
        /// Проверка сложения
        /// </summary>
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(100, 10) == 110);
        }

        /// <summary>
        /// Проверка вычитания
        /// </summary>
        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(10, 100) == -90);
        }

        /// <summary>
        /// Проверка умножения
        /// </summary>
        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Miltiplication(2, 4) == 8);
        }

        /// <summary>
        /// Проверка деления
        /// </summary>
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(200, 10) == 20);
        }

        /// <summary>
        /// Проверка исключения при делении на ноль
        /// </summary>
        [Test]
        public void DivisionMustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }

        /// <summary>
        /// Что-то вроде интеграционного тестирования двух функций сразу
        /// </summary>
        [Test]
        public void MultiplicationAndDivisionMustReturnOne()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(1, 1) == calculator.Miltiplication(1, 1));
        }
    }
}