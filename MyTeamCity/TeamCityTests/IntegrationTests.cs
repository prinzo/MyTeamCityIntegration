using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTeamCity.Enums;

namespace TeamCityTests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public void RetrieveAllBuilds()
        {
            var teamCity = new MyTeamCity.MyTeamCity("prinay.panday", "password",
                "http://localhost:70");

            var builds = teamCity.GetAllBuilds().Result;
            Assert.IsNotNull(builds);
        }

        [TestMethod]
        public void RetrieveAllAgents()
        {
            var teamCity = new MyTeamCity.MyTeamCity("prinay.panday", "password",
                "http://localhost:70");

            var builds = teamCity.GetAllAgents().Result;
            Assert.IsNotNull(builds);
        }

        [TestMethod]
        public void RetrieveAllUsers()
        {
            var teamCity = new MyTeamCity.MyTeamCity("prinay.panday", "password",
                "http://localhost:70");

            var builds = teamCity.GetAllUsers().Result;
            Assert.IsNotNull(builds);
        }

        [TestMethod]
        public void RetrieveAllProjects()
        {
            var teamCity = new MyTeamCity.MyTeamCity("prinay.panday", "password",
                "http://localhost:70");

            var builds = teamCity.GetAllProjects().Result;
            Assert.IsNotNull(builds);
        }

        [TestMethod]
        public void RetrieveAllSuccessfulBuilds()
        {
            var teamCity = new MyTeamCity.MyTeamCity("prinay.panday", "password",
                "http://localhost:70");

            var builds = teamCity.GetAllSuccessfulBuilds().Result;
            Assert.IsNotNull(builds);
        }

        [TestMethod]
        public void RetrieveAllUnsuccessfulBuilds()
        {
            var teamCity = new MyTeamCity.MyTeamCity("prinay.panday", "password",
                "http://localhost:70");

            var builds = teamCity.GetAllUnsuccessfulBuilds().Result;
            Assert.IsNotNull(builds);
        }

        [TestMethod]
        public void RetrieveAllBuildsSinceDate()
        {
            var teamCity = new MyTeamCity.MyTeamCity("prinay.panday", "password",
                "http://localhost:70");

            var builds = teamCity.GetBuildsSinceDate(new DateTime(01,01,01)).Result;
            Assert.IsNotNull(builds);
        }

        [TestMethod]
        public void RetrieveAllBuildsWithStatusSinceDate()
        {
            var teamCity = new MyTeamCity.MyTeamCity("prinay.panday", "password",
                "http://localhost:70");

            var builds = teamCity.GetAllBuildsWithStatusSinceDate(new DateTime(01,01,01), BuildStatus.SUCCESS).Result;
            Assert.IsNotNull(builds);
        }

        [TestMethod]
        public void RetrieveAllBuildsWithStatus()
        {
            var teamCity = new MyTeamCity.MyTeamCity("prinay.panday", "password",
                "http://localhost:70");

            var builds = teamCity.GetAllBuildsWithStatus(BuildStatus.SUCCESS).Result;
            Assert.IsNotNull(builds);
        }

        [TestMethod]
        public void RetrieveAllBuildsByUser()
        {
            var teamCity = new MyTeamCity.MyTeamCity("prinay.panday", "password",
                "http://localhost:70");

            var builds = teamCity.GetBuildsByUser("prinay.panday").Result;
            Assert.IsNotNull(builds);
        }

        [TestMethod]
        public void RetrieveAllBuildsByUserWithStatus()
        {
            var teamCity = new MyTeamCity.MyTeamCity("prinay.panday", "password",
                "http://localhost:70");

            var builds = teamCity.GetBuildsByUserWithStatus("prinay.panday", BuildStatus.FAILURE).Result;
            Assert.IsNotNull(builds);
        }

        [TestMethod]
        public void RetrieveLastBuildForProjectByStatus()
        {
            var teamCity = new MyTeamCity.MyTeamCity("prinay.panday", "password",
                "http://localhost:70");

            var builds = teamCity.GetLastBuildWithStatusForProject(BuildStatus.SUCCESS, "Budget").Result;
            Assert.IsNotNull(builds);
        }

        [TestMethod]
        public void RetrieveAllRunningBuilds()
        {
            var teamCity = new MyTeamCity.MyTeamCity("prinay.panday", "password",
                "http://localhost:70");

            var builds = teamCity.GetRunningBuilds().Result;
            Assert.IsNotNull(builds);
        }
    }
}
