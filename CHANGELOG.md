# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - Chartboost Adapter.

#Added
- Support for the following `Chartboost` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-chartboost:5.9.6.+`
    * iOS: `ChartboostMediationAdapterChartboost ~> 5.9.7.0`
    
- `ChartboostAdapter.cs` with Configuration Properties for `Chartboost`.
- The following properties have been added in `ChartboostAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`