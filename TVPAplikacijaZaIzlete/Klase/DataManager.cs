using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace TVPAplikacijaZaIzlete.Klase
{
    public class DataManager<T> where T : class
    {
        private readonly string _filePath;

        public DataManager(string filePath)
        {
            _filePath = filePath;
        }

        public void UpisiUXML(List<T> objekti)
        {
            using (FileStream fs = new FileStream(_filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                serializer.Serialize(fs, objekti);
            }
        }
        public void DodajUXML(T objekat)
        {
            List<T> objekti = ProcitajXML();
            if (objekti == null)
            {
                objekti = new List<T>();
            }

            objekti.Add(objekat);
            UpisiUXML(objekti); // Koristi metodu koja upisuje celu listu
        }

        public List<T> ProcitajXML()
        {
            if (!File.Exists(_filePath))
            {
                return new List<T>();
            }

            using (FileStream fs = new FileStream(_filePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                return (List<T>)serializer.Deserialize(fs);
            }
        }

        public int GenerisiId()
        {
            List<T> objekti = ProcitajXML();
            if (objekti == null || objekti.Count == 0)
            {
                return 1;
            }

            int maxId = 0;
            foreach (var objekat in objekti)
            {
                var property = objekat.GetType().GetProperty("ID");
                if (property != null)
                {
                    int id = (int)property.GetValue(objekat);
                    if (id > maxId)
                    {
                        maxId = id;
                    }
                }
            }

            return maxId + 1;
        }
    }
}
