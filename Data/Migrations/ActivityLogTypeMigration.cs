using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using Nop.Core.Domain.Logging;
using Nop.Data;
using Nop.Data.Migrations;

namespace Nop.Plugin.Widgets.SwiperSlider.Data.Migrations
{
    [NopMigration("2022-01-01 00:00:00", "Nop.Plugin.Widgets.SwiperSlider Activity Log Types", MigrationProcessType.Installation)]
    public class ActivityLogTypeMigration : AutoReversingMigration
    {
        #region Fields
        private readonly INopDataProvider _dataProvider;
        #endregion

        #region Ctor
        public ActivityLogTypeMigration(INopDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }
        #endregion

        public override void Up()
        {
            if (!_dataProvider.GetTable<ActivityLogType>().Any(pr => string.Compare(pr.SystemKeyword, "AddNewSwiperSlider", StringComparison.InvariantCultureIgnoreCase) == 0))
            {
                _dataProvider.InsertEntity(new ActivityLogType
                {
                    Name = "Add a new swiper slider",
                    SystemKeyword = "AddNewSwiperSlider",
                    Enabled = true
                });
            }

            if (!_dataProvider.GetTable<ActivityLogType>().Any(pr => string.Compare(pr.SystemKeyword, "EditSwiperSlider", StringComparison.InvariantCultureIgnoreCase) == 0))
            {
                _dataProvider.InsertEntity(new ActivityLogType
                {
                    Name = "Edit swiper slider",
                    SystemKeyword = "EditSwiperSlider",
                    Enabled = true
                });
            }

            if (!_dataProvider.GetTable<ActivityLogType>().Any(pr => string.Compare(pr.SystemKeyword, "DeleteSwiperSlider", StringComparison.InvariantCultureIgnoreCase) == 0))
            {
                _dataProvider.InsertEntity(new ActivityLogType
                {
                    Name = "Delete a swiper slider",
                    SystemKeyword = "DeleteSwiperSlider",
                    Enabled = true
                });
            }

            if (!_dataProvider.GetTable<ActivityLogType>().Any(pr => string.Compare(pr.SystemKeyword, "DeleteSwiperSliders", StringComparison.InvariantCultureIgnoreCase) == 0))
            {
                _dataProvider.InsertEntity(new ActivityLogType
                {
                    Name = "Delete multiple swiper sliders",
                    SystemKeyword = "DeleteSwiperSliders",
                    Enabled = true
                });
            }


            // Slider Item Log Types
            if (!_dataProvider.GetTable<ActivityLogType>().Any(pr => string.Compare(pr.SystemKeyword, "AddNewSwiperSliderItem", StringComparison.InvariantCultureIgnoreCase) == 0))
            {
                _dataProvider.InsertEntity(new ActivityLogType
                {
                    Name = "Add a new swiper slider item",
                    SystemKeyword = "AddNewSwiperSliderItem",
                    Enabled = true
                });
            }

            if (!_dataProvider.GetTable<ActivityLogType>().Any(pr => string.Compare(pr.SystemKeyword, "EditSwiperSliderItem", StringComparison.InvariantCultureIgnoreCase) == 0))
            {
                _dataProvider.InsertEntity(new ActivityLogType
                {
                    Name = "Edit swiper slider item",
                    SystemKeyword = "EditSwiperSliderItem",
                    Enabled = true
                });
            }

            if (!_dataProvider.GetTable<ActivityLogType>().Any(pr => string.Compare(pr.SystemKeyword, "DeleteSwiperSliderItem", StringComparison.InvariantCultureIgnoreCase) == 0))
            {
                _dataProvider.InsertEntity(new ActivityLogType
                {
                    Name = "Delete a swiper slider item",
                    SystemKeyword = "DeleteSwiperSliderItem",
                    Enabled = true
                });
            }

            if (!_dataProvider.GetTable<ActivityLogType>().Any(pr => string.Compare(pr.SystemKeyword, "DeleteSwiperSliderItems", StringComparison.InvariantCultureIgnoreCase) == 0))
            {
                _dataProvider.InsertEntity(new ActivityLogType
                {
                    Name = "Delete multiple swiper slider itemss",
                    SystemKeyword = "DeleteSwiperSliderItems",
                    Enabled = true
                });
            }
        }
    }
}
