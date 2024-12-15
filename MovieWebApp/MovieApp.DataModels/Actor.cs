using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.DataModels
{
    public class Actor
    {
        public Actor()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ActorImageUrl { get; set; } = null!;
    }
}
