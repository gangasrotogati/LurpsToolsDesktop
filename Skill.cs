using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LurpsTools
{
    public class Skill: IComparable<Skill>
    {
        public Character.CharacterSkill SkillName;
        public int SkillLevel;

        public Skill()
        {
            SkillName = Character.CharacterSkill.UnarmedAndGrappling;
            SkillLevel = 0;
        }
        public int CompareTo(Skill other)
        {
            // return other.Skill.CompareTo(this.Skill);
            if (this.SkillLevel < other.SkillLevel)
            {
                return 1;
            }
            else if (this.SkillLevel > other.SkillLevel)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
