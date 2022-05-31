using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Web.Framework.Validators;

namespace Nop.Plugin.Widgets.SwiperSlider.Areas.Admin.Validators
{
    public partial class SwiperSliderValidator : BaseNopValidator<SwiperSliderModel>
    {
        public SwiperSliderValidator(ILocalizationService localizationService, INopDataProvider dataProvider)
        {
            // Name boş geçilemez!
            RuleFor(m => m.Name)
                .NotEmpty()
                .WithMessageAwait(localizationService.GetResourceAsync("Nop.Plugin.Widgets.SwiperSlider.Sliders.Fields.Name.Required"));

            base.SetDatabaseValidationRules<Slider>(dataProvider);
        }
    }
}
