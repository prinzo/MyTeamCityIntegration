using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCityCSharp.TeamCityModels
{
    public class BaseBuild
    {
        public string id { get; set; }
        public string buildTypeId { get; set; }
        public string number { get; set; }
        public string status { get; set; }
        public string state { get; set; }
        public string href { get; set; }
        public string webUrl { get; set; }
    }
}
