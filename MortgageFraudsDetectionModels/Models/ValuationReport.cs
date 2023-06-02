using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageFraudsDetectionModels.Models
{
    public class ValuationReport
    {
        public int BuyerId { get; set; }
        public int PropertyId { get; set; }
        public float MarketValue { get; set; }
        public float PurchasingPower { get; set; }
        public string LegalOpinion { get; set; }
    }
}