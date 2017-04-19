using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    public class Sound
    {
        //change to copy always or copy if new in properties of sound file
        public void PlaySoundTravel()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\Evan\Desktop\School\CIT195 .NET App and Game Programming\TB_QuestGame_DungonDweller\TB_QuestGame_DungonDweller\Assests\Sounds\walking.wav");

            sound.PlaySync();
        }

        public void PlaySoundInventory()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\Evan\Desktop\School\CIT195 .NET App and Game Programming\TB_QuestGame_DungonDweller\TB_QuestGame_DungonDweller\Assests\Sounds\bagRustling.wav");

            sound.PlaySync();
        }

        public void PlaySoundTalkTo()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\Evan\Desktop\School\CIT195 .NET App and Game Programming\TB_QuestGame_DungonDweller\TB_QuestGame_DungonDweller\Assests\Sounds\peopleTalking.wav");

            sound.PlaySync();
        }
        
        //
        //Dungeon Room Sounds
        //

    }
}
