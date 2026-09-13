using OOP_Exam.Exams;
using OOP_Exam.Exams.Factories;

namespace OOP_Exam.Subjects;

public class Subject {
    public string SubjectId { get; set; }
    public string SubjectName { get; set; }

    public Subject(string subjectId, string subjectName) {
        SubjectId = subjectId;
        SubjectName = subjectName;
    }
    public PracticalExam PracticalExam { get; set; }
    public FinalExam FinalExam { get; set; }
    public void CreateFinalExam() {
        FinalExam = ExamFactory.CreateFinalExam();
    }
    public void CreatePracticalExam() {
        PracticalExam = ExamFactory.CreatePracticalExam();
    }
}