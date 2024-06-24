﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mongodbTry.data.Bson
{
    [BsonCollection("organization")]
    public class Organization : Document<Organization>, IDocument
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }


}
