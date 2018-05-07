using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleJukebox.Models
{
    class Note
    {
        public int Frequency { get; set; }
        public int Duration { get; set; }

        public Note(int frequency, int duration)
        {
            Frequency = frequency;
            Duration = duration;
        }
    }
}
