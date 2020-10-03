using System;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запускаем паралельно, чтобы убедиться,
            //что конструктор вызывается только один раз (один экземпляр)
            Parallel.Invoke(
               () => Check(),
               () => Check()
               );
        }

        private static void Check()
        {
            Singleton singleton = Singleton.Instance;
        }
    }
}
