using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinParserXml.Data.Models;

namespace XamarinParserXml.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OffersJson : ContentPage,IView
    {
        private Offer _offer;
        public OffersJson(Offer offer)
        {
            InitializeComponent();
            _offer = offer;
            LoadJson(_offer);
        }

        private void LoadJson(Offer offer)
        {
            
            JsonLabel.Text = JsonConvert.SerializeObject(offer, Formatting.Indented);
        }
    }
}