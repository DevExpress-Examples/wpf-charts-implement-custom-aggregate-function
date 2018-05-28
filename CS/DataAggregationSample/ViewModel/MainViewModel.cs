using DataAggregationSample.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAggregationSample.ViewModel {
    class MainViewModel {
        const String DataFilePath = "..//..//Data//EurUsdRate.xml";

        public IReadOnlyList<CurrencyRate> CurrencyRates { get; private set; }

        public MainViewModel () {
            CurrencyRates = LoadRates();
        }


        const String RootName = "EurUsd";
        const String ListName = "EurUsdRate";
        const String ItemName = "CurrencyRate";
        const String ItemDateName = "DateTime";
        const String ItemValueName = "Rate";
        public IReadOnlyList<CurrencyRate> LoadRates() {
            var rates = new List<CurrencyRate>();

            var document = XDocument.Load(DataFilePath);
            var itemList = document.Element(RootName).Element(ListName);
            foreach (var item in itemList.Elements(ItemName)) {
                var date = DateTime.ParseExact(item.Element(ItemDateName).Value, "yyyy-MM-dd",CultureInfo.InvariantCulture);
                var rate = Double.Parse(item.Element(ItemValueName).Value, CultureInfo.InvariantCulture);
                rates.Add(new CurrencyRate(date, rate));
            }

            return rates;
        }
    }
}
