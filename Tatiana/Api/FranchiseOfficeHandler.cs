using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tatiana.Models;
using Tatiana.ViewModels.pages;

namespace Tatiana.Api
{
    public class FranchiseOfficeHandler : IHandler
    {
        public void Register()
        {
            Handle.GET("/tatiana/edit-office/{?}", (string id) =>
            {
                return Db.Scope<Json>(() =>
                {
                    FranchiseOfficeEditPage page = new FranchiseOfficeEditPage
                    {
                        Data = DbHelper.FromID(DbHelper.Base64DecodeObjectID(id)) as FranchiseOffice
                    };

                    return MasterPageManager.NavigateToView(page);
                });

            });
        }
    }
}
