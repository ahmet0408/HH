using HH.dal.Models.Contact;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Data.Configuration.ContactConfiguration
{
    public class UserConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Test).IsRequired();
            builder.Property(x => x.NatureOfBusiness).IsRequired();
            builder.Property(x => x.Adress).IsRequired();
            builder.Property(x => x.PostCode).IsRequired();
            builder.Property(x => x.ContactName).IsRequired();
            builder.Property(x => x.ContactPhone).IsRequired();
            builder.Property(x => x.EmailAdress).IsRequired();
            builder.Property(x => x.Idea).IsRequired();
            builder.Property(x => x.File).IsRequired();
        }

    }
}
