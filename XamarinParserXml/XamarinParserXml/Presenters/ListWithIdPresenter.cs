using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinParserXml.Data.Models;
using XamarinParserXml.Data.Repo;
using XamarinParserXml.Domain.Repo;
using XamarinParserXml.Pages;
using XamarinParserXml.Views;

namespace XamarinParserXml.Presenters
{
    internal class ListWithIdPresenter : Presenter
    {
        private IXmlLoadRepo _xml = new XmlLoadRepoImpl();
        public ListWithIdPresenter(ListWithId view) : base(view)
        {
            view.LoadData += OnLoaded;
        }

        private async Task<List<Offer>> OnLoaded()
        {
            return await _xml.GetOffers();
        }
    }
}
