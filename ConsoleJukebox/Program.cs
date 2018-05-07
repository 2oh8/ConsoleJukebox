using ConsoleJukebox.Models;
using System;
using System.Collections.Generic;

namespace ConsoleJukebox
{
    class Program
    {
        static void Main(string[] args)
        {
            Jukebox mattsJukebox = new Jukebox("Matt's Jukebox", "Matt's Tavern");
            mattsJukebox.Setup();

            List<Note> tetrisNotes = new List<Note>();
            tetrisNotes.Add(new Note(658, 125));
            tetrisNotes.Add(new Note(1320, 500));
            tetrisNotes.Add(new Note(990, 250));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(1188, 250));
            tetrisNotes.Add(new Note(1320, 125));
            tetrisNotes.Add(new Note(1188, 125));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(990, 250));
            tetrisNotes.Add(new Note(880, 500));
            tetrisNotes.Add(new Note(880, 250));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(1320, 500));
            tetrisNotes.Add(new Note(1188, 250));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(990, 750));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(1188, 500));
            tetrisNotes.Add(new Note(1320, 500));
            tetrisNotes.Add(new Note(1056, 500));
            tetrisNotes.Add(new Note(880, 500));
            tetrisNotes.Add(new Note(880, 500));
            tetrisNotes.Add(new Note(0, 250));
            tetrisNotes.Add(new Note(1188, 500));
            tetrisNotes.Add(new Note(1408, 250));
            tetrisNotes.Add(new Note(1760, 500));
            tetrisNotes.Add(new Note(1584, 250));
            tetrisNotes.Add(new Note(1408, 250));
            tetrisNotes.Add(new Note(1320, 750));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(1320, 500));
            tetrisNotes.Add(new Note(1188, 250));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(990, 500));
            tetrisNotes.Add(new Note(990, 250));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(1188, 500));
            tetrisNotes.Add(new Note(1320, 500));
            tetrisNotes.Add(new Note(1056, 500));
            tetrisNotes.Add(new Note(880, 500));
            tetrisNotes.Add(new Note(880, 500));
            tetrisNotes.Add(new Note(0, 500));
            tetrisNotes.Add(new Note(1320, 500));
            tetrisNotes.Add(new Note(990, 250));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(1188, 250));
            tetrisNotes.Add(new Note(1320, 125));
            tetrisNotes.Add(new Note(1188, 125));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(990, 250));
            tetrisNotes.Add(new Note(880, 500));
            tetrisNotes.Add(new Note(880, 250));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(1320, 500));
            tetrisNotes.Add(new Note(1188, 250));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(990, 750));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(1188, 500));
            tetrisNotes.Add(new Note(1320, 500));
            tetrisNotes.Add(new Note(1056, 500));
            tetrisNotes.Add(new Note(880, 500));
            tetrisNotes.Add(new Note(880, 500));
            tetrisNotes.Add(new Note(0, 250));
            tetrisNotes.Add(new Note(1188, 500));
            tetrisNotes.Add(new Note(1408, 250));
            tetrisNotes.Add(new Note(1760, 500));
            tetrisNotes.Add(new Note(1584, 250));
            tetrisNotes.Add(new Note(1408, 250));
            tetrisNotes.Add(new Note(1320, 750));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(1320, 500));
            tetrisNotes.Add(new Note(1188, 250));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(990, 500));
            tetrisNotes.Add(new Note(990, 250));
            tetrisNotes.Add(new Note(1056, 250));
            tetrisNotes.Add(new Note(1188, 500));
            tetrisNotes.Add(new Note(1320, 500));
            tetrisNotes.Add(new Note(1056, 500));
            tetrisNotes.Add(new Note(880, 500));
            tetrisNotes.Add(new Note(880, 500));
            tetrisNotes.Add(new Note(0, 500));
            tetrisNotes.Add(new Note(660, 1000));
            tetrisNotes.Add(new Note(528, 1000));
            tetrisNotes.Add(new Note(594, 1000));
            tetrisNotes.Add(new Note(495, 1000));
            tetrisNotes.Add(new Note(528, 1000));
            tetrisNotes.Add(new Note(440, 1000));
            tetrisNotes.Add(new Note(419, 1000));
            tetrisNotes.Add(new Note(495, 1000));
            tetrisNotes.Add(new Note(660, 1000));
            tetrisNotes.Add(new Note(528, 1000));
            tetrisNotes.Add(new Note(594, 1000));
            tetrisNotes.Add(new Note(495, 1000));
            tetrisNotes.Add(new Note(528, 500));
            tetrisNotes.Add(new Note(660, 500));
            tetrisNotes.Add(new Note(880, 1000));
            tetrisNotes.Add(new Note(838, 2000));
            tetrisNotes.Add(new Note(660, 1000));
            tetrisNotes.Add(new Note(528, 1000));
            tetrisNotes.Add(new Note(594, 1000));
            tetrisNotes.Add(new Note(495, 1000));
            tetrisNotes.Add(new Note(528, 1000));
            tetrisNotes.Add(new Note(440, 1000));
            tetrisNotes.Add(new Note(419, 1000));
            tetrisNotes.Add(new Note(495, 1000));
            tetrisNotes.Add(new Note(660, 1000));
            tetrisNotes.Add(new Note(528, 1000));
            tetrisNotes.Add(new Note(594, 1000));
            tetrisNotes.Add(new Note(495, 1000));
            tetrisNotes.Add(new Note(528, 500));
            tetrisNotes.Add(new Note(660, 500));
            tetrisNotes.Add(new Note(880, 1000));
            tetrisNotes.Add(new Note(838, 2000));

            Song tetris = new Song("Tetris", tetrisNotes);
            //tetris.Play();
            mattsJukebox.AddItem(tetris);
         
            while (mattsJukebox.Listening)
            {
                mattsJukebox.MainMenuSelection();
            }




        }
    }
}
