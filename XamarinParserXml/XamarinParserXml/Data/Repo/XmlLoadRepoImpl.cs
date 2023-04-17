using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using XamarinParserXml.Data.Models;
using XamarinParserXml.Domain.Repo;

namespace XamarinParserXml.Data.Repo
{
    public class XmlLoadRepoImpl : IXmlLoadRepo
    {
        private HttpClient _httpClient;

        public XmlLoadRepoImpl()
        { 

        }

        public async Task<List<Offer>> GetOffers()
        {
            Offers offers;
            using(_httpClient = new HttpClient())
            {
                var responseMessage = await _httpClient.GetAsync("https://yastatic.net/market-export/_/partner/help/YML.xml");

                var responseString = await responseMessage.Content.ReadAsStringAsync();

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(responseString);



                var offersXml = xmlDocument.DocumentElement.GetElementsByTagName("offers").Item(0).OuterXml;

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Offers));
                offers = xmlSerializer.Deserialize(new StringReader(offersXml)) as Offers;
            }
            return offers.Offer;

        }


    }
}


