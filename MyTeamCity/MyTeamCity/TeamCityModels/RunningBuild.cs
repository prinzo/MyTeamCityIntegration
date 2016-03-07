using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeamCity.TeamCityModels
{
    public class RunningBuild
    {
        public string id { get; set; }
        public string buildTypeId { get; set; }
        public string number { get; set; }
        public string status { get; set; }
        public string state { get; set; }
        public string running { get; set; }
        public string percentageComplete { get; set; }
        public string href { get; set; }
        public string webUrl { get; set; }
    }
}
