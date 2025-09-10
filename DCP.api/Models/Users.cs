using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Users")]
public class User
{
    [Key]
    [Column("UserID")]
    public string UserID { get; set; }

    public string PasswordHash { get; set; }
    public string PhoneNumber { get; set; }
    public string EmployeeID { get; set; }
    public string EntryBy { get; set; }
    public DateTime EntryDate { get; set; }
}
