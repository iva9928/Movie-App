using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.DataModels
{
   public class Director
    {
        public Director()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string FamousMovies { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string DirectorImageUrl { get; set; } = null!;
    }
}
