using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp.Models
{
    internal class Post
    {
        public int id {get; set;}
        public int userId { get; set; }
        public string title { get; set; }
        public string body { get; set; }

    }
}
