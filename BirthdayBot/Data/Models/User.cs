﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BirthdayBot.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public List<Nameday> WatchedNamedays { get; set; }
        public List<Birthday> WatchedBirthdays { get; set; }
    }
}