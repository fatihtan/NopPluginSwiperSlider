﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.Configuration;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;
using Nop.Plugin.Widgets.SwiperSlider.Areas.Admin.Models;
using Nop.Plugin.Widgets.SwiperSlider.Areas.Admin.Services;
using Nop.Plugin.Widgets.SwiperSlider.Areas.Admin.Validators;
using Nop.Data.Extensions;
using Nop.Plugin.Widgets.SwiperSlider.Factories;

namespace Nop.Plugin.Widgets.SwiperSlider.Infrastructure
{
    public class SwiperSliderStartup : INopStartup
    {
        public int Order => int.MaxValue;

        public void Configure(IApplicationBuilder application)
        {
        }

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ISwiperSliderService, SwiperSliderService>();
            services.AddScoped<ISwiperSliderModelFactory, SwiperSliderModelFactory>();
            services.AddScoped<ISwiperSliderViewModelFactory, SwiperSliderViewModelFactory>();

            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationExpanders.Add(new SwiperSliderViewLocationExpander());
            });

            services.AddTransient<IValidator<SwiperSliderModel>, SwiperSliderValidator>();
        }
    }
}
