
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Data
{
    [Table("OnlineAccess")]
    public class OnlineAccess
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "OnlineAccess Id is required.")]
        public int OnlineAccessId { get; set; }

        [Required(ErrorMessage = "Customer Id is required.")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "BookId is required.")]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Valid From data is required.")]
        public DateTime ValidFrom{ get; set; }

        [Required(ErrorMessage = "Valid To is required.")]
        public DateTime ValidTo { get; set; }

     }
}
