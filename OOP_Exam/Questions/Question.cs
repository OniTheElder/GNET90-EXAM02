using System.Text;
using OOP_Exam.Answers;

namespace OOP_Exam.Questions;

public abstract class Question {
    public string Header { get; set; }
    public string Body { get; set; }
    public int Mark { get; set; }
    public int CorrectAnswer { get; set; }
    public List<Answer> Answers { get; } = new();
    public abstract int GetChoice();
}