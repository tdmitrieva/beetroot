using Starcounter;
using Tatiana.Repositories;

namespace Tatiana.Models
{
    [Database]
    public class Corporation
    {
        public string Title;
        public QueryResultRows<FranchiseOffice> FranchiseOffices => this.LoadOffices();
    }
}
