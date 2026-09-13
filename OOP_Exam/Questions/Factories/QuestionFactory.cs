using OOP_Exam.Answers;

namespace OOP_Exam.Questions.Factories;

public static class QuestionFactory {
    private static string GetQuestionBody() {
        Console.Write("Enter question body: ");
        return Console.ReadLine()!;
    }
    private static string GetAnswerBody(int answerId) {
        Console.Write($"Enter option {answerId}: ");
        return Console.ReadLine()!;
    }
    
    private static int GetMarks() {
        int marks = 0;
        bool accepted = false;
        while (!accepted) {
            Console.Write("Enter Marks [0, 100]: ");
            accepted = int.TryParse(Console.ReadLine(), out marks);
            if (!accepted || marks < 0 || marks > 100) {
                Console.WriteLine("Not a valid mark, try again.");
                accepted = false;
            }
        }
        return marks;
    }
    public static McqQuestion CreateMcqQuestion() {
        McqQuestion question = new ();
        question.Mark =  GetMarks();
        question.Body = GetQuestionBody();
        question.Header = $"MCQ:";
        for (int i = 1; i <= 4; ++i) {
            question.Answers.Add(new Answer(GetAnswerBody(i), i));
        }

        Console.WriteLine("-------------------");
        Console.WriteLine(question);
        question.CorrectAnswer = question.GetChoice();
        Console.WriteLine("-------------------");
        return question;
    }

    public static TrueOrFalseQuestion CreateTrueOfFalseQuestion() {
        TrueOrFalseQuestion question = new ();
        question.Mark =  GetMarks();
        question.Body = GetQuestionBody();
        question.Header = $"True Or False: ";
        for (int i = 1; i <= 2; ++i) {
            question.Answers.Add(new Answer(i == 1?"True":"False", i));
        }
        Console.WriteLine("-------------------");
        Console.WriteLine(question);
        question.CorrectAnswer = question.GetChoice();
        Console.WriteLine("-------------------");
        return question;
    }
}