using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ExpendHead")]
public class ExpendHead
{
    [Key]
    public int Id { get; set; }
    public string ExpCode { get; set; }
    public string ExpDetails { get; set; }
    public string UserID { get; set; }
    public DateTime EntryDate { get; set; }
}
