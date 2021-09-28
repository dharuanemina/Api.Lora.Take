using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Lora.Take.Model
{
    public class RepositoryRequest
    {
        public string UserName { get; set; }

        public string Language { get; set; }

        public int Quantity { get; set; }
    }
}
