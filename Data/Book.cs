using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Data
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required(ErrorMessage = "Book Id is required.")]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Book Name is required.")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Page Count is required.")]
        public int Pagecount { get; set; }

        [Required(ErrorMessage = "Author Name is required.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Book Genre is required.")]
        public string BookGenre { get; set; }

     }
}
