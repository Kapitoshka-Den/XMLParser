using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinParserXml.Data.Models;

namespace XamarinParserXml.Domain.Repo
{
    internal interface IXmlLoadRepo
    {
        Task<List<Offer>> GetOffers();
    }
}
