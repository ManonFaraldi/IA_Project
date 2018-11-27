using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Donnees
{
    public class SerialisationUser
    {
        // Sérialisation et sauvegarde d'un objet dans un fichier xml
        public static void Save(string filename, Utilisateur users)
        {
            XmlSerializer fichier = new XmlSerializer(typeof(Utilisateur));

            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                fichier.Serialize(fs, users);
            }
        }

        // Création d'un objet à partir d'un fichier xml par désérialisation 
        public static Utilisateur CreateFromFile(string filename)
        {
            XmlSerializer fichier = new XmlSerializer(typeof(Utilisateur));

            Utilisateur users = null;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                users = (Utilisateur)fichier.Deserialize(fs);
            }
            return users;
        }
    }
}
