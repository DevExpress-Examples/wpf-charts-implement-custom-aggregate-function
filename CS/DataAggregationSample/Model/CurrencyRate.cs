using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAggregationSample.Model {
    class CurrencyRate {
        public DateTime Date { get; private set; }
        public double Value { get; private set; }

        public CurrencyRate(DateTime date, double value) {
            this.Date = date;
            this.Value = value;
        }
    }
}
