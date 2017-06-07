using Starcounter;
using System.Collections;
using Tatiana.Models;
using Tatiana.Repositories;

namespace Tatiana.ViewModels
{
    [CorporationListJson_json]
    partial class CorporationListJson : Json
    {
        public IEnumerable Corporations
        {
            get
            {
                return (IEnumerable)this.Data;
            }
        }
    }

    [CorporationListJson_json.Corporations]
    partial class CorporationListJsonItem : Json
    {
        protected override void OnData()
        {
            base.OnData();
            this.FranchiseOfficesView = new FranchiseOfficeListJson
            {
                Data = (this.Data as Corporation).FranchiseOffices
            };
        }

        void Handle(Input.AddOfficeTrigger action)
        {
            var corporation = (this.Data as Corporation);
            corporation.AddOffice(this.NewOfficeName);
        }
    }
}
