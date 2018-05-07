using ConsoleJukebox.Abstracts;
using ConsoleJukebox.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleJukebox.Models
{
    public class Jukebox
    {

        public string Name { get; private set; }
        string Location { get; set; }

        public bool Listening { get; private set; }
        public bool InMenu { get; private set; }
        private List<Song> Songs = new List<Song>();
        private List<IJukeboxItem> Items = new List<IJukeboxItem>();
        private List<IPlayable> ItemsForPlay = new List<IPlayable>();
        private Menu MainMenu { get; set; }
        private Menu SongMenu { get; set; }

        public Jukebox(string name, string address)
        {
            Name = name;
            Location = address;
            Listening = true;
            InMenu = false;
            MainMenu = BuildMainMenu();
        }

        Menu BuildMainMenu()
        {
            return new Menu(
                "Main Menu",
                new List<MenuOption>
                {
                    new MenuOption(SongSelection, "Visit the Song Menu"),
                    new MenuOption(LeaveJukebox, "Exit the Jukebox")
                });
        }

        public void Setup()
        {
            BuildSongMenu();
        }

        void BuildSongMenu()
        {
            SongMenu = new Menu(
               "Song Menu",
               new List<MenuOption>
               {
                    new MenuOption(PrintSongs, "View all the Songs"),
                    new MenuOption(LeaveMenu, "Leave the Menu")
               });
        }


        public void MainMenuSelection()
        {
            Action action = MainMenu.SelectOption();
            if (action != null)
            {
                action.Invoke();
            }
        }

        private void SongSelection()
        {
            Console.Clear();
            InMenu = true;
            while (InMenu)
            {
                Action action = SongMenu.SelectOption();
                if (action != null)
                {
                    action.Invoke();
                }
            }
        }

        private void LeaveJukebox()
        {
            Console.WriteLine("Thanks for stopping in!");
            Listening = false;
        }

        private void LeaveMenu()
        {
            Console.WriteLine("You've left the Menu!");
            InMenu = false;
        }

        private void PrintSongs()
        {
            Console.Clear();
            int count = 1;
            foreach (Song song in Songs)
            {
                Console.WriteLine($"{count++} {song.Name}");
            }
            Console.ReadLine();
        }


        internal void AddItem(IJukeboxItem item)
        {
            Items.Add(item);
        }

        internal void AddItem(Song song)
        {
            Songs.Add(song);
            AddItem((PlayItem)song);
        }

        private void AddItem(PlayItem item)
        {
            ItemsForPlay.Add(item);
        }

    }
}
