using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainHarvest.Services
{
    public class CacheManager
    {
        private static List<RainfallData> lstRoofRainfallMasterData = new List<RainfallData>
        {
            new RainfallData {RoofAreaInSqm=50,RoofTopRainWaterPotential=37300,RoofAreaInSqft=540,RainWaterTankCapacity=3700 },
            new RainfallData {RoofAreaInSqm=60,RoofTopRainWaterPotential=44800,RoofAreaInSqft=650,RainWaterTankCapacity=4500 },
            new RainfallData {RoofAreaInSqm=70,RoofTopRainWaterPotential=52300,RoofAreaInSqft=750,RainWaterTankCapacity=5200 },
            new RainfallData {RoofAreaInSqm=80,RoofTopRainWaterPotential=59700,RoofAreaInSqft=860,RainWaterTankCapacity=6000 },
            new RainfallData {RoofAreaInSqm=90,RoofTopRainWaterPotential=67200,RoofAreaInSqft=970,RainWaterTankCapacity=6700 },
            new RainfallData {RoofAreaInSqm=100,RoofTopRainWaterPotential=74700,RoofAreaInSqft=1080,RainWaterTankCapacity=7500 },
            new RainfallData {RoofAreaInSqm=110,RoofTopRainWaterPotential=82100,RoofAreaInSqft=1180,RainWaterTankCapacity=8200 },
            new RainfallData {RoofAreaInSqm=120,RoofTopRainWaterPotential=89600,RoofAreaInSqft=1290,RainWaterTankCapacity=9000 },
            new RainfallData {RoofAreaInSqm=130,RoofTopRainWaterPotential=97100,RoofAreaInSqft=1400,RainWaterTankCapacity=9700 },
            new RainfallData {RoofAreaInSqm=140,RoofTopRainWaterPotential=104500,RoofAreaInSqft=1510,RainWaterTankCapacity=10000 },
            new RainfallData {RoofAreaInSqm=150,RoofTopRainWaterPotential=112000,RoofAreaInSqft=1610,RainWaterTankCapacity=11200 },
            new RainfallData {RoofAreaInSqm=160,RoofTopRainWaterPotential=119500,RoofAreaInSqft=1720,RainWaterTankCapacity=12000 },
            new RainfallData {RoofAreaInSqm=170,RoofTopRainWaterPotential=126900,RoofAreaInSqft=1830,RainWaterTankCapacity=12700 },
            new RainfallData {RoofAreaInSqm=180,RoofTopRainWaterPotential=134400,RoofAreaInSqft=1940,RainWaterTankCapacity=13400 },
            new RainfallData {RoofAreaInSqm=190,RoofTopRainWaterPotential=141900,RoofAreaInSqft=2050,RainWaterTankCapacity=14200 },
            new RainfallData {RoofAreaInSqm=200,RoofTopRainWaterPotential=149300,RoofAreaInSqft=2150,RainWaterTankCapacity=14900 },
            new RainfallData {RoofAreaInSqm=210,RoofTopRainWaterPotential=156800,RoofAreaInSqft=2260,RainWaterTankCapacity=15700 },
            new RainfallData {RoofAreaInSqm=220,RoofTopRainWaterPotential=164300,RoofAreaInSqft=2370,RainWaterTankCapacity=16400 },
            new RainfallData {RoofAreaInSqm=230,RoofTopRainWaterPotential=171700,RoofAreaInSqft=2480,RainWaterTankCapacity=17200 },
            new RainfallData {RoofAreaInSqm=240,RoofTopRainWaterPotential=179200,RoofAreaInSqft=2580,RainWaterTankCapacity=17900 },
            new RainfallData {RoofAreaInSqm=250,RoofTopRainWaterPotential=186700,RoofAreaInSqft=2690,RainWaterTankCapacity=18700 }
        };


        public static Dictionary<double, RainfallData> RainfallDatabyRoofAreaInSqm = new Dictionary<double, RainfallData>();
        public static Dictionary<double, RainfallData> RainfallDatabyRoofAreaInSqft = new Dictionary<double, RainfallData>();
        public static List<double> ConsumerUsageOfWaterLst = new List<double> { 100,500,1000,1500,2000,2500,3000,3500,
                                                            4000,4500,5000,5500,6000,6500,7000,7500,
                                                            8000,8500,9000,9500,10000 };

        static CacheManager()
        {
            RainfallDatabyRoofAreaInSqm = lstRoofRainfallMasterData.GroupBy(i => i.RoofAreaInSqm).ToDictionary(g => g.Key, g => g.FirstOrDefault());
            RainfallDatabyRoofAreaInSqft = lstRoofRainfallMasterData.GroupBy(i => i.RoofAreaInSqft).ToDictionary(g => g.Key, g => g.FirstOrDefault());
        }
    }
}
