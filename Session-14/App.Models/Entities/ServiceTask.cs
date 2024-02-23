using App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    [Serializable]
    public class ServiceTask : Item
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Hours { get; set; }

        public ServiceTask()
        {
            Code = string.Empty;
            Description = string.Empty;
        }
    }
}
