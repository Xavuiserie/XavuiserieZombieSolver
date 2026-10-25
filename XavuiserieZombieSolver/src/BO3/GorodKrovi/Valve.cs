using System;
using System.Collections.Generic;
using System.Text;

namespace XavuiserieZombieSolver.src.BO3.GorodKrovi
{
    public static class Valve
    {
        public static Dictionary<int, ValveNames> Chemins(this ValveNames valve)
        {
            return valve switch
            {
                ValveNames.DragonCommand => new Dictionary<int, ValveNames>
                {
                    { 1, ValveNames.SupplyDepot },
                    { 2, ValveNames.DepartmentStore },
                    { 3, ValveNames.Infirmary }
                },

                ValveNames.SupplyDepot => new Dictionary<int, ValveNames>
                {
                    { 1, ValveNames.DragonCommand },
                    { 2, ValveNames.Armory },
                    { 3, ValveNames.TankFactory }
                },

                ValveNames.TankFactory => new Dictionary<int, ValveNames>
                {
                    { 1, ValveNames.Infirmary },
                    { 2, ValveNames.SupplyDepot },
                    { 3, ValveNames.Armory }
                },

                ValveNames.DepartmentStore => new Dictionary<int, ValveNames>
                {
                    { 1, ValveNames.Armory },
                    { 2, ValveNames.Infirmary },
                    { 3, ValveNames.DragonCommand }
                },

                ValveNames.Armory => new Dictionary<int, ValveNames>
                {
                    { 1, ValveNames.SupplyDepot },
                    { 2, ValveNames.TankFactory },
                    { 3, ValveNames.DepartmentStore }
                },

                ValveNames.Infirmary => new Dictionary<int, ValveNames>
                {
                    { 1, ValveNames.DepartmentStore },
                    { 2, ValveNames.TankFactory },
                    { 3, ValveNames.DragonCommand }
                },

                _ => throw new ArgumentOutOfRangeException(nameof(valve), valve, "Valve inconnue.")
            };
        }

        public static int PositionToDestination(this ValveNames start, ValveNames destination)
        {
            return start.Chemins().FirstOrDefault(x => x.Value == destination).Key;
        }
    }
}
