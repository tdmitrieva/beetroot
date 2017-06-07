using Starcounter;
using Tatiana.Repositories;

namespace Tatiana.ViewModels
{
    partial class CorporationPage : Json
    {
        public void LoadSubiews()
        {
            NewCorporation = new CorporationJson();
            CorporationsList = new CorporationListJson
            {
                Data = CorporationRepo.GetAll()
            };
        }
    }
}
