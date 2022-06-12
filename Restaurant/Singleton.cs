using Restaurant.Elements;
using System.Collections.Generic;

namespace Restaurant
{
    class Singleton
    {
        public static Dictionary<int, Order> chooses = new Dictionary<int,Order>();
        private static Singleton instance;

        private Singleton()
        { }

        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }

    
    }
}
