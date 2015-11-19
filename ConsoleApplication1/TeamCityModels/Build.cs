namespace TeamCityCSharp.TeamCityModels
{
    public class Build
    {
        public string id { get; set; }
        public string number { get; set; }
        public string queuedDate { get; set; }
        public string startDate { get; set; }
        public string finishDate { get; set; }
        public string status { get; set; }
        public lastChanges lastChanges { get; set; }
    }
}
