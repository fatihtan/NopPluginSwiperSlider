using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;
using Nop.Web.Framework.Menu;

namespace Nop.Plugin.Widgets.SwiperSlider
{
    public class SwiperSliderPlugin : BasePlugin, IWidgetPlugin, IAdminMenuPlugin
    {
        private readonly IWebHelper _iWebHelper;
        private readonly ISettingService _iSettingService;
        private readonly ILocalizationService _iLocalizationService;

        public SwiperSliderPlugin(
            IWebHelper iWebHelper,
            ISettingService iSettingService,
            ILocalizationService iLocalizationService)
        {
            this._iWebHelper = iWebHelper;
            this._iSettingService = iSettingService;
            this._iLocalizationService = iLocalizationService;
        }

        public bool HideInWidgetList => false;

        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "SwiperSlider";
        }

        public async Task<IList<string>> GetWidgetZonesAsync()
        {
            return await Task.FromResult(new List<string>() { PublicWidgetZones.HomepageTop, PublicWidgetZones.ProductDetailsTop });
        }

        public Task ManageSiteMapAsync(SiteMapNode rootNode)
        {
            throw new NotImplementedException();
        }

        public override Task InstallAsync()
        {
            return base.InstallAsync();
        }

        public override Task UninstallAsync()
        {
            return base.UninstallAsync();
        }

        public override string GetConfigurationPageUrl()
        {
            return base.GetConfigurationPageUrl();
        }
    }
}