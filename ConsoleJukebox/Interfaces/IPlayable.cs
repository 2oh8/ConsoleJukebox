using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleJukebox.Interfaces
{
    public interface IPlayable : IJukeboxItem
    {
              void Play();
        //JukeboxMember IssuedTo { get; set; }
    }
}
