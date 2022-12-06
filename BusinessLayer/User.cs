using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer;


public class User
{
    [Key] 
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string FName { get; set; }
    [Required]
    public string MName { get; set; }
    [Required]
    public string LName { get; set; }
    [Required]
    public string EGN { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required] 
    public string Email { get; set; }
    [Column(TypeName = "datetime2")]
    [Required]
    public DateTime HiringDate { get; set; }
    [Required]
    public bool IsActive { get; set; }
    [Column(TypeName = "datetime2")]
    public DateTime FiringDate { get; set; }

    private User()
    {
        
    }

    public User(string username, string password, string fname, string mname, string lname, string egn, string phonenumber, string email, DateTime hiringdate)
    {
        this.Username = username;
        this.Password = password;
        this.FName = fname;
        this.MName = mname;
        this.LName = lname;
        this.EGN = egn;
        this.PhoneNumber = phonenumber;
        this.Email = email;
        this.HiringDate = hiringdate;
        this.IsActive = true;

    }

}