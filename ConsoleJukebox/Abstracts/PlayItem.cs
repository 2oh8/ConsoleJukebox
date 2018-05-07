using ConsoleJukebox.Interfaces;
using ConsoleJukebox.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace ConsoleJukebox.Abstracts
{
    abstract class PlayItem : IPlayable
    {
        public List<Note> Notes { get; set; }
        public string Name { get; set; }

        public void Play()
        {
            foreach (var note in Notes)
            {
                if (note.Frequency == 0)
                {
                    Thread.Sleep(note.Duration);
                } else
                {
                Console.Beep(note.Frequency, note.Duration);
                }
            }
        }
    }
}
