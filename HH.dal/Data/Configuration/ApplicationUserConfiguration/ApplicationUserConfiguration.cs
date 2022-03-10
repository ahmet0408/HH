using HH.dal.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using HH.dal.Models.User;

namespace HH.dal.Data.Configuration.ApplicationUserConfiguration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(p => p.FirstName).IsRequired(false);
            builder.Property(p => p.LastName).IsRequired(false);
            builder.Property(p => p.SecondName).IsRequired(false);
            builder.Property(p => p.DateBirthday).IsRequired(false);
            builder.Property(p => p.Photo).IsRequired(false);
            builder.Property(p => p.OrganizationId).IsRequired(false);
        }
    }
}
