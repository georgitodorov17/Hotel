using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer;

public class Reservation
{
    [Key]
    public string ID { get; set; }
    [Required]
    public Room BookedRoom { get; set; }
    [Required]
    public List<Client> ClientsInRoom { get; set; }
    [Column(TypeName = "datetime2")]
    public DateTime ArrivalDate { get; set; }
    [Column(TypeName = "datetime2")]
    public DateTime DepartureDate { get; set; }
    [Required]
    public bool IsBreakfastIncluded { get; set; }
    [Required]
    public bool IsAllInclusive { get; set; }
    [Required]
    public double TotalCost { get; set; }

    private Reservation()
    {
        
    }

    public Reservation(Room room, List<Client> clients, DateTime arrivalDate, DateTime departureDate, bool isBreakfastIncluded, bool isAllInclusive)
    {
        this.BookedRoom = room;
        this.ClientsInRoom = clients;
        this.ArrivalDate = arrivalDate;
        this.DepartureDate = departureDate;
        this.IsBreakfastIncluded = isBreakfastIncluded;
        this.IsAllInclusive = isAllInclusive;
        //TODO: Calculate total cost using data from Room object
        this.TotalCost = 100d;

    }
}