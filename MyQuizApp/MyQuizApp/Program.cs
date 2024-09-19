namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the capital city of Malaysia?", //Question Text
                new string[] {"Penang","Kuala Lumpur","Terrenganu","Seremban"}, //Answers Array
                1 //CorrectAnswerIndex
                ),
                new Question("Which is your favourite milk tea?", //Question Text
                new string[] {"Chagee","Beautea","llaolao","Tealive"}, //Answers Array
                1 //CorrectAnswerIndex
                ),
                new Question("Who is Msia badminton player?", //Question Text
                new string[] {"Axelson","Lin Dan","LCW","Dylon"}, //Answers Array
                2 //CorrectAnswerIndex
                )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadLine();
        }
    }
}
