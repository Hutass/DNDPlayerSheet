using System;
using System.Collections.Generic;
using System.Text;

namespace StoryTeller.Models
{
    public class Roll
    {
        public string Character {  get; set; } 
        public string Result { get; set; }
        public string Name { get; set; }
        public int Advantage { get; set; }
        public string Expression { get; set; }
        public string ExpressionResult { get; set; }
    }
}
