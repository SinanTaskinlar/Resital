﻿using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.Model
{
    public class Region : Entity<Guid>
    {
        public string Name { get; set; }
    }
}