using System;

namespace PowerPlanPowerConsumption.Tests
{
    internal class KwhiTem
    {
        public KWItemType ItemType { get; }
        public DateTime ItemDate { get; }
        public double ItemValue { get; }

        public KwhiTem(KWItemType type, DateTime dateTime, double v)
        {
            ItemType = type;
            this.ItemDate = dateTime;
            this.ItemValue = v;
        }
    }


}