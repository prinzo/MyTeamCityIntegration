using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeamCity.TeamCityModels
{
    public class TeamCityBuildList
    {
        public string count { get; set; }
        public string href { get; set; }
        public List<BaseBuild> build { get; set; }
    }
}
