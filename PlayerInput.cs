using System;
namespace Project_2{
    public class PlayerInput{



        private string rightAnswer = "yes";


        private List<string> Answers = new List<string>();

        private int Winns = 0;



        private string[] Answer = new string[6];





        public void SetAnswer(){
    var AnswerList = new AnswerList();
            rightAnswer = AnswerList.SelectOne();
            for (int i = 0; i < rightAnswer.Length; i++)
            {
Answers.Add("_");
            }
            // Console.WriteLine(rightAnswer);
            // Answer = rightAnswer.Split();
            // Console.WriteLine(rightAnswer.Split());
            // Console.WriteLine(Answers[1]);
        }





public void displayAnswer(){
            for (int i =0; i < rightAnswer.Length; i++){
                
Console.Write($"{Answers[i]} ");
            }
            Console.WriteLine();
        }




        public bool Guess(){
Console.Write("What letter is your guess? ");
string currentGuess = Console.ReadLine();
string[] changed = currentGuess.Split();
foreach (string letter in changed)
            {
// Console.WriteLine(Answer);
                if (rightAnswer.Contains(letter))
                {
                    // for (int i = 1; i < rightAnswer.Length; i++)
                    // {
                        // Console.WriteLine("1");
                    // if(letter == Answer[i]){
                    int j = rightAnswer.IndexOf(letter);
                    Answers[j] = letter;
                        // }

                    // }

                    displayAnswer();

                    return true;
                }


                else
                {
                    displayAnswer();

                    return false;
                }
            }
return false;
        }
        public bool Win()
        {
Winns = 0;

            for (int i = 0; i < 5; i++)
            {
                // Console.WriteLine(Answer.Length);
                // Console.Write("1, ");
                if (Answers[i] != "_")
                {
                    Winns++;
                }
            }

            if (Winns >4){
                    return false;
                }
                else{
                    return true;
                }
            
        }
    }
}