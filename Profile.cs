using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LurpsTools
{
    public class Profile
    {
        public string ProfileName;
        public List<Character> CharacterList;

        public Profile()
        {
            ProfileName = "";
            CharacterList = new List<Character>();
        }
    }
}
