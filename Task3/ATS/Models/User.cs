﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models
{
    internal class User
    {
        public Guid Id { get; private set; }
        public User(Guid id)
        {
            this.Id = id;
        }
    }
}
