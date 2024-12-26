using EnumsPlusCompositions.Entities;

namespace EnumsPlusCompositions.Entities {
class Order {
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    }
}