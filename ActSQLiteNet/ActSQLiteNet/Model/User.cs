﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ActSQLiteNet.Model
{
    class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }

        public string imgURL { get; set; }

    }
}
