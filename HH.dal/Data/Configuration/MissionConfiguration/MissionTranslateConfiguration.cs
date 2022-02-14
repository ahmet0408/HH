using HH.dal.Models.Mission;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Data.Configuration.MissionConfiguration
{
    public class MissionTranslateConfiguration: IEntityTypeConfiguration<MissionTranslate>
    {
        public void Configure(EntityTypeBuilder<MissionTranslate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MissionId).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.LanguageCulture).IsRequired();
        }
    }
}
