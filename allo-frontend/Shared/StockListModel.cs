namespace allo_frontend;

using System.ComponentModel.DataAnnotations;

public class StockListModel
{
    [Required]
    [StringLength(20, ErrorMessage = "Name is too long.")]
    public string? listItem ;

    [Required]
    public double? token;

}