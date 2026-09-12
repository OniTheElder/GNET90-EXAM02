namespace OOP_Exam.Exams.Builders;

public class FinalExamBuilder:ExamBuilder {
    public override int GetQuestionType() {
        int type = 1;
        bool accepted = false;
        while (!accepted) {
            Console.Write("Enter the type of the question (1 for MCQ, 2 for True of false): ");
            accepted = int.TryParse(Console.ReadLine(), out type);
            if (!accepted) {
                Console.WriteLine("Invalid choice. please try again.");
            }
        }
        return type;
    }
}