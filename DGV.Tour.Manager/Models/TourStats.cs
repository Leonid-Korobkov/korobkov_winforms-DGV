using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGV.Contracts;

namespace DGV.Tour.Manager.Models
{
    public class TourStats : ITourStats
    {
        public int TotalCountTours { get; set; }

        public decimal TotalSumTours { get; set; }

        public int CountToursWithDop { get; set; }

        public decimal TotalSumDop { get; set; }
    }
}
