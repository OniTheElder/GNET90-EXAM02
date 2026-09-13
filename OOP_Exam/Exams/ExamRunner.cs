namespace OOP_Exam.Exams;

public static class ExamRunner {
    private static void PrintQuestionsAndAnswers(List<int> userAnswers, Exam exam) {
        Console.WriteLine("========Answers========");
        for (int i = 0; i < exam.NumberOfQuestions; ++i) {
            Console.WriteLine($"Question #{i + 1}: {exam.Questions[i]}");
            Console.WriteLine($"Correct Answer: {exam.Questions[i].CorrectAnswer}- {exam.Questions[i].Answers[exam.Questions[i].CorrectAnswer-1].AnswerText}");
            Console.WriteLine($"Your Answer: {userAnswers[i]}- {exam.Questions[i].Answers[userAnswers[i]-1].AnswerText}");
            Console.WriteLine($"Verdict: {(userAnswers[i] ==  exam.Questions[i].CorrectAnswer?"Correct!": "Incorrect:(")}");
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