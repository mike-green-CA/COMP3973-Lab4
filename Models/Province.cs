using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Province {
   [Key]
   [Display (Name="Province Code")]
   [MaxLength(2)]
   public string ProvinceCode { get; set; } 

   [Display (Name="Province Name")]
   [MaxLength(30)]
   public string ProvinceName { get; set; }

   [Display (Name="Cities")]
   [MaxLength(50)]
   public List<City> Cities { get; set; }
}