using MedicaNow.Domain.Enums;

namespace FKA.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime RecordDate { get; set; }
        public EnumDataType DataType { get; set; }
    }
}
