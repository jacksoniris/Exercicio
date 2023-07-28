using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Questao5.Domain.Entities;
using Questao5.Domain.Enumerators;
using Questao5.Infrastructure.Database.Context.Configuration.Base;

namespace Questao5.Infrastructure.Database.Context.Configuration
{
    public class IdempotentEntityTypeConfiguration : BaseEntityTypeConfiguration<Idempotent>
    {
        public override void Configure(EntityTypeBuilder<Idempotent> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Requisicao)
                .IsRequired();

            builder.Property(x => x.Resultado)
                .IsRequired();

        }
    }
}