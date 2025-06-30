# Chartboost Mediation Unity SDK - Chartboost Adapter

Provides a list of externally configurable properties pertaining to the partner SDK that can be retrieved and set by publishers. 

Dependencies for the adapter are now embedded in the package, and can be found at `com.chartboost.mediation.unity.adapter.chartboost/Editor/ChartboostAdapterDependencies.xml`.

# Installation

## Using the public [npm registry](https://www.npmjs.com/search?q=com.chartboost.mediation.unity.adapter.chartboost)

In order to add the Chartboost Mediation Unity SDK - Chartboost Adapter to your project using the npm package, add the following to your Unity Project's ***manifest.json*** file. The scoped registry section is required in order to fetch packages from the NpmJS registry.

```json
"dependencies": {
    "com.chartboost.mediation.unity.adapter.chartboost": "5.0.5",
    ...
},
"scopedRegistries": [
{
    "name": "NpmJS",
    "url": "https://registry.npmjs.org",
    "scopes": [
    "com.chartboost"
    ]
}
]
```
## Using the public [NuGet package](https://www.nuget.org/packages/Chartboost.CSharp.Mediation.Unity.Adapter.Chartboost)

To add the Chartboost Mediation Unity SDK - Chartboost Adapter to your project using the NuGet package, you will first need to add the [NugetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) package into your Unity Project.

This can be done by adding the following to your Unity Project's ***manifest.json***

```json
  "dependencies": {
    "com.github-glitchenzo.nugetforunity": "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
    ...
  },
```

Once <code>NugetForUnity</code> is installed, search for `Chartboost.CSharp.Mediation.Unity.Adapter.Chartboost` in the search bar of Nuget Explorer window(Nuget -> Manage Nuget Packages).
You should be able to see the `Chartboost.CSharp.Mediation.Unity.Adapter.Chartboost` package. Choose the appropriate version and install.

# AndroidManifest.xml Permissions

Add the following required permissions to your Android Manifest .xml file:

```xml
<uses-permission android:name="android.permission.INTERNET" />
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
```

Optional (but recommended) permissions: Allows the SDK to handle calls that interrupt video playback

```xml
<uses-permission android:name="android.permission.READ_PHONE_STATE" />
```

# Usage
The following code block exemplifies usage of the `ChartboostAdapter.cs` configuration class.

## IPartnerAdapterConfiguration Properties

```csharp

// AdapterUnityVersion - The partner adapter Unity version, e.g: 5.0.0
Debug.Log($"Adapter Unity Version: {ChartboostAdapter.AdapterUnityVersion}");

// AdapterNativeVersion - The partner adapter version, e.g: 5.9.6.1.0
Debug.Log($"Adapter Native Version: {ChartboostAdapter.AdapterNativeVersion}");

// PartnerSDKVersion - The partner SDK version, e.g: 9.6.1
Debug.Log($"Partner SDK Version: {ChartboostAdapter.PartnerSDKVersion}");

// PartnerIdentifier - The partner ID for internal uses, e.g: chartboost
Debug.Log($"Partner Identifier: {ChartboostAdapter.PartnerIdentifier}");

// PartnerDisplayName - The partner name for external uses, e.g: Chartboost
Debug.Log($"Partner Display Name: {ChartboostAdapter.PartnerDisplayName}");
```
