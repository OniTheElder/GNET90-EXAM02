using OOP_Exam.Questions;

namespace OOP_Exam.Exams;

public abstract class Exam: ICloneable{
    public TimeSpan TimeOfExam { get; set; }
    public List<Question> Questions { get; private set; } = new();
    public int NumberOfQuestions =>  Questions.Count;
    public abstract void PrintTitle();
    public abstract void PrintResults(List<int> userAnswers);
    object ICloneable.Clone() {
        Exam clonedExam = (Exam)MemberwiseClone();
        clonedExam.Questions = new List<Question>();
        foreach (Question question in Questions) {
            clonedExam.Questions.Add((Question)question.Clone());
        }
        return clonedExam;
    }
}
