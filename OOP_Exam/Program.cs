using OOP_Exam.Exams;
using OOP_Exam.Subjects;
namespace OOP_Exam;

class Program {
    static void Main(string[] args) {
        Subject Math =  new Subject("Math101", "Mathematics");
        Math.CreatePracticalExam();
        ExamRunner.RunPracticalExam(Math.PracticalExam);
    }
}