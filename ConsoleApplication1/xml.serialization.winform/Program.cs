using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace xml.serialization.winform
{
    public class Student
    {
        private string m_name;
        private int m_age;
        private string m_id;
        public Student() { }
        public Student(string a, int b, string c)
        {
            m_name = a;
            m_age = b;
            m_id = c;
        }
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public int Age
        {
            get { return m_age; }
            set { m_age = value; }
        }
        public string ID
        {
            get { return m_id; }
            set { m_id = value; }
        }
    }
    class Serialization<T>
    {
        public static void Serialize(string fileName, T data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter writer = new StreamWriter(@"C:\Users\conner.stack1\Desktop\New folder\" + fileName + ".xml");
            serializer.Serialize(writer, data);
            writer.Close();
        }
        public static T Deserialize(string fileName)
        {
            T data;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextReader reader = new StreamReader(@"C:\Users\conner.stack1\Desktop\New folder\" + fileName + ".xml");
            data = (T)serializer.Deserialize(reader);
            reader.Close();
            return data;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

