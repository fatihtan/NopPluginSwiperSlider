using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Nop.Core.Infrastructure.Mapper;
using Nop.Plugin.Widgets.SwiperSlider.Areas.Admin.Models;
using Nop.Plugin.Widgets.SwiperSlider.Data.Domain;

namespace Nop.Plugin.Widgets.SwiperSlider.Infrastructure
{
    public class AutoMapperConfiguration : Profile, IOrderedMapperProfile
    {
        public AutoMapperConfiguration()
        {
            Initialize();
        }

        public void Initialize()
        {
            CreateMap<Slider, SwiperSliderModel>().ReverseMap();
            CreateMap<SliderItem, SwiperSliderItemModel>().ReverseMap();
        }

        public int Order => int.MaxValue;

    }
}
