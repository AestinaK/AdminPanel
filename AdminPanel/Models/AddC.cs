using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.Models
{
    [Table("category")]
    public class AddC
    {
        [Key]
        public int cid { get; set; }
        
        public string ?cname { get; set; }
       
    }
}
