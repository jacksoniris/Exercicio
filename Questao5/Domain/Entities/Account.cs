using Microsoft.Extensions.Logging;
using Questao5.Domain.Entities.Base;

namespace Questao5.Domain.Entities
{
    public class Account : BaseEntity
    {

        public int Number { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Moviment> Moviments { get; set; }
    }
}
