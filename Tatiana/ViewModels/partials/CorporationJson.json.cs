using Starcounter;
using Tatiana.Repositories;

namespace Tatiana.ViewModels
{
    partial class CorporationJson : Json
    {
        void Handle(Input.SaveTrigger action)
        {
            CorporationRepo.Add(this.Title);
        }
    }
}
