using OOP_Exam.Questions;

namespace OOP_Exam.Exams;

public abstract class Exam {
    public TimeSpan TimeOfExam { get; set; }
    public List<Question> Questions { get; } = new();
    public int NumberOfQuestions =>  Questions.Count;
    public abstract void PrintTitle();
}
