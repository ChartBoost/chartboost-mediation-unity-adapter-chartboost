using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.Chartboost.Common;
using UnityEngine;

namespace Chartboost.Mediation.Chartboost.IOS
{
    internal sealed class ChartboostAdapter : IChartboostAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            Chartboost.ChartboostAdapter.Instance = new ChartboostAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMChartboostAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMChartboostAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMChartboostAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMChartboostAdapterPartnerDisplayName();

        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMChartboostAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMChartboostAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMChartboostAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMChartboostAdapterPartnerDisplayName();
    }
}
