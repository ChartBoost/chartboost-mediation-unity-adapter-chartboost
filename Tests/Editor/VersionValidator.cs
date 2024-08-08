using Chartboost.Editor;
using Chartboost.Logging;
using Chartboost.Mediation.Chartboost;
using NUnit.Framework;

namespace Chartboost.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.chartboost";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.Chartboost";
        
        [SetUp]
        public void SetUp() 
            => LogController.LoggingLevel = LogLevel.Debug;
            
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, ChartboostAdapter.AdapterUnityVersion);
    }
}
