using Starcounter;
using Tatiana.Models;
using Tatiana.Repositories;

namespace Tatiana.ViewModels.pages
{
    partial class FranchiseOfficeEditPage : Json
    {
        public string FullAddress => string.Format("{0} {1}, {2} {3}, {4}", Street, Number, ZipCode, City,Country);
        void Handle(Input.SaveTrigger action)
        {
            Transaction.Commit();
        }
    }
}
