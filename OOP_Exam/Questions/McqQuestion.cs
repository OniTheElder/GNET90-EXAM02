namespace OOP_Exam.Questions;

public class McqQuestion: Question {
    public override string ToString() {
        return $"""
                {Header}          Marks: {Mark}
                {Body}?
                1- {Answers[0].AnswerText}
                2- {Answers[1].AnswerText}  
                3- {Answers[2].AnswerText}
                4- {Answers[3].AnswerText}
                """;
    }

    public override int GetChoice() {
        int choice = 0;
        bool accepted = false;
        while (!accepted) {
            Console.Write("Enter your choice [1, 4]: ");
            accepted = int.TryParse(Console.ReadLine(), out choice);
            if (!accepted || choice < 1 || choice > 4) {
                Console.WriteLine("Not a valid choice, try again.");
                accepted = false;
            }
        }
        return choice;
    }
    public override int GetCorrectAnswer() {
        int choice = 0;
        bool accepted = false;
        while (!accepted) {
            Console.Write("Enter the correct answer of the question[1, 4]: ");
            accepted = int.TryParse(Console.ReadLine(), out choice);
            if (!accepted || choice < 1 || choice > 4) {
                Console.WriteLine("Not a valid choice, try again.");
                accepted = false;
            }
        }
        return choice;
    }

}