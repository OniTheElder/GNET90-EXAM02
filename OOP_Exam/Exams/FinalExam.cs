using OOP_Exam.Answers;

namespace OOP_Exam.Exams;

public class FinalExam:Exam {
    public override void PrintTitle() {
        Console.WriteLine("=============Final Exam==========");
    }

    public override void PrintResults(List<int> userAnswers) {
        int userMarks = 0;
        int totalMarks = 0;
        for (int i = 0; i < NumberOfQuestions; ++i) {
            if (userAnswers[i] == Questions[i].CorrectAnswer) userMarks += Questions[i].Mark;
            totalMarks += Questions[i].Mark;
        }
        double ratio = (double)userMarks/totalMarks;
        Console.WriteLine($"The total marks of the exam is: {userMarks}/{totalMarks} [{ratio:P1}].");
    }

    

}