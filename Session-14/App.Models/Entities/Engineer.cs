﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    [Serializable]
    public class Engineer : Person
    {
        public Guid? ManagerID { get; set; }
        public Manager Manager { get; set; }
        public decimal SallaryPerMonth { get; set; }
        public StatusEnum Status { get; set; }

        public Engineer()
        {

        }

    }
}
