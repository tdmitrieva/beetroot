using Starcounter;
using System;
using Tatiana.Models;

namespace Tatiana.Repositories
{
    public static class CorporationRepo
    {

        public static QueryResultRows<Corporation> GetAll()
        {
            return Db.SQL<Corporation>("SELECT c FROM Corporation c");
        }

        public static Corporation Add(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title");

            Corporation corporation = null;

            Db.Transact(() => { corporation = new Corporation() { Title = title }; });
 
            return corporation;
        }

        public static QueryResultRows<FranchiseOffice> LoadOffices(this Corporation corporation)
        {
            return Db.SQL<FranchiseOffice>("SELECT fo FROM FranchiseOffice fo WHERE fo.Corporation = ?", corporation);
        }

        public static FranchiseOffice AddOffice(this Corporation corporation, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name");

            FranchiseOffice office = null;

            Db.Transact(() => {
                office = new FranchiseOffice
                {
                    Name = name,
                    Corporation = corporation
                };
            });

            return office;
        }

    }
}
