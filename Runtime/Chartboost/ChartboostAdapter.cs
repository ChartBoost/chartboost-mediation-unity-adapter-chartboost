using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.Chartboost.Common;
using Chartboost.Mediation.Chartboost.Default;

namespace Chartboost.Mediation.Chartboost
{
    /// <inheritdoc cref="IChartboostAdapter"/>
    public static class ChartboostAdapter 
    {
        internal static IChartboostAdapter Instance = new ChartboostDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.0.2";
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;
    }
}
