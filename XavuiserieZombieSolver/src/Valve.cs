using System;
using System.Collections.Generic;
using System.Text;

namespace XavuiserieZombieSolver.src
{
    public static class Valve
    {
        public static Dictionary<int, ValveNames> Chemins(this ValveNames valve)
        {
            return valve switch
            {
                ValveNames.DragonCommand => new Dictionary<int, ValveNames>
                    {
                        {1, ValveNames.DepartementStore },
                        {2, ValveNames.Armory },
                        {3, ValveNames.Infirmary }
                    },

                ValveNames.SupplyDepot => new Dictionary<int, ValveNames>
                    {
                        {1, ValveNames.DragonCommand },
                        {2, ValveNames.Armory },
                        {3, ValveNames.TankFactory }
                    },
                ValveNames.TankFactory => new Dictionary<int, ValveNames>
                    {
                        {1, ValveNames.DragonCommand },
                        {2, ValveNames.SupplyDepot },
                        {3, ValveNames.Infirmary }
                    },

                ValveNames.DepartementStore => new Dictionary<int, ValveNames>
                    {
                        {1, ValveNames.Armory },
                        {2, ValveNames.SupplyDepot },
                        {3, ValveNames.Infirmary }
                    },

                ValveNames.Armory => new Dictionary<int, ValveNames>
                    {
                        {1, ValveNames.DragonCommand },
                        {2, ValveNames.DepartementStore },
                        {3, ValveNames.TankFactory }
                    },

                ValveNames.Infirmary => new Dictionary<int, ValveNames>
                    {
                        {1, ValveNames.DepartementStore },
                        {2, ValveNames.TankFactory },
                        {3, ValveNames.SupplyDepot }
                    }
            };
        }

        public static int PositionToDestination(this ValveNames start, ValveNames destination)
        {
            return start.Chemins().FirstOrDefault(x => x.Value == destination).Key;
        }
    }
}
