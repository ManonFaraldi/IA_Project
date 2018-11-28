using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Node2 : GenericNode 
    {
        public int numero;

       // Méthodes abstrates, donc à surcharger obligatoirement avec override dans une classe fille
        public override bool IsEqual(GenericNode N2)
        {
            Node2 N2bis = (Node2)N2;

            return numero == N2bis.numero;
        }
        
        public override double GetArcCost(GenericNode N2)
        {
            Node2 N2bis = (Node2)N2;
            return Dijkstra.matrice[numero, N2bis.numero];
        }

        public override bool EndState()
        {
            return (numero == Dijkstra.numfinal);
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            for (int i=0; i < Dijkstra.nbnodes; i++)
            {
                if (Dijkstra.matrice[numero, i] != -1)
                {
                    Node2 newnode2 = new Node2();
                    newnode2.numero = i;
                    lsucc.Add(newnode2);
                }
            }
            return lsucc;
        }
        

        public override double CalculeHCost()
        {
            return( 0 );
        }
       
        public override string ToString()
        {
            return Convert.ToString(numero);
        }
    }
}
