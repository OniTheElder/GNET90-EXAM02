using OOP_Exam.Questions.Factories;
namespace OOP_Exam.Exams.Factories;

public static class ExamFactory {
    private static TimeSpan GetTimeOfExam() {
        int minutes = 0;
        bool accepted = false;
        while (!accepted) {
            Console.Write("Enter time in minutes: ");
            accepted = int.TryParse(Console.ReadLine(), out minutes);
            if (!accepted || minutes < 1 ) {
                Console.WriteLine("Not a valid time, try again.");
                accepted = false;
            }
        }
        return new TimeSpan(0, minutes, 0);
    }

    private static int GetNumberOfQuestions() {
        int numberOfQuestions = 0;
        bool accepted = false;
        while (!accepted) {
            Console.Write("Enter number of questions: ");
            accepted = int.TryParse(Console.ReadLine(), out numberOfQuestions);
            if (!accepted || numberOfQuestions < 1 ) {
                Console.WriteLine("Not a valid number, try again.");
                accepted = false;
            }
        }
        return numberOfQuestions;
    }

    private static int GetTypeOfQuestion() {
        int type = 1;
        bool accepted = false;
        while (!accepted) {
            Console.Write("Enter type of question (1 for MCQ & 2 for True or False) : ");
            accepted = int.TryParse(Console.ReadLine(), out type);
            if (!accepted || type < 1 || type > 2 ) {
                Console.WriteLine("Not a valid type, try again.");
                accepted = false;
            }
        }
        return type;
    }
    public static FinalExam CreateFinalExam() {
        FinalExam exam = new FinalExam();
        exam.TimeOfExam = GetTimeOfExam();
        int numberOfQuestions = GetNumberOfQuestions();
        for (int i = 0; i < numberOfQuestions; i++) {
            if (GetTypeOfQuestion() == 1) {
                exam.Questions.Add(QuestionFactory.CreateMcqQuestion());
            }
            else {
                exam.Questions.Add(QuestionFactory.CreateTrueOfFalseQuestion());
            }
        }
        return exam;
    }
    public static PracticalExam CreatePracticalExam() {
        PracticalExam exam = new PracticalExam();
        exam.TimeOfExam = GetTimeOfExam();
        int numberOfQuestions = GetNumberOfQuestions();
        for (int i = 0; i < numberOfQuestions; i++) {
            exam.Questions.Add(QuestionFactory.CreateTrueOfFalseQuestion());
        }
        return exam;
    }
}