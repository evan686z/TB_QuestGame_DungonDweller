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
            SoundPlayer sound = new SoundPlayer(@"Assests\Sounds\walking_short.wav");

            sound.PlaySync();
        }

        public void PlaySoundInventory()
        {
            SoundPlayer sound = new SoundPlayer(@"Assests\Sounds\bagRustling.wav");

            sound.PlaySync();
        }

        public void PlaySoundTalkTo()
        {
            SoundPlayer sound = new SoundPlayer(@"Assests\Sounds\peopleTalking_short.wav");

            sound.PlaySync();
        }

        public void PlaySoundExit()
        {
            SoundPlayer sound = new SoundPlayer(@"Assests\Sounds\exitGame.wav");

            sound.PlaySync();
        }

        //
        //Dungeon Room Sounds
        //

    }
}
