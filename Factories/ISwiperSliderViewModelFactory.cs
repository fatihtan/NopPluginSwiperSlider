using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.Widgets.SwiperSlider.Models;

namespace Nop.Plugin.Widgets.SwiperSlider.Factories
{
    public interface ISwiperSliderViewModelFactory
    {
        Task<List<SwiperSliderViewModel>> GetAllSliders();
    }
}
