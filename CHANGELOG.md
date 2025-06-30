# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.5 *(2025-06-03)*
This version of the Chartboost Adapter supports the following native SDK dependencies:
* Android: `com.chartboost:chartboost-mediation-adapter-chartboost:5.9.9.+`
* iOS: `ChartboostMediationAdapterChartboost: ~> 5.9.9.0`

### Version 5.0.4 *(2025-05-28)*
Bug Fixes:
* Made `ChartboostSDK: ~> 5.9.9.0` be added to all targets for proper resource bundling.

### Version 5.0.3 *(2025-05-20)*
This version of the Chartboost Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-chartboost:5.9.8.+`
  * iOS: `ChartboostMediationAdapterChartboost: ~> 5.9.9.0`

### Version 5.0.2 *(2024-11-14)*
This version of the Chartboost Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-chartboost:5.9.8.+`
  * iOS: `ChartboostMediationAdapterChartboost: ~> 5.9.8.0`

### Version 5.0.1 *(2024-11-14)*
This version of the Chartboost Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-chartboost:5.9.8.+`
  * iOS: `ChartboostMediationAdapterChartboost: ~> 5.9.7.0`

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - Chartboost Adapter.

#Added
- Support for the following `Chartboost` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-chartboost:5.9.7.+`
    * iOS: `ChartboostMediationAdapterChartboost ~> 5.9.7.0`
    
- `ChartboostAdapter.cs` with Configuration Properties for `Chartboost`.
- The following properties have been added in `ChartboostAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`