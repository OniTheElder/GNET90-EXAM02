using OOP_Exam.Answers;
using OOP_Exam.Questions;

namespace OOP_Exam.Exams;

public static class ExamRunner {
    private static void PrintQuestionsAndAnswers(List<int> userAnswers, Exam exam) {
        Console.WriteLine("========Answers========");
        for (int i = 0; i < exam.NumberOfQuestions; ++i) {
            Console.WriteLine($"Question #{i + 1}: {exam.Questions[i]}");
            Console.WriteLine($"Correct Answer: {exam.Questions[i].CorrectAnswer}");
            Console.WriteLine($"Your Answer: {userAnswers[i]}");
            Console.WriteLine($"Verdict: {(userAnswers[i] ==  exam.Questions[i].CorrectAnswer?"Correct!": "False")}");
            Console.WriteLine("---------------------------");
        }
    }

    private static void PrintResults(Exam exam , List<int> userAnswers) {
        int userMarks = 0;
        int totalMarks = 0;
        for (int i = 0; i < exam.NumberOfQuestions; ++i) {
            if (userAnswers[i] == exam.Questions[i].CorrectAnswer) userMarks += exam.Questions[i].Mark;
            totalMarks += exam.Questions[i].Mark;
        }
        double ratio = (double)userMarks/totalMarks;
        Console.WriteLine($"The total marks of the exam is: {userMarks}/{totalMarks} [{ratio:P1}].");
    }

    private static void RunExam(Exam exam, List<int> userAnswers) {
        exam.PrintTitle();
        Console.WriteLine($"The time for the exam is: {exam.TimeOfExam.TotalHours} hr");
        Console.WriteLine("==================================");
        for (int i = 0; i < exam.NumberOfQuestions; ++i) {
            Console.WriteLine($"Question #{i + 1}: {exam.Questions[i]}");
            int choice = exam.Questions[i].GetChoice();
            userAnswers.Add(choice);
            Console.WriteLine("---------------------------");
        }
    }
    public static void RunFinalExam(FinalExam exam) {
        List<int> userAnswers = new();
        RunExam(exam, userAnswers);
        PrintQuestionsAndAnswers(userAnswers, exam);
        PrintResults(exam, userAnswers);
    }

    public static void RunPracticalExam(PracticalExam exam) {
        List<int> userAnswers = new();
        RunExam(exam, userAnswers);
        PrintQuestionsAndAnswers(userAnswers, exam);
    }
    
    
}