using System.Runtime.CompilerServices;
using Chartboost.Mediation.Chartboost;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.ChartboostAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.ChartboostAssemblyInfoIOS)]

namespace Chartboost.Mediation.Chartboost
{
    internal class AssemblyInfo
    {
        public const string ChartboostAssemblyInfoAndroid = "Chartboost.Mediation.Chartboost.Android";
        public const string ChartboostAssemblyInfoIOS = "Chartboost.Mediation.Chartboost.IOS";
    }
}
