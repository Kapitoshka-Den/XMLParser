using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinParserXml.Data.Models;
using XamarinParserXml.Presenters;
using XamarinParserXml.Views;

namespace XamarinParserXml.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListWithId : ContentPage,IView
    {
        public event LoadDelegate LoadData;


        public ListWithId()
        {
            InitializeComponent();

            new ListWithIdPresenter(this);

             LoadListAsync();
        }
        public async Task LoadListAsync()
        {
            var test = LoadData;

            var list = await LoadData.Invoke();
            if(list != null)
            {
                OffersList.ItemsSource = list.ToList();
            }
        }

        private async void OffersList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var offer = e.Item as Offer;
            await Navigation.PushAsync(new OffersJson(offer),true);
        }
    }
    
}

