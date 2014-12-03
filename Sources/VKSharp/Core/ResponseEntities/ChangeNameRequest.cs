﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKSharp.Core.Enums;

namespace VKSharp.Core.ResponseEntities {
    public class ChangeNameRequest {
        public int? Id { get; set; }
        public ChangeNameStatus? Status { get; set; }
        public string RepeatDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
