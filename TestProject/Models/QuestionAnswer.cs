﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class QuestionAnswer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int IdQuestion { get; set; }
        public bool isRight { get; set; }
    }
}