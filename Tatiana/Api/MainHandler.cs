using System;
using Starcounter;
using Tatiana.ViewModels;

namespace Tatiana.Api
{
    public class MainHandler : IHandler
    {
        public void Register()
        {
            Handle.GET("/tatiana", () =>
            {
                var page = new CorporationPage();
                page.LoadSubiews();
                return MasterPageManager.NavigateToView(page);
            });
        }
    }
}
