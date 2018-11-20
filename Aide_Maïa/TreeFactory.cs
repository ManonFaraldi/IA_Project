using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Dijkstra;

namespace IALib
{
    public class TreeFactory
    {
        public static Node Load(string file)
        {
            List<string> lines = File.ReadAllLines(file).ToList();
            double[,] matrix = null;
            int idFinal = -1;
            int idStart = -1;
            int nbNodes = 0;

            if (lines.Count <= 0)
                throw new Exception("Fichier invalide");

            // Lecture des données initiales
            nbNodes = int.Parse(lines[0].Split(',')[0]);
            idStart = int.Parse(lines[0].Split(',')[1]);
            idFinal = int.Parse(lines[0].Split(',')[2]);
            lines.RemoveAt(0);
            if(lines.Count > nbNodes)
                throw new Exception("Fichier invalide");

            matrix = new double[nbNodes, nbNodes];

            for (int i = 0; i < lines.Count; i++)
            {
                string[] values = lines[i].Split(',');
                if (values.Length != nbNodes)
                    throw new Exception("Fichier invalide");
                for(int u = 0; u < values.Length; u++)
                {
                    matrix[i, u] = int.Parse(values[u]);
                }
            }

            Node n0 = new Node(matrix, idFinal, nbNodes);
            n0.numero = idStart;
            return n0;
        }

    }
}