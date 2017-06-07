using Starcounter;

namespace Tatiana.Models
{
    public class FranchiseOffice : Place
    {
        public Corporation Corporation;
        public string Name;

        //todo: Calculate this fields
        public int SoldHomes;
        public double TotalComission;
        public double AvgComission;
        public double Trend;

        public string Key
        {
            get
            {
                return this.GetObjectID();
            }
        }
    }
}
