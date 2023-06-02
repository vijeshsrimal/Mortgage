using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageFraudsDetectionModels.Models
{
    public class Buyer
    {
        public int BuyerId { get; set; }
        public float BuyerSalary { get; set; }
        public float MortgageValue { get; set; }
        public int CibilScore { get; set; }
    }
}
