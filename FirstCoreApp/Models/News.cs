using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Models
{
    public class News
    {
       
        public int Id { get; set; }
        [DisplayName("Title of the new")]
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public string Topic { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Categories Category { get; set; }
    }
}
