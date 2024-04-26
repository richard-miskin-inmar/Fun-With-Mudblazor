using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Mud_Shared.Model
{
    public class Element
    {
        public string Group { get; set; }
        public int Position { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Small { get; set; }
        public float Molar { get; set; }
        public int[] Electrons { get; set; }
    }
}
