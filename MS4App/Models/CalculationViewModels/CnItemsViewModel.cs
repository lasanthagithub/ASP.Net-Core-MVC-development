using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MS4App.Models.CalculationViewModels
{
    public class CnItems
    {
        [Key]
        [Required]
        public string CnItemId { get; set; }

        [Required]
        public string CnItemDescription { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public float AArea { get; set; }
        public float BArea { get; set; }
        public float CArea { get; set; }
        public float DArea { get; set; }
        public bool IsChecked { get; set; }
    }

    // Inheritance does not work here?? Check later
    public class CnItemsSelect1 /*: CnItems*/
    {
        [Key]
        [Required]
        public string CnItemId { get; set; }

        [Required]
        public string CnItemDescription { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public float AArea { get; set; }
        public float BArea { get; set; }
        public float CArea { get; set; }
        public float DArea { get; set; }
        public bool IsChecked { get; set; }
    }

    public class CnItemsSelect2 /*: CnItems*/
    {
        [Key]
        [Required]
        public string CnItemId { get; set; }

        [Required]
        public string CnItemDescription { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public float AArea { get; set; }
        public float BArea { get; set; }
        public float CArea { get; set; }
        public float DArea { get; set; }
        public bool IsChecked { get; set; }
    }

    public class CnItemsSelect3 /*: CnItems*/
    {
        [Key]
        [Required]
        public string CnItemId { get; set; }

        [Required]
        public string CnItemDescription { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public float AArea { get; set; }
        public float BArea { get; set; }
        public float CArea { get; set; }
        public float DArea { get; set; }
        public bool IsChecked { get; set; }
    }


    public class CnItemsCollections
    {
        public List<CnItems> CnItemsList { get; set; }
    }
}
