# PIX (BACEN) .NET SDK

Brazilian instantly payments (PIX) powered by BACEN (Banco Central do Brasil) contracts ready to use for .NET projects.

PIX contracts available at: [bacen/pix-api](https://github.com/bacen/pix-api/) and [bacen/pix-dict-api](https://github.com/bacen/pix-dict-api)

[![GitHub license](https://img.shields.io/github/license/guibranco/PIX-BACEN-SDK-dotnet)](https://github.com/guibranco/PIX-BACEN-SDK-dotnet)
[![time tracker](https://wakatime.com/badge/github/guibranco/PIX-BACEN-SDK-dotnet.svg)](https://wakatime.com/badge/github/guibranco/PIX-BACEN-SDK-dotnet)

![PIX (BACEN)](https://raw.githubusercontent.com/guibranco/PIX-BACEN-SDK-dotnet/main/logo.png)

## CI/CD

| Build status | Last commit | Tests | Coverage | Code Smells | LoC | 
|--------------|-------------|-------|----------|-------------|-----|
| [![Build status](https://ci.appveyor.com/api/projects/status/9p2o5g1x3i0sqsq8/branch/main?svg=true)](https://ci.appveyor.com/project/guibranco/PIX-BACEN-SDK-dotnet/branch/main) | [![GitHub last commit](https://img.shields.io/github/last-commit/guibranco/PIX-BACEN-SDK-dotnet/main)](https://github.com/guibranco/PIX-BACEN-SDK-dotnet) | [![AppVeyor tests (branch)](https://img.shields.io/appveyor/tests/guibranco/PIX-BACEN-SDK-dotnet/main?compact_message)](https://ci.appveyor.com/project/guibranco/PIX-BACEN-SDK-dotnet/branch/main) | [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=guibranco_PIX-BACEN-SDK-dotnet&metric=coverage)](https://sonarcloud.io/dashboard?id=guibranco_PIX-BACEN-SDK-dotnet) | [![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=guibranco_PIX-BACEN-SDK-dotnet&metric=code_smells)](https://sonarcloud.io/dashboard?id=guibranco_PIX-BACEN-SDK-dotnet) | [![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=guibranco_PIX-BACEN-SDK-dotnet&metric=ncloc)](https://sonarcloud.io/dashboard?id=guibranco_PIX-BACEN-SDK-dotnet)


## Code Quality

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/fb3b0b3876fb4e85a33ba9c891bfa3b3)](https://www.codacy.com/gh/guibranco/PIX-BACEN-SDK-dotnet/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=guibranco/VTEX-SDK-dotnet&amp;utm_campaign=Badge_Grade)
[![Codacy Badge](https://app.codacy.com/project/badge/Coverage/fb3b0b3876fb4e85a33ba9c891bfa3b3)](https://www.codacy.com/gh/guibranco/PIX-BACEN-SDK-dotnet/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=guibranco/VTEX-SDK-dotnet&amp;utm_campaign=Badge_Coverage)
[![Codecov](https://codecov.io/gh/guibranco/PIX-BACEN-SDK-dotnet/branch/main/graph/badge.svg)](https://codecov.io/gh/guibranco/PIX-BACEN-SDK-dotnet)

[![Maintainability](https://api.codeclimate.com/v1/badges/62b8548ab33f1c845d68/maintainability)](https://codeclimate.com/github/guibranco/PIX-BACEN-SDK-dotnet/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/62b8548ab33f1c845d68/test_coverage)](https://codeclimate.com/github/guibranco/PIX-BACEN-SDK-dotnet/test_coverage)

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=guibranco_PIX-BACEN-SDK-dotnet&metric=alert_status)](https://sonarcloud.io/dashboard?id=guibranco_PIX-BACEN-SDK-dotnet)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_PIX-BACEN-SDK-dotnet&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=guibranco_PIX-BACEN-SDK-dotnet)

[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=guibranco_PIX-BACEN-SDK-dotnet&metric=sqale_index)](https://sonarcloud.io/dashboard?id=guibranco_PIX-BACEN-SDK-dotnet)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=guibranco_PIX-BACEN-SDK-dotnet&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=guibranco_PIX-BACEN-SDK-dotnet)

[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_PIX-BACEN-SDK-dotnet&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=guibranco_PIX-BACEN-SDK-dotnet)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_PIX-BACEN-SDK-dotnet&metric=security_rating)](https://sonarcloud.io/dashboard?id=guibranco_PIX-BACEN-SDK-dotnet)

[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=guibranco_PIX-BACEN-SDK-dotnet&metric=bugs)](https://sonarcloud.io/dashboard?id=guibranco_PIX-BACEN-SDK-dotnet)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=guibranco_PIX-BACEN-SDK-dotnet&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=guibranco_PIX-BACEN-SDK-dotnet)

## Installation

### Github Releases

[![GitHub last release](https://img.shields.io/github/release-date/guibranco/PIX-BACEN-SDK-dotnet.svg?style=flat)](https://github.com/guibranco/PIX-BACEN-SDK-dotnet) [![Github All Releases](https://img.shields.io/github/downloads/guibranco/PIX-BACEN-SDK-dotnet/total.svg?style=flat)](https://github.com/guibranco/PIX-BACEN-SDK-dotnet)

Download the latest zip file from the [Release](https://github.com/GuiBranco/PIX-BACEN-SDK-dotnet/releases) page.

### Nuget package manager

| Package | Version | Downloads |
|------------------|:-------:|:-------:|
| **PIXBACEN** | [![PIXBACEN NuGet Version](https://img.shields.io/nuget/v/PIXBACEN.svg?style=flat)](https://www.nuget.org/packages/PIXBACEN/) | [![PIXBACEN NuGet Downloads](https://img.shields.io/nuget/dt/PIXBACEN.svg?style=flat)](https://www.nuget.org/packages/PIXBACEN/) |
