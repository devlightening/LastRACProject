﻿using Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concretes.Models
{
    public class Color : IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
