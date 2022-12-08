using ExportPdfFromDb.Models;
using System.Collections.Generic;
using System.Linq;

namespace ExportPdfFromDb.Service {
    public class Repository {
        IList<Bill> bills = new List<Bill>();
        public IList<Bill> Add()
        {
            bills = new List<Bill>()
            {
                new Bill(){Id=1, Name="Potato",Count=1,Price=30.00},
                new Bill(){Id=2, Name="Tomato",Count=2,Price=40.00},
                new Bill(){Id=3, Name="Apple",Count=4,Price=80.00},
                new Bill(){Id=1, Name="Potato",Count=1,Price=30.00}
            };
            return bills;
        }
        public double TotalPrice()
        {
            var result = bills.Sum(b => b.Price);
            return result;
        }
    }
}
