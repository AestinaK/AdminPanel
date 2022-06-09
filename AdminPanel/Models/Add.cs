using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.Models
{

    [Table("addproduct")]
    public class Add
    {


        [Key]
public int id { get; set; }
        public string ?name { get; set; }
        public string ?category { get; set; }  
        public string ?scategory { get; set; }
        public string   ?status { get; set; }
        public string ?Description { get; set; }
        public  string ?size { get; set; }   
        public int price { get; set; }
        public int stock { get; set; }

    }
}
