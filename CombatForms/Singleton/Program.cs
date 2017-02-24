namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Items to be assigned
            string blueitem = "blue item";
            string reditem = "red item";
            string greenitem = "green item";

            // Normal class construction and assignment
            Container box1 = new Container(blueitem);
            Container box2 = new Container(reditem);
            Container box3 = new Container(greenitem);
            Container box4 = new Container();

            box4.m_item = blueitem;            

            box1.PrintItem();
            box2.PrintItem();
            box3.PrintItem();
            box4.PrintItem();

            // Singleton class construction and assignment
            Singleton.Instance.item = blueitem;
            Singleton.Instance.item = reditem;
            Singleton.Instance.item = greenitem;

            Singleton.Instance.PrintItem();

            Singleton.Instance.item = blueitem;

            // You cannot declare and define and singleton class like this
            // Singleton singleton = new Singleton();
            
            // Used for a breakpoint to debug variables
            System.Console.ReadLine();
        }
    }
}