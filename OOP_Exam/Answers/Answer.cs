namespace OOP_Exam.Answers;

public class Answer {
    public int AnswerId { get; init; }
    public string AnswerText { get; init; }

    public Answer(string answerText, int answerId) {
        AnswerText = answerText;
        AnswerId =  answerId; 
    }
}
