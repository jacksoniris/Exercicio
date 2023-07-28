using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Questao5.Domain.Entities;
using Questao5.Domain.Enumerators;
using Questao5.Infrastructure.Database.Context.Configuration.Base;

namespace Questao5.Infrastructure.Database.Context.Configuration
{
    public class MovimentEntityTypeConfiguration : BaseEntityTypeConfiguration<Moviment>
    {
        public override void Configure(EntityTypeBuilder<Moviment> builder)
        {
            base.Configure(builder);

             builder.Property(x => x.Id)
                  .HasConversion<string>();

            builder.Property(x => x.AccountId)             
                .HasConversion<string>()
                .IsRequired();

            builder.Property(x => x.DateCreated)
                .HasConversion<string>()
                .IsRequired();

            builder.Property(x => x.Type)
                 .HasConversion(new EnumToStringConverter<MovimentType>())
                 .IsRequired();

            builder.Property(x => x.Value)
                .IsRequired();

        }
    }
}