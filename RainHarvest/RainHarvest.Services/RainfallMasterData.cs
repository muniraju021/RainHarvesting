using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainHarvest.Services
{
    public class RainfallData
    {
        public double RoofAreaInSqm { get; set; }
        public double RoofTopRainWaterPotential { get; set; }
        public double RoofAreaInSqft { get; set; }
        public double RainWaterTankCapacity { get; set; }
        public double ConsumerWaterUsage { get; set; }

        public double TankCost { get; set; }
        public double WaterSavedPerKilolt { get; set; }
        public double PaybackPeriod { get; set; }

        public double RwhImplementaionCost { get; set; }
        public double GovtWaterUsageCost { get; set; }
        public double SavingsCostPerYear { get; set; }
    }
}
