﻿using System;
using System.Collections.Generic;

namespace Blogg.Models
{
    public partial class PostModel
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

    }
}
