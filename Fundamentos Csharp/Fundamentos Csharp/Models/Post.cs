﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp.Models
{
    internal class Post : IRequestable
    {
        public int Id {get; set;}
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

    }
}
