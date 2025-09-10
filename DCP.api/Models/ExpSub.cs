using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ExpSub")]
public class ExpSub
{
    [Key]
    public string ExpSubCode { get; set; }
    public string ExpDetails { get; set; }
    public string ExpCode { get; set; }
    public string UserID { get; set; }
    public DateTime EntryDate { get; set; }
}
