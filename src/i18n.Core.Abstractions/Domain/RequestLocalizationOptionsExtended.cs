using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;

namespace i18n.Core.Abstractions.Domain
{
    public class RequestLocalizationOptionsExtended : RequestLocalizationOptions
    {
        public RequestCulture DefaultPotRequestCulture { get; set; }

    }
}
