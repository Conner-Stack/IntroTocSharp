using System;
using System.Xml.Serialization;
using System.IO;


namespace combatForms
{
    class Serializer
    {
        public static void Serialize(string fileName, T data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            TextWriter writer = new StreamWriter(Environment.CurrentDirectory + "../Saves/" + fileName + ".xml");

            serializer.Serialize(writer, data);

            writer.Close();
        }

        public static T Deserialize(string fileName)
        {
            T data;

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            TextReader reader = new StreamReader(Environment.CurrentDirectory + "../Saves/" + fileName + ".xml");

            data = (T)serializer.Deserialize(reader);

            reader.Close();

            return data;
        }
    }
}
