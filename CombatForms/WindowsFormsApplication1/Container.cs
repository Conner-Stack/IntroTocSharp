namespace Singleton
{
    public class Container
    {
        // Arbitrary variables and methods
        public string m_item;

        public void PrintItem()
        {
            System.Console.WriteLine(m_item);
        }

        // Normal class constructors
        public Container()
        {
            m_item = "default item";
        }        

        public Container(string item)
        {
            m_item = item;
        }
    }
}