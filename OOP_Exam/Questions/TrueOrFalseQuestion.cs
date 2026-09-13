namespace OOP_Exam.Questions;

public class TrueOrFalseQuestion:Question {
    public override string ToString() {
        return $"""
                {Header}          Marks: {Mark}
                {Body}?
                1- True
                2- False
                """;
    }
    public override int GetChoice() {
        int choice = 0;
        bool accepted = false;
        while (!accepted) {
            Console.Write("Enter your choice [1, 2]: ");
            accepted = int.TryParse(Console.ReadLine(), out choice);
            if (!accepted || choice < 1 || choice > 2) {
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
            Console.Write("Enter the correct answer of the question[1, 2]: ");
            accepted = int.TryParse(Console.ReadLine(), out choice);
            if (!accepted || choice < 1 || choice > 2) {
                Console.WriteLine("Not a valid choice, try again.");
                accepted = false;
            }
        }
        return choice;
    }
}