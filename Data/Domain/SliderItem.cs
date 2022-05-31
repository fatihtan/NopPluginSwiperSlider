﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Core.Domain.Security;
using Nop.Core.Domain.Stores;

namespace Nop.Plugin.Widgets.SwiperSlider.Data.Domain
{
    public class SliderItem : BaseEntity, IStoreMappingSupported, IAclSupported
    {
        public int SliderId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string AlternateText { get; set; }
        public int PictureId { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
        public bool LimitedToStores { get; set; }
        public bool SubjectToAcl { get; set; }
    }
}