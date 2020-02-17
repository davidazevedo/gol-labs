using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GolLabs.Controllers
{
    public abstract class GolLabsControllerBase: AbpController
    {
        protected GolLabsControllerBase()
        {
            LocalizationSourceName = GolLabsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
