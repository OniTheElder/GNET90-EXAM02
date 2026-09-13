using OOP_Exam.Answers;

namespace OOP_Exam.Exams;

public class PracticalExam:Exam, ICloneable{
    public override void PrintTitle() {
        Console.WriteLine("=============Practical Exam==============");
    }

    public override void PrintResults(List<int> userAnswers) { }
    object ICloneable.Clone() {
        return MemberwiseClone();
    }
}