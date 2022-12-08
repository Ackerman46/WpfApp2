namespace WpfApp1
{
    internal class Triad
    {
        /*Начало полей класса Triad с модификатором protected*/

        protected int _one, _two, _three;

        /*Конец полей класса Triad с модификатором protected*/

        /*Начало свойств класса Triad*/

        public int One { get { return _one; } set { _one = value; } }
        public int Two { get { return _two; } set { _two = value; } }
        public int Three { get { return _three; } set { _three = value; } }

        /*Конец свойств класса Triad*/

        /// <summary>
        /// Сравнивает две тройки между собой
        /// </summary>
        /// <param name="triad1">Первая тройка</param>
        /// <param name="triad2">Вторая тройка</param>
        /// <returns>true, если две тройки равны, false, если две тройки не равны</returns>
        public bool CompareTriad(Triad triad1, Triad triad2)//публичная фукнция с логическим типом данных(true/false) с параметрами triad1, triad2, где triad1, triad2 - обьект класса Triad
        {
            return triad1.One == triad2.One && triad1.Two == triad2.Two && triad1.Three == triad2.Three;
        }
        /// <summary>
        /// Сложение тройки на число пользователя
        /// </summary>
        /// <param name="userValue">Число пользователя</param>
        /// <param name="triad1">Тройка чисел</param>
        /// <returns>Сумма тройки</returns>
        public Triad SumOfNum(int userValue, Triad triad1)
        {
            Triad triad3 = new Triad();
            triad3.One = triad1.One + userValue;
            triad3.Two = triad1.Two + userValue;
            triad3.Three = triad1.Three + userValue;
            return triad3;
        }
        /// <summary>
        /// Усножение тройки на число пользователя
        /// </summary>
        /// <param name="userValue">Число пользователя</param>
        /// <param name="triad1">Тройка чисел</param>
        /// <returns>Произведение тройки</returns>
        public Triad PowOfNum(int userValue, Triad triad1)
        {
            Triad triad3 = new Triad();
            triad3.One = triad1.One * userValue;
            triad3.Two = triad1.Two * userValue;
            triad3.Three = triad1.Three * userValue;
            return triad3;
        }
        /// <summary>
        /// Сложение двух троек
        /// </summary>
        /// <param name="triad1">Первая тройка</param>
        /// <param name="triad2">Вторая тройка</param>
        /// <returns>Сумму двух троек</returns>
        public Triad SumOfNum(Triad triad1, Triad triad2)
        {
            Triad triad3 = new Triad();
            triad3.One = triad1.One + triad2.One;
            triad3.Two = triad1.Two + triad2.Two;
            triad3.Three = triad1.Three + triad2.Three;
            return triad3;
        }
        // перегружаем бинарный оператор сложения(+) для того, чтобы он мог складывает обьект класса triad1 и целочисленное число которое ввел пользователь
        public static Triad operator +(Triad triad1, int userValue) /* (public)публичная(доступна из любого места проекта) 
                                                                     * (static)статическая(не нужно создавать обьект класса Triad чтобы, обращаться к этой фукнции) 
                                                                     * Triad(это значит что, мы должны вернуть обьект класса Triad) 
                                                                     * operator(ключевое слово) 
                                                                     * +(означает какую оператор мы хотим перегрузить)
                                                                     * С параметрами(triad1, int userValue), где triad1 - обьект класса Triad, int userValue - целочисленное значение которое ввел пользователь
                                                                     */
        {
            Triad triad2 = new Triad();
            triad2.One = triad1.One + userValue;
            triad2.Two = triad1.Two + userValue;
            triad2.Three = triad1.Three + userValue;
            return triad2;
        }
        public static Triad operator +(Triad triad1, Triad triad2) /*публичная(доступна из любого места проекта) 
                                                                     * статическая(не нужно создавать обьект класса Triad чтобы, обращаться к этой фукнции) 
                                                                     * Triad(это значит что, мы должны вернуть обьект класса Triad) 
                                                                     * operator(ключевое слово) 
                                                                     * +(означает какую оператор мы хотим перегрузить)
                                                                     * С параметрами(triad1, triad2), где triad1, triad2 - обьект класса Triad
                                                                     */
        {
            Triad triad3 = new Triad(); // создается новый обьект класса Triad
            triad3.One = triad1.One + triad2.One; // обьект(triad3) со свойством One = обьект который мы получаем из параметра(triad1) со свойством One + обьект который мы получаем из параметра(triad2) со свойством One
            triad3.Two = triad1.Two + triad2.Two; // обьект(triad3) со свойством One = обьект который мы получаем из параметра(triad1) со свойством Two + обьект который мы получаем из параметра(triad2) со свойством Two
            triad3.Three = triad1.Three + triad2.Three; // обьект(triad3) со свойством One = обьект который мы получаем из параметра(triad1) со свойством Three + обьект который мы получаем из параметра(triad2) со свойством Three
            return triad3; // возвращаем обьект(triad3) с новыми значениями в свойствах One, Two, Three
        }
    }
}
