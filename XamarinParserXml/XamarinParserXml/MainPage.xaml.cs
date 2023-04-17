using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinParserXml.Data.Repo;
using XamarinParserXml.Domain.Repo;
using XamarinParserXml.Pages;
using XamarinParserXml.Views;

namespace XamarinParserXml
{
    public partial class MainPage : ContentPage,IView
    {
        public MainPage()
        {
            InitializeComponent();
            Navigate();
        }
        public async void Navigate()
        {
            await Navigation.PushAsync(new ListWithId());
        }
        public void loadXml()
        {
            IXmlLoadRepo xmlLoadRepoImpl = new XmlLoadRepoImpl();
            var test = xmlLoadRepoImpl.GetOffers();
        }
    }
}
