﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    public abstract class GameObject
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract int DungeonLocationId { get; set; }
        public abstract int ExperiencePoints { get; set; }
    }
}
