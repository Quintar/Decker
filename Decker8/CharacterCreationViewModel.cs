using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Decker8
{
    public class CharacterCreationViewModel : INotifyPropertyChanged
    {
        #region Property changed event
        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        private DeckerCharakter _Charakter;

        public CharacterCreationViewModel()
        {
            _Charakter = new DeckerCharakter();
        }

        #region Properties
        public DeckerCharakter.Priority PriorityMetatype
        {
            get { return _Charakter.PriorityMetatype; }
            set { _Charakter.PriorityMetatype = value; }
        }

        public DeckerCharakter.Race Metarace
        {
            get { return _Charakter.MetaRace; }
            set 
            {
                _Charakter.MetaRace = value;
                NotifyPropertyChanged("PrioAHuman");
                NotifyPropertyChanged("PrioBHuman");
                NotifyPropertyChanged("PrioCHuman");
                NotifyPropertyChanged("PrioDHuman");
                NotifyPropertyChanged("PrioEHuman");
                NotifyPropertyChanged("PrioAElf");
                NotifyPropertyChanged("PrioBElf");
                NotifyPropertyChanged("PrioCElf");
                NotifyPropertyChanged("PrioDElf");
                NotifyPropertyChanged("PrioADwarf");
                NotifyPropertyChanged("PrioBDwarf");
                NotifyPropertyChanged("PrioCDwarf");
                NotifyPropertyChanged("PrioAOrc");
                NotifyPropertyChanged("PrioBOrc");
                NotifyPropertyChanged("PrioCOrc");
                NotifyPropertyChanged("PrioATroll");
                NotifyPropertyChanged("PrioBTroll");
            }
        }

        public DeckerCharakter.Priority PriorityAttributes
        {
            get { return _Charakter.PriorityAttribute; }
            set
            {
                _Charakter.PriorityAttribute = value;
                NotifyPropertyChanged("PrioAAttribute");
                NotifyPropertyChanged("PrioBAttribute");
                NotifyPropertyChanged("PrioCAttribute");
                NotifyPropertyChanged("PrioDAttribute");
                NotifyPropertyChanged("PrioEAttribute");
            }
        }

        public DeckerCharakter.Priority PriorityResonance
        {
            get { return _Charakter.PriorityResonance; }
            set
            {
                _Charakter.PriorityResonance = value;
                NotifyPropertyChanged("PrioAResonance");
                NotifyPropertyChanged("PrioBResonance");
                NotifyPropertyChanged("PrioCResonance");
                NotifyPropertyChanged("PrioDResonance");
                NotifyPropertyChanged("PrioEResonance");
            }
        }

        public DeckerCharakter.Priority PrioritySkills
        {
            get { return _Charakter.PrioritySkill; }
            set
            {
                _Charakter.PrioritySkill = value;
                NotifyPropertyChanged("PrioASkill");
                NotifyPropertyChanged("PrioBSkill");
                NotifyPropertyChanged("PrioCSkill");
                NotifyPropertyChanged("PrioDSkill");
                NotifyPropertyChanged("PrioESkill");
            }
        }

        public DeckerCharakter.Priority PriorityRessources
        {
            get { return _Charakter.PriorityRessource; }
            set
            {
                _Charakter.PriorityRessource = value;
                NotifyPropertyChanged("PrioARessource");
                NotifyPropertyChanged("PrioBRessource");
                NotifyPropertyChanged("PrioCRessource");
                NotifyPropertyChanged("PrioDRessource");
                NotifyPropertyChanged("PrioERessource");
            }
        }

        #region Priority Metatypes
        public string PrioAHuman
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Human && _Charakter.PriorityMetatype == DeckerCharakter.Priority.A) return "orange";
                return "";
            }
        }
        public string PrioBHuman
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Human && _Charakter.PriorityMetatype == DeckerCharakter.Priority.B) return "orange";
                return "";
            }
        }
        public string PrioCHuman
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Human && _Charakter.PriorityMetatype == DeckerCharakter.Priority.C) return "orange";
                return "";
            }
        }
        public string PrioDHuman
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Human && _Charakter.PriorityMetatype == DeckerCharakter.Priority.D) return "orange";
                return "";
            }
        }
        public string PrioEHuman
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Human && _Charakter.PriorityMetatype == DeckerCharakter.Priority.E) return "orange";
                return "";
            }
        }

        public string PrioAElf
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Elf && _Charakter.PriorityMetatype == DeckerCharakter.Priority.A) return "orange";
                return "";
            }
        }
        public string PrioBElf
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Elf && _Charakter.PriorityMetatype == DeckerCharakter.Priority.B) return "orange";
                return "";
            }
        }
        public string PrioCElf
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Elf && _Charakter.PriorityMetatype == DeckerCharakter.Priority.C) return "orange";
                return "";
            }
        }
        public string PrioDElf
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Elf && _Charakter.PriorityMetatype == DeckerCharakter.Priority.D) return "orange";
                return "";
            }
        }

        public string PrioAOrc
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Orc && _Charakter.PriorityMetatype == DeckerCharakter.Priority.A) return "orange";
                return "";
            }
        }
        public string PrioBOrc
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Orc && _Charakter.PriorityMetatype == DeckerCharakter.Priority.B) return "orange";
                return "";
            }
        }
        public string PrioCOrc
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Orc && _Charakter.PriorityMetatype == DeckerCharakter.Priority.C) return "orange";
                return "";
            }
        }
        public string PrioADwarf
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Dwarf && _Charakter.PriorityMetatype == DeckerCharakter.Priority.A) return "orange";
                return "";
            }
        }
        public string PrioBDwarf
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Dwarf && _Charakter.PriorityMetatype == DeckerCharakter.Priority.B) return "orange";
                return "";
            }
        }
        public string PrioCDwarf
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Dwarf && _Charakter.PriorityMetatype == DeckerCharakter.Priority.C) return "orange";
                return "";
            }
        }
        public string PrioATroll
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Troll && _Charakter.PriorityMetatype == DeckerCharakter.Priority.A) return "orange";
                return "";
            }
        }
        public string PrioBTroll
        {
            get
            {
                if (_Charakter.MetaRace == DeckerCharakter.Race.Troll && _Charakter.PriorityMetatype == DeckerCharakter.Priority.B) return "orange";
                return "";
            }
        }
        #endregion

        #region Priority Attributes
        public string PrioAAttribute
        {
            get
            {
                if (_Charakter.PriorityAttribute == DeckerCharakter.Priority.A) return "orange";
                return "";
            }
        }
        public string PrioBAttribute
        {
            get
            {
                if (_Charakter.PriorityAttribute == DeckerCharakter.Priority.B) return "orange";
                return "";
            }
        }
        public string PrioCAttribute
        {
            get
            {
                if (_Charakter.PriorityAttribute == DeckerCharakter.Priority.C) return "orange";
                return "";
            }
        }
        public string PrioDAttribute
        {
            get
            {
                if (_Charakter.PriorityAttribute == DeckerCharakter.Priority.D) return "orange";
                return "";
            }
        }
        public string PrioEAttribute
        {
            get
            {
                if (_Charakter.PriorityAttribute == DeckerCharakter.Priority.E) return "orange";
                return "";
            }
        }

        #endregion

        #region Priority Resonance
        public string PrioAResonance
        {
            get
            {
                if (_Charakter.PriorityResonance == DeckerCharakter.Priority.A) return "orange";
                return "";
            }
        }
        public string PrioBResonance
        {
            get
            {
                if (_Charakter.PriorityResonance == DeckerCharakter.Priority.B) return "orange";
                return "";
            }
        }
        public string PrioCResonance
        {
            get
            {
                if (_Charakter.PriorityResonance == DeckerCharakter.Priority.C) return "orange";
                return "";
            }
        }
        public string PrioDResonance
        {
            get
            {
                if (_Charakter.PriorityResonance == DeckerCharakter.Priority.D) return "orange";
                return "";
            }
        }
        public string PrioEResonance
        {
            get
            {
                if (_Charakter.PriorityResonance == DeckerCharakter.Priority.E) return "orange";
                return "";
            }
        }

        #endregion

        #region Priority Skills
        public string PrioASkill
        {
            get
            {
                if (_Charakter.PrioritySkill== DeckerCharakter.Priority.A) return "orange";
                return "";
            }
        }
        public string PrioBSkill
        {
            get
            {
                if (_Charakter.PrioritySkill == DeckerCharakter.Priority.B) return "orange";
                return "";
            }
        }
        public string PrioCSkill
        {
            get
            {
                if (_Charakter.PrioritySkill == DeckerCharakter.Priority.C) return "orange";
                return "";
            }
        }
        public string PrioDSkill
        {
            get
            {
                if (_Charakter.PrioritySkill == DeckerCharakter.Priority.D) return "orange";
                return "";
            }
        }
        public string PrioESkill
        {
            get
            {
                if (_Charakter.PrioritySkill == DeckerCharakter.Priority.E) return "orange";
                return "";
            }
        }

        #endregion

        #region Priority Ressource
        public string PrioARessource
        {
            get
            {
                if (_Charakter.PriorityRessource == DeckerCharakter.Priority.A) return "orange";
                return "";
            }
        }
        public string PrioBRessource
        {
            get
            {
                if (_Charakter.PriorityRessource == DeckerCharakter.Priority.B) return "orange";
                return "";
            }
        }
        public string PrioCRessource
        {
            get
            {
                if (_Charakter.PriorityRessource == DeckerCharakter.Priority.C) return "orange";
                return "";
            }
        }
        public string PrioDRessource
        {
            get
            {
                if (_Charakter.PriorityRessource == DeckerCharakter.Priority.D) return "orange";
                return "";
            }
        }
        public string PrioERessource
        {
            get
            {
                if (_Charakter.PriorityRessource == DeckerCharakter.Priority.E) return "orange";
                return "";
            }
        }

        #endregion
        #endregion

        #region Commands
        public ICommand UpdatePriorityMetatype { get { return new RelayCommand(UpdatePriorityMetatypeExecute, CanUpdatePriorityMetatypeExecute); } }
        void UpdatePriorityMetatypeExecute(object parameter)
        {
            string param = (string)parameter;
            string[] par = param.Split('-');

            DeckerCharakter.Priority prio = (DeckerCharakter.Priority)Enum.Parse(typeof(DeckerCharakter.Priority), par[0]);
            DeckerCharakter.Race race = (DeckerCharakter.Race)Enum.Parse(typeof(DeckerCharakter.Race), par[1]);
            PriorityMetatype = prio;
            Metarace = race;
            NotifyPropertyChanged("PriorityMetatype");
            NotifyPropertyChanged("Metarace");
        }
        bool CanUpdatePriorityMetatypeExecute()
        {
            return true;
        }

        public ICommand UpdatePriorityAttribute { get { return new RelayCommand(UpdatePriorityAttributeExecute, CanUpdatePriorityAttributeExecute); } }
        void UpdatePriorityAttributeExecute(object parameter)
        {
            string param = (string)parameter;

            DeckerCharakter.Priority prio = (DeckerCharakter.Priority)Enum.Parse(typeof(DeckerCharakter.Priority), param);
            PriorityAttributes = prio;
            NotifyPropertyChanged("PriorityAttributes");
        }
        bool CanUpdatePriorityAttributeExecute()
        {
            return true;
        }


        public ICommand UpdatePriorityResonance { get { return new RelayCommand(UpdatePriorityResonanceExecute, CanUpdatePriorityResonanceExecute); } }
        void UpdatePriorityResonanceExecute(object parameter)
        {
            string param = (string)parameter;

            DeckerCharakter.Priority prio = (DeckerCharakter.Priority)Enum.Parse(typeof(DeckerCharakter.Priority), param);
            PriorityResonance = prio;
            NotifyPropertyChanged("PriorityResonance");
        }
        bool CanUpdatePriorityResonanceExecute()
        {
            return true;
        }

        public ICommand UpdatePrioritySkill { get { return new RelayCommand(UpdatePrioritySkillExecute, CanUpdatePrioritySkillExecute); } }
        void UpdatePrioritySkillExecute(object parameter)
        {
            string param = (string)parameter;

            DeckerCharakter.Priority prio = (DeckerCharakter.Priority)Enum.Parse(typeof(DeckerCharakter.Priority), param);
            PrioritySkills = prio;
            NotifyPropertyChanged("PrioritySkills");
        }
        bool CanUpdatePrioritySkillExecute()
        {
            return true;
        }

        public ICommand UpdatePriorityRessource { get { return new RelayCommand(UpdatePriorityRessourceExecute, UpdatePriorityRessourceExecute); } }
        void UpdatePriorityRessourceExecute(object parameter)
        {
            string param = (string)parameter;

            DeckerCharakter.Priority prio = (DeckerCharakter.Priority)Enum.Parse(typeof(DeckerCharakter.Priority), param);
            PriorityRessources = prio;
            NotifyPropertyChanged("PriorityRessources");
        }
        bool UpdatePriorityRessourceExecute()
        {
            return true;
        }
        #endregion

    }
}
