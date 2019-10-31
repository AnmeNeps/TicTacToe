using Abp.AutoMapper;
using ItSutra.GameTic.Authentication.External;

namespace ItSutra.GameTic.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
