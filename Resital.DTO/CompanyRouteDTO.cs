using Resital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resital.DTO
{
    public class CompanyRouteDTO
    {
        public int Id { get; set; }
        public Company Company  { get; set; }
        public Route Route { get; set; }
    }
}
