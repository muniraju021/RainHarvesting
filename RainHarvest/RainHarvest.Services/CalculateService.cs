using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainHarvest.Services
{
    public class CalculateService
    {
        public RainfallData ProcessRainfallData(RainfallData objRainfallData)
        {
            if(objRainfallData != null)
            {
                objRainfallData.TankCost = (objRainfallData.RainWaterTankCapacity * MathConstants.CostOfTankPerLt);
                objRainfallData.RwhImplementaionCost = objRainfallData.TankCost + MathConstants.CostOfPipeingAndLabor + MathConstants.CostOfTankRwhFilter;

                objRainfallData.WaterSavedPerKilolt = (Math.Round(objRainfallData.RoofTopRainWaterPotential / 1000));
                objRainfallData.SavingsCostPerYear = objRainfallData.WaterSavedPerKilolt * MathConstants.CostOfWaterPerKiloLt;

                objRainfallData.GovtWaterUsageCost = (((int)(objRainfallData.ConsumerWaterUsage / 1000)) * 365) * MathConstants.CostOfWaterPerKiloLt;

                objRainfallData.PaybackPeriod = Math.Round(objRainfallData.RwhImplementaionCost / objRainfallData.SavingsCostPerYear);
            }
            return objRainfallData;
        }
    }
}
