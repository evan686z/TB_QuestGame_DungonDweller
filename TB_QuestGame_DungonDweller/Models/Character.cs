using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    /// <summary>
    /// base class for the player and all game characters
    /// </summary>
    public class Character
    {
        #region ENUMERABLES

        public enum RaceType
        {
            None,
            Human,
            Orc,
            Elf,
            Dwarf
        }

        #endregion

        #region FIELDS

        protected string _name;
        protected int _age;
        protected RaceType _race;
        protected int _dungeonLocationID;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public RaceType Race
        {
            get { return _race; }
            set { _race = value; }
        }

        public int DungeonLocationID
        {
            get { return _dungeonLocationID; }
            set { _dungeonLocationID = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, int age, RaceType race, int dungeonLocationID)
        {
            _name = name;
            _age = age;
            _race = race;
            _dungeonLocationID = dungeonLocationID;
        }

        #endregion

        #region METHODS



        #endregion
    }
}
