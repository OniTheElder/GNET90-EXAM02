using System.Text;

namespace OOP_Exam.Questions.Builders;

public class Director {
    public McqQuestion BuildMcqQuestion(McqQuestionBuilder builder) {
        McqQuestion question = new();
        question.Mark = builder.GetMark();
        question.Body = builder.GetQuestionBody();
        for (int i = 1; i <= 4; ++i) {
            question.Answers.Add(builder.GetOption(i));
        }
        return question;
    }

    public TrueOrFalseQuestion BuildTrueOrFalseQuestion(TrueOrFalseQuestionBuilder builder) {
        TrueOrFalseQuestion question = new();
        question.Mark = builder.GetMark();
        question.Body = builder.GetQuestionBody();
        for (int i = 1; i <= 2; ++i) {
            question.Answers.Add(builder.GetOption(i));
        }
        return question;
    }
}