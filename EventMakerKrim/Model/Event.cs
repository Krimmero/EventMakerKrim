﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMakerKrim.Model
{
    class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime DateTime { get; set; }

        public Event(int id, string name, string description, string place, DateTime dateTime)
        {
            Id = id;
            Name = name;
            Description = description;
            Place = place;
            DateTime = dateTime;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Description: {Description}, Place: {Place}, DateTime: {DateTime}";
        }
    }

    
}
