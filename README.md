# API Client boilerplate template

A boilerplate API client template for those that want to build a .Net API clients wrappers

![API Client Boilerplate](https://raw.githubusercontent.com/guibranco/apiclient-boilerplate-dotnet/master/logo.png)

## CI/CD

[![Build status](https://ci.appveyor.com/api/projects/status/appVeyorId?svg=true)](https://ci.appveyor.com/project/USER/REPOSITORY)
[![GitHub last commit](https://img.shields.io/github/last-commit/guibranco/apiclient-boilerplate-dotnet)](https://github.com/guibranco/apiclient-boilerplate-dotnet)
[![GitHub last release](https://img.shields.io/github/release-date/guibranco/apiclient-boilerplate-dotnet.svg?style=flat)](https://github.com/guibranco/apiclient-boilerplate-dotnet)
[![GitHub license](https://img.shields.io/github/license/guibranco/apiclient-boilerplate-dotnet)](https://github.com/guibranco/apiclient-boilerplate-dotnet)
[![time tracker](https://wakatime.com/badge/github/guibranco/apiclient-boilerplate-dotnet.svg)](https://wakatime.com/badge/github/guibranco/apiclient-boilerplate-dotnet)

## Code Quality

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/codacyid)](https://www.codacy.com/manual/changeme/codacyid)
[![Codacy Badge](https://api.codacy.com/project/badge/Coverage/codacyid)](https://www.codacy.com/manual/changeme/codacyid)
[![Codecov](https://codecov.io/gh/USER/REPO/branch/master/graph/badge.svg)](https://codecov.io/gh/USER/REPO)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=USER_REPO&metric=alert_status)](https://sonarcloud.io/dashboard?id=USER_REPO)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=USER_REPO&metric=coverage)](https://sonarcloud.io/dashboard?id=USER_REPO)

[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=USER_REPO&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=USER_REPO)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=USER_REPO&metric=ncloc)](https://sonarcloud.io/dashboard?id=USER_REPO)
[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=USER_REPO&metric=sqale_index)](https://sonarcloud.io/dashboard?id=USER_REPO)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=USER_REPO&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=USER_REPO)

[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=USER_REPO&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=USER_REPO)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=USER_REPO&metric=security_rating)](https://sonarcloud.io/dashboard?id=USER_REPO)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=USER_REPO&metric=code_smells)](https://sonarcloud.io/dashboard?id=USER_REPO)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=USER_REPO&metric=bugs)](https://sonarcloud.io/dashboard?id=USER_REPO)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=USER_REPO&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=USER_REPO)

---

## Installation

[![PacakgeName NuGet Version](https://img.shields.io/nuget/v/PackageName.svg?style=flat)](https://www.nuget.org/packages/PackageName/)
[![PacakgeName NuGet Downloads](https://img.shields.io/nuget/dt/PackageName.svg?style=flat)](https://www.nuget.org/packages/PackageName/)
[![Github All Releases](https://img.shields.io/github/downloads/USER/REPO/total.svg?style=flat)](https://github.com/USER/REPO)

Download the latest zip file from the [Release pages](https://github.com/USER/REPO/releases) or simple install from [NuGet](https://www.nuget.org/packages/PackageName) package manager.

NuGet URL: [https://www.nuget.org/packages/PackageName](https://www.nuget.org/packages/PackageName)

NuGet installation via *Package Manager Console*:

```ps

Install-Package PackageName

```

---

## Features

Implements all features of Project name API available at [Project name](https://project.name.com/)

- Feature #1
- Feature #2
- Feature #3
- Feature #N

---

## Usage

```cs

//sample CSharp code showing how to use the lib
var client = new PackageNameClient();
client.CallSomeMethod();

```

---

Remove from this line to the end, after reading the **instructions below**

## Instructions on how to use this template

- Change the *appveyor.yml* with your **token*s* (use a secure token).
- Change *SolutionName.sln* to your own solution/project name.
- Change project name (**SolutionName.csproj** and **SolutionName.Tests.csproj**) and namespace inside folders **Src** and **Tests**.
- Change the package name in the *SolutionName.csproj*.
- Change the *main project* reference in the tests project in file *Tests/SolutionName.Tests.csproj*
- Fix in the *readme* the path of the badges and remove this section.
- Add to *readme* usage instructions of your client/SDK.
- Update _config.yml with project details (github.io docs website)
