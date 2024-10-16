using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;

namespace Peelyyy.Models
{
    public class Peely
    {
        public int Id { get; set; }
        public string Peelyquestions { get; set; }

        public string Peelyanswers { get; set; }

        public Peely()
        {
            
        }
    }
}