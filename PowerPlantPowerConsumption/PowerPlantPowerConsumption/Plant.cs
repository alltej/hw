using System.Collections.Generic;
using PowerPlanPowerConsumption.Tests;

namespace PowerPlantPowerConsumption
{
    public class Plant
    {
        private List<KwhiTem> _kwhItems;

        public List<KwhiTem> KwhItems => _kwhItems;

        public void SetKwItems(List<KwhiTem> kwhItems)
        {
            _kwhItems = kwhItems;
        }
    }
}