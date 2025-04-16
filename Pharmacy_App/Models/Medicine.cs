using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_App.Models
{
    public  class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public DateTime Production_Date { get; set; }
        public DateTime Expiration_Date { get; set;}

        [ForeignKey("Category")]
        public int CatId { get; set; }

        public virtual Category Category { get; set; }
    }
}
