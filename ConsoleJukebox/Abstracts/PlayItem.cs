using ConsoleJukebox.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleJukebox.Abstracts
{
    public abstract class PlayItem : IPlayable
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public DateTime CheckOutDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public void Play()
        {
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now.AddDays(7);
        }
    }
}
