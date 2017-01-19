using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApplication4
{
    public class Student<T>
    {
        private string m_name;
        private int m_age;
        private string m_id;
        public Student() { }
        public Student(string a, int b, string c) { }
        public string Name
        { get { return m_name; }
        set { m_name = value; }
        }
        public string Age
        { get { return m_age.ToString(); }
        set { m_age = value; }
        }
        public string ID
        { get { return m_id; }
        set { m_id = value; }
        }
        public static void Serialize(string fileName, T data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter writer = new StreamWriter(@"..\..\SavedFiles\" + fileName + ".xml");
            serializer.Serialize(writer, data);
            writer.Close();
        }
        public static T Deserialize(string fileName)
        {
            T data;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextReader reader = new StreamReader(@"..\..\SavedFiles\" + fileName + ".xml");
            data = (T)serializer.Deserialize(reader);
            reader.Close();
            return data;
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}  




