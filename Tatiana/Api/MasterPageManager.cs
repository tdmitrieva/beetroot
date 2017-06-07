using Starcounter;
using Tatiana.ViewModels;

namespace Tatiana.Api
{
    public static class MasterPageManager
    {

        public static Json NavigateToView(Json view)
        {
            MasterPage masterPage = new MasterPage
            {
                CurrentView = view
            };

            if (Session.Current == null)
            {
                Session.Current = new Session(SessionOptions.PatchVersioning);
            }

            masterPage.Session = Session.Current;
            return masterPage;
        }
    }
}
