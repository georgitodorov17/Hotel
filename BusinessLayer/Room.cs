using System.ComponentModel.DataAnnotations;

namespace BusinessLayer;

public class Room
{
    [Key]
    public int RoomNumber { get; set; }
    [Required]
    public int Capacity { get; set; }
    [Required]
    public string RoomType { get; set; }
    [Required]
    public bool IsFree { get; set; }
    [Required]
    public double PricePerBedAdult { get; set; }
    [Required]
    public double PricePerBedChild { get; set; }

    private Room()
    {
        
    }

    public Room(int roomnum, int capacity, string roomtype, double pricePerBedAdult, double pricePerBedChild, bool isfree = true)
    {
        this.RoomNumber = roomnum;
        this.Capacity = capacity;
        this.RoomType = roomtype;
        this.PricePerBedAdult = pricePerBedAdult;
        this.PricePerBedChild = pricePerBedChild;
        this.IsFree = isfree;
    }
}