using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LR2
{
    class Program
    {
        static void Main(string[] args)
        {
            String keyPro = Console.ReadLine();
            String keyExp = Console.ReadLine();
            DocumentWorker documentWorker;
            if (keyExp.Equals("123qwe"))
                documentWorker = new ExpertDocumentWorker();
            else if (keyPro.Equals("342ewq"))
                documentWorker = new ProDocumentWorker();
            else documentWorker = new DocumentWorker();
            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, documentWorker);

                Console.WriteLine("Объект сериализован");
            }
            Console.ReadLine();
        }
    }
}
