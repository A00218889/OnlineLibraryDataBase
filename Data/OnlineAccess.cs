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
        public string AccessID { get; set; }

        [Required(ErrorMessage = "Customer Id is required.")]
        public string CustomerId { get; set; }

        [Required(ErrorMessage = "BookId is required.")]
        public string BookId { get; set; }

        [Required(ErrorMessage = "Valid From data is required.")]
        public string ValidFrom{ get; set; }

        [Required(ErrorMessage = "Valid To is required.")]
        public string ValidTo{ get; set; }

     }
}
