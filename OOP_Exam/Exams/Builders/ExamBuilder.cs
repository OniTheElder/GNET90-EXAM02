using System.Collections.Concurrent;

namespace OOP_Exam.Exams.Builders;

public abstract class ExamBuilder {
    public int GetNumberOfQuestions() {
        int numberOfQuestions = 0;
        bool accepted = false;
        while (!accepted) {
            Console.Write("Enter number of questions: ");
            accepted =  int.TryParse(Console.ReadLine(), out numberOfQuestions);
            if (!accepted) {
                Console.WriteLine("Invalid number of questions. please try again.");
            }
        }
        return numberOfQuestions;
    }
    public abstract int GetQuestionType();
}