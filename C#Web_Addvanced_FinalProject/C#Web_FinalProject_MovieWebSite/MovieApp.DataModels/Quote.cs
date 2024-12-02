using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.DataModels
{
    public class Quote
    {
        public Quote()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string CharacterName { get; set; }
        public string MovieOrShow { get; set; }
        public string CharacterImageUrl { get; set; } = null!;


    }
}
