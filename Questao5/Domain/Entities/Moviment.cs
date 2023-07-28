using Microsoft.EntityFrameworkCore.ChangeTracking;
using Questao5.Domain.Entities.Base;
using Questao5.Domain.Enumerators;

namespace Questao5.Domain.Entities
{
    public class Moviment : BaseEntity
    {
        public Guid AccountId { get; set; }
        public DateTime DateCreated { get; set; }
        public MovimentType Type { get; set; }
        public double Value { get; set; }


        public Moviment(Guid accountId, MovimentType type, double value)
        {
            Id = Guid.NewGuid();
            AccountId = accountId;
            DateCreated = DateTime.UtcNow;
            Type = type;
            Value = value;
        }
    }
}
