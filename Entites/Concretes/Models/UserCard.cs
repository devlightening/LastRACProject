﻿using Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concretes.Models
{
    public class UserCard : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CardId { get; set; }
    }
}
