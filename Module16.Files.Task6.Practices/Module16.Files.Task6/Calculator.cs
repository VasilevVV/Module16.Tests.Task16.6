namespace Practices
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Сумма
        /// </summary>
        /// <param name="a">Слагаемое</param>
        /// <param name="b">Слагаемое</param>
        /// <returns>Результат суммы</returns>
        public int Additional(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Вычитание
        /// </summary>
        /// <param name="a">Уменьшаемое</param>
        /// <param name="b">Вычитаемое</param>
        /// <returns>Результат разности</returns>
        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="a">Множитель</param>
        /// <param name="b">Множитель</param>
        /// <returns>Результат произведения</returns>
        public int Miltiplication(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="a">Делимое</param>
        /// <param name="b">Делитель</param>
        /// <returns>Результат частного</returns>
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}