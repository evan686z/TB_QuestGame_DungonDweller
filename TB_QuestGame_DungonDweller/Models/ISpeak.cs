﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    interface ISpeak
    {
        List<string> Messages { get; set; }
        string Speak();
    }
}
