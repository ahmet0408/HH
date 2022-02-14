using HH.dal.Models.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Data.Configuration.ProjectConfiguration
{
    public class ProjectTranslateConfiguration: IEntityTypeConfiguration<ProjectTranslate>
    {
        public void Configure(EntityTypeBuilder<ProjectTranslate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProjectId).IsRequired();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.LanguageCulture).IsRequired();
        }
    }
}
