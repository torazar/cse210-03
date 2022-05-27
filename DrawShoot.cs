using System;
namespace Project_2{

public class DrawShoot{
private int health = 5;


public bool Draw(bool right){
if (right == false){
    health = health-1;
}
if(health >4){
                Console.WriteLine("   ___");
            }
if(health >3){
                Console.WriteLine("  /___\\ ");
            }
if(health >2){
                Console.WriteLine("  \\   /");
            }
if(health >1){
                Console.WriteLine("   \\ /");
            }
if(health >0){
                Console.WriteLine("    0");
                Console.WriteLine("   /|\\");
                Console.WriteLine("   / \\");
                 Console.WriteLine("");
                Console.WriteLine("  ^^^^^^^");
                // Console.WriteLine("");
            }



if (health>0){
    return true;
}
else{
return false;
}
}



}




}