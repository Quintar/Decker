using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decker8
{
    public class DeckerCharakter
    {
        public enum Race
        {
            Human,
            Elf,
            Dwarf,
            Orc,
            Troll
        };

        public enum Attribute
        {
            Wisdom,
            Logic,
            Intelligence,
            Charisma,
            Essence,
            Resonance
        };

        public enum Skill
        {
            #region Skills
            Arcane,
            Computer,
            Elecwarfare,
            Hacking,
            Hardware,
            Cyberbattle,
            Software,
            #endregion
            #region magic skills
            Antimagic,
            Bind,
            Artificer,
            Summoning,
            Spellcraft,
            Banishing,
            #endregion
            #region Resonance skills
            Decompile,
            Compile,
            Register
            #endregion
        };

        public enum Priority { X, A, B, C, D, E };


        #region Members
            Race _metarace;
            Priority _pmetatype;
            Priority _pattribute;
            Priority _presonance;
            Priority _pskill;
            Priority _pressource;
            Dictionary<Attribute, int> _attributes { set; get; }
            Dictionary<Skill, int> _skills { set; get; }

        #endregion

        #region Properties
        public Race MetaRace
        {
            get { return _metarace; }
            set { _metarace = value; }
        }

        public Priority PriorityMetatype
        {
            get { return _pmetatype; }
            set { _pmetatype = value; }
        }

        public Priority PriorityAttribute
        {
            get { return _pattribute; }
            set { _pattribute = value; }
        }

        public Priority PriorityResonance
        {
            get { return _presonance; }
            set { _presonance = value; }
        }

        public Priority PrioritySkill
        {
            get { return _pskill; }
            set
            { _pskill = value; }
        }

        public Priority PriorityRessource
        {
            get { return _pressource; }
            set { _pressource = value; }
        }


        public void SetAttribute(Attribute setAttribute, int setValue)
        {
            if (setValue > 11) throw new ArgumentException("Attribute may never exceed 11");
            if (setValue < 1) throw new ArgumentException("Attribute may never be below 1");

            _attributes[setAttribute] = setValue;
        }

        public int GetAttribute(Attribute getAttribute)
        {
            return _attributes[getAttribute];
        }

        public void SetSkill(Skill setSkill, int setValue)
        {
            if (setValue > 13) throw new ArgumentException("Skill may never exceed 13");
            if (setValue < -1) throw new ArgumentException("Skill may never be below -1");

            _skills[setSkill] = setValue;
        }

        public int GetSkill(Skill getSkill)
        {
            return _skills[getSkill];
        }
        #endregion
    }
}
