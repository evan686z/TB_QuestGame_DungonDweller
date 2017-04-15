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
        public static void PlaySoundTravel()
        {
            SoundPlayer sound = new SoundPlayer(@"Assets\Sounds\walking.wav");

            sound.PlaySync();
        }
    }
}
