#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <ChartboostMediationAdapterChartboost/ChartboostMediationAdapterChartboost-Swift.h>

extern "C" {
    const char * _CBMChartboostAdapterAdapterVersion(){
        return toCStringOrNull([ChartboostAdapterConfiguration adapterVersion]);
    }

    const char * _CBMChartboostAdapterPartnerSDKVersion(){
        return toCStringOrNull([ChartboostAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMChartboostAdapterPartnerId(){
        return toCStringOrNull([ChartboostAdapterConfiguration partnerID]);
    }

    const char * _CBMChartboostAdapterPartnerDisplayName(){
        return toCStringOrNull([ChartboostAdapterConfiguration partnerDisplayName]);
    }
}
