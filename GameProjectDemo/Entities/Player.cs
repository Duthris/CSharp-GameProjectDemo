﻿using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entities
{
    public class Player:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
        public double Balance { get; set; }
        public List<string> Games { get; set; }

    }
}
