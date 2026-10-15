using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace XavuiserieZombieSolver.src
{
    internal class Solver
    {
        public ValveNames valveLumiere { get; }
        public ValveNames valveCylindre { get; }

        public Solver(ValveNames valveLumiere, ValveNames valveCylindre)
        {
            this.valveLumiere = valveLumiere;
            this.valveCylindre = valveCylindre;
        }

        public Dictionary<ValveNames,int>? Solve()
        {
            List<ValveNames>? chemin = new List<ValveNames>();
            chemin.Add(valveLumiere);
            chemin = this.Recursion(chemin);

            if (chemin == null)
            {
                return null;
            }

            return this.Traduction(chemin);
        }

        private List<ValveNames>? Recursion(List<ValveNames> chemin)
        {
            if (chemin.Count == 6)
            {
                if (chemin.Last() == valveCylindre) return chemin;

                return null;
            }

            foreach (KeyValuePair<int, ValveNames> dest in chemin.Last().Chemins())
            {
                if (dest.Value == valveCylindre && chemin.Count < 5)
                {
                    continue;
                }

                if (!chemin.Contains(dest.Value))
                {
                    chemin.Add(dest.Value);
                    List<ValveNames>? result = this.Recursion(chemin);

                    if (result != null)
                    {
                        return result;
                    }

                    chemin.RemoveAt(chemin.Count - 1);
                }
            }

            return null;
        }

        private Dictionary<ValveNames, int> Traduction(List<ValveNames> chemin)
        {
            Dictionary<ValveNames, int> result = new Dictionary<ValveNames, int>();

            for (int i = 0; i < 5; i++)
            {
                result.Add(chemin[i], chemin[i].PositionToDestination(chemin[i + 1]));
            }

            return result;
        }
    }
}
