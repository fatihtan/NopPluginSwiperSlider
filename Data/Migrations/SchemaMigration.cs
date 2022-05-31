using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using Nop.Data.Extensions;
using Nop.Data.Migrations;
using Nop.Plugin.Widgets.SwiperSlider.Data.Domain;

namespace Nop.Plugin.Widgets.SwiperSlider.Data.Migrations
{
    [NopMigration("2022-01-01 00:00:00", "Nop.Plugin.Widgets.SwiperSlider base schema", MigrationProcessType.Installation)]
    public class SchemaMigration : AutoReversingMigration
    {
        protected IMigrationManager _migrationManager;

        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }

        public override void Up()
        {
            Create.TableFor<Domain.Slider>();
            Create.TableFor<SliderItem>();
        }
    }
}