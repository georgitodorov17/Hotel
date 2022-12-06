using System.ComponentModel.DataAnnotations;

namespace BusinessLayer;

public class Client
{
    [Key] public string ID { get; set; }
    [Required] public string FName { get; set; }
    [Required] public string LName { get; set; }
    [Required] public string PhoneNumber { get; set; }
    [Required] public bool IsAdult { get; set; }

    private Client()
    {

    }

    public Client(string fname, string lname, string phoneNumber, bool isadult = true)
    {
        this.ID = Guid.NewGuid().ToString();
        this.FName = fname;
        this.LName = lname;
        this.PhoneNumber = phoneNumber;
        this.IsAdult = isadult;
    }

}