using ConsoleJukebox.Models;
using System;

namespace ConsoleJukebox
{
    class Program
    {
        static void Main(string[] args)
        {
            Jukebox mattsJukebox = new Jukebox("matts Jukebox", "123 fak str");
            mattsJukebox.Setup();

            Song mobyDick = new Song("Moby Dick", "das90fudas", "Herman Wells");
            
            mattsJukebox.AddItem(mobyDick);
         
            while (mattsJukebox.Listening)
            {
                mattsJukebox.MainMenuSelection();
            }




        }
    }
}
