using System;
namespace Project_2{
public class Director{
public void Start()
        {
            var Player = new PlayerInput();
            Player.SetAnswer();
            var Draw = new DrawShoot();
bool wright = true;
            while (true){
                Player.displayAnswer();
wright = Player.Guess();
            wright = Draw.Draw(wright);
if (wright == false){
    Console.WriteLine("Congratulations! You lost!");
                    break;
                }
wright = Player.Win();
if (wright == false){
                    Console.WriteLine("Congratulations! You won!");
                    break;
                }


            }
        }
    }

}