using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace App
{
    public class SerialisationQuestions // Revoir cours p.11 12/31 ("Gestion données persistantes")
    {
        // Sérialisation et sauvegarde d'un fichier xml
        public static void Save(string filename, List<Questions> questions)
        {
            XmlSerializer fichier = new XmlSerializer(typeof(List<Questions>));

            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                fichier.Serialize(fs, questions);
            }
        }

        // Création d'un fichier xml par désérialisation
        public static List<Questions> CreateFromFile(string filename)
        {
            XmlSerializer fichier = new XmlSerializer(typeof(List<Questions>));

            List<Questions> questions = null;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                questions = (List<Questions>)fichier.Deserialize(fs);
            }
            return questions;
        }
    }
}
