using ConsoleJukebox.Abstracts;
using ConsoleJukebox.Interfaces;
using System;

namespace ConsoleJukebox.Models
{
    public class Song : PlayItem
    {
        public Array Notes { get; set; }
        
        public Song(string name, Array notes)
        {
            Name = name;
            Notes = notes;
        }
    }
}