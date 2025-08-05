using System;
using System.Collections.Generic;

namespace student_management_system.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string AdmissionNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string TelephoneNo { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfAdmission { get; set; }

        
        public int GradeId { get; set; }
        public int? UserId { get; set; } 

        
        public Grade Grade { get; set; }
        public User User { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; } = new List<StudentSubject>();

        
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public string GradeName { get; internal set; }
    }

    
    public enum Gender
    {
        Male,
        Female,
       
    }

    public class Grade
    {
        public int Id { get; set; }
        public string GradeName { get; set; }
        public decimal GradeOrder { get; set; }
        public string GradeColor { get; set; }
        public int? GradeGroup { get; set; }
        public DateTime CreatedAt { get; internal set; }
        public string CreatedBy { get; internal set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public UserType UserType { get; set; }
    }

    public enum UserType
    {
        Admin,
        Teacher,
        Student,
        
    }

    public class StudentSubject
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }

        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }

    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string SubjectIndex { get; set; }
        public decimal SubjectOrder { get; set; }
        public string SubjectColor { get; set; }
    }
}