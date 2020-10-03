using System;

namespace SingletonExample
{
    //Потокобезопасный вариант
    //Полностью ленивая загрузка
    //Быстрее некоторых других вариантов
    //(нет дополнительных проверок и блокировок)
    public sealed class Singleton
    {
        private Singleton()
        {
            Console.WriteLine($"Constructor");
        }
        public static Singleton Instance
        {
            get
            {
                Console.WriteLine($"Instance");
                return Nested.instance;
            }
        }

        private class Nested
        {
            //Статический конструктор вызовется
            //при первом обращении к статическому члену класса
            //и выполнится только один раз
            static Nested() { }

            //Модификатор internal даёт доступ для верхнего класса
            internal static readonly Singleton instance = new Singleton();
        }
    }
}
