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
    public static void RunExam(Exam? exam) {
        if (exam is null) return;
        List<int> userAnswers = new();
        exam.PrintTitle();
        Console.WriteLine($"The time for the exam is: {exam.TimeOfExam.TotalHours} hr");
        Console.WriteLine("==================================");
        for (int i = 0; i < exam.NumberOfQuestions; ++i) {
            Console.WriteLine($"Question #{i + 1}: {exam.Questions[i]}");
            int choice = exam.Questions[i].GetChoice();
            userAnswers.Add(choice);
            Console.WriteLine("---------------------------");
        }
        PrintQuestionsAndAnswers(userAnswers, exam);
        exam.PrintResults(userAnswers);
    }
    
    
}