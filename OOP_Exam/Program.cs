using OOP_Exam.Exams;
using OOP_Exam.Subjects;
namespace OOP_Exam;

class Program {
    static void Main() {
        Subject math =  new Subject("Math101", "Mathematics");
        math.CreateExam();
        ExamRunner.RunExam(math.Exam);
    }
}