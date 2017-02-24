namespace Singleton
{
   public class Singleton
    {
        // Arbitrary variables and methods
        public string item; 

        public void PrintItem()
        {
            System.Console.WriteLine(item);
        }

        // Required Members of Singleton
        private static readonly Singleton instance;

        public static Singleton Instance
        {
            get {return instance; }

            // You cannot put a set in the property
            // because the instance is readonly
            // set { instance = value; }
        }

        private Singleton()
        {
            item = "default item";
        }
    }
}