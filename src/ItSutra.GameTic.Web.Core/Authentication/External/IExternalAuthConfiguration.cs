using System.Collections.Generic;

namespace ItSutra.GameTic.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
