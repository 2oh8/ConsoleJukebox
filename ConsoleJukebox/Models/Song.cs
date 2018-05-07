using ConsoleJukebox.Abstracts;
using ConsoleJukebox.Interfaces;
using System.Collections.Generic;
using System;

namespace ConsoleJukebox.Models
{
    class Song : PlayItem
    {
               
        public Song(string name, List<Note> notes)
        {
            Name = name;
            Notes = notes;
        }
    }
}