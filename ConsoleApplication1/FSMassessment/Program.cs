using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FSMassessment
{
    public  delegate void Handler();
    class Teacher
    {

        Handler onShout;
        public void AddFunction(Delegate function)
        {
            onEnter += function as Handler;
        }
        string name;
        public Handler onEnter;
        public Handler onExit;
        delegate void DOIT();
        delegate void SHOUT();
        private static void main()
        {

        }
    }
    //shows how to use delegates to make functions specific to Student variable
    delegate void Callback();
    class Student
    {
        public Student()
        {

        }
        Callback onTalk;

        public void AddThingToSay(Callback c)
        {
            onTalk += c;
        }

        public void Talk()
        {
            if(onTalk != null)
            onTalk.Invoke();
        }
    }
    class Program
    {
       static int TaylorLove = 0;
        static void Main(string[] args)
        {
            Student reggie = new Student();
            reggie.AddThingToSay(HowMuchYouLoveTaylorSwift);
            reggie.AddThingToSay(NickSaid);
            reggie.AddThingToSay(Fight);
            reggie.Talk();
        }
        static public void Fight()
        {
            Console.WriteLine("nick keel reggie");
        }
        static public void NickSaid()
        {
            Console.WriteLine("why you love taylor so much....");
        }
     static public void HowMuchYouLoveTaylorSwift()
        {
            TaylorLove = 9000;
            Console.WriteLine("I love me some Taylor Swift" + TaylorLove.ToString() + "big <3 < 3");
        }
    }
}
