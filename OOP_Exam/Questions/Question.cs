using OOP_Exam.Answers;

namespace OOP_Exam.Questions;

public abstract class Question:ICloneable{
    public string Header { get; set; }
    public string Body { get; set; }
    public int Mark { get; set; }
    public int CorrectAnswer { get; set; }
    public List<Answer> Answers { get; private set; } = new();
    public abstract int GetChoice();

    public object Clone() {
        Question clonedQuestion = (Question)MemberwiseClone();
        clonedQuestion.Answers = new List<Answer>();
        foreach (Answer answer in Answers) {
            clonedQuestion.Answers.Add((Answer)answer.Clone());
        }
        return  clonedQuestion;
    }
}