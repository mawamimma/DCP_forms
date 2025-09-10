using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Expend")]
public class Expend
{
    [Key]
    public string ExpenditureID { get; set; }
    public string ExpSubCode { get; set; }
    public DateTime ExpDate { get; set; }
    public string UserID { get; set; }
    public DateTime EntryDate { get; set; }
}
