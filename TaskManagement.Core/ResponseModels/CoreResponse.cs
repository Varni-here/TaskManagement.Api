using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Core.ResponseModels
{
    public class CoreResponse
    {
        public bool status { get; set; }
        public string? statusMessage { get; set; }
    }
}
