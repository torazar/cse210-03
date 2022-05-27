// See https://aka.ms/new-console-template for more information
using System;
using Project_2;
namespace Project_2{

    class start{
        public static void Main(string[] args){
            /// This calls the director class, which starts the game.
            /// the Director class handles everything.

            var Director = new Director();
            Director.Start();
        }
    }
}
