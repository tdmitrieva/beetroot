using Starcounter;
using System.Collections;

namespace Tatiana.ViewModels
{
    [FranchiseOfficeListJson_json]
    partial class FranchiseOfficeListJson : Json
    {
        public IEnumerable FranchiseOffices
        {
            get
            {
                return (IEnumerable)this.Data;
            }
        }

    }

    [FranchiseOfficeListJson_json.FranchiseOffices]
    partial class FranchiseOfficeListItemJson : Json
    {
        protected override void OnData()
        {
            base.OnData();
            this.Url = string.Format("/tatiana/edit-office/{0}", this.Key);
        }
    }

}
