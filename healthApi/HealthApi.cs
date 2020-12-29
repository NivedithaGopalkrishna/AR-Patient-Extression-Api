using System;
using System.Collections.Generic;

namespace healthApi
{
   //class for PainPoint
        public class Painpoint
        {
            public string name { get; set; }
            public string description { get; set; }
            public IList<string> causes { get; set; }
            public IList<string> home_remedies { get; set; }

    }
  
}

