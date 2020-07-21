using Resital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resital.DTO
{
    public class CompanyRegionDTO
    {
        public int Id { get; set; }
        public Company Company{ get; set; }
        public Region Region { get; set; }
    }
}
