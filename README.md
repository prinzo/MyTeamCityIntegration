# MyTeamCityIntegration
TeamCity Integration Using C#

A class library that integrates with Team City.

I am currently developing more functionality and refactoring the implementation.

Feel free to fork and send me your ideas.

###Usage:
```var myTeamCity = new MyTeamCity("username", "password", "TeamCityServer");```

```var successfulBuilds = myTeamCity.GetAllSuccessfulBuilds();```


####Builds

```GetAllBuilds()```
```GetAllSuccessfulBuilds()```
```GetAllUnsuccessfulBuilds()```
```GetBuildsSinceDate()```
```GetAllBuildsWithStatusSinceDate()```
```GetAllBuildsWithStatus()```
```GetBuildsByUser()```
```GetBuildsByUserWithStatus()```
```GetBuildsByUserWithStatusForProject()```
```GetLastBuildWithStatusForProject()```

####Users
```GetAllUsers()```

####Projects
```GetAllProjects()

####Agents
```GetAllAgents()```

##License

The MIT License (MIT)

Copyright (c) 2015 kurtvining

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
