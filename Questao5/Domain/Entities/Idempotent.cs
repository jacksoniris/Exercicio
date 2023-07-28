using Questao5.Domain.Entities.Base;

namespace Questao5.Domain.Entities
{
    public class Idempotent: BaseEntity
    {
        public string? Request { get; set; }
        public string? Response { get; set; }
    }
}
