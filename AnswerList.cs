using System;
namespace Project_2
{
    public class AnswerList{
        Random randomGenerator = new Random();
        private List<string> answers = new List<string>(){
            "sword", "shark", "sword", "lapras", "rando",

        };

public string SelectOne(){
    int choose = randomGenerator.Next(answers.Count);
    string slection = answers[choose];
    return(slection);

}

    }
}