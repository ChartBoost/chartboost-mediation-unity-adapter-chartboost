using Chartboost.Mediation.Chartboost.Common;

namespace Chartboost.Mediation.Chartboost.Default
{
    internal class ChartboostDefault : IChartboostAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => ChartboostAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => ChartboostAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "chartboost";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "Chartboost";
    }
}
