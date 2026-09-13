using OOP_Exam.Answers;
using OOP_Exam.Questions;

namespace OOP_Exam.Exams;

public abstract class Exam: ICloneable{
    public TimeSpan TimeOfExam { get; set; }
    public List<Question> Questions { get; } = new();
    public int NumberOfQuestions =>  Questions.Count;
    public abstract void PrintTitle();
    public abstract void PrintResults(List<int> userAnswers);
    object ICloneable.Clone() {
        return MemberwiseClone();
    }
}
