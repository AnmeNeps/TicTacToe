using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ItSutra.GameTic.Controllers
{
    public abstract class GameTicControllerBase: AbpController
    {
        protected GameTicControllerBase()
        {
            LocalizationSourceName = GameTicConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
