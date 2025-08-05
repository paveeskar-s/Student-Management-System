using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Management_System.DAL;
using Student_Management_System.Model;
using student_management_system.Models;
using System.Net;
using System.Windows.Forms;

namespace student_management_system.DAL
{
    internal class StudentDal
    {
        public DataTable GetAllStudents()
        {
            string query = @"SELECT id,admission_no,first_name,last_name,gender,telephone_no,email_id,address,date_of_birth,date_of_admission,grade_id,user_id`,FROM`students ORDER BY last_name, first_name";


            return DbHelper.GetData(query);
        }

        public Student GetStudentById(int Id)
        {
            string query = @"SELECT * FROM students WHERE id = @Id ";

            var parameter = new MySqlParameter("@id", MySqlDbType.Int32)
            {
                Value = Id
            };

            DataTable dt = DbHelper.GetData(query, parameter);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new Models. Student
            {
                Id = Convert.ToInt32(row["id"]),
                AdmissionNo = row["admission_no"].ToString(),
                FirstName = row["first_name"].ToString(),
                LastName = row["last_name"].ToString(),
                Gender = (Gender)Enum.Parse(typeof(Gender), row["gender"].ToString(), true),
                TelephoneNo = row["telephone_no"].ToString(),
                EmailId = row["email_id"].ToString(),
                Address = row["address"].ToString(),
                DateOfBirth = Convert.ToDateTime(row["date_of_birth"]),
                DateOfAdmission = Convert.ToDateTime(row["date_of_admission"]),
                GradeId = Convert.ToInt32(row["grade_id"]),
                GradeName = row["grade_name"].ToString(),
                UserId = row["user_id"] != DBNull.Value ? Convert.ToInt32(row["user_id"]) : (int?)null,
                CreatedAt = Convert.ToDateTime(row["created_at"])
            };
        }

        public int AddStudent(Student student)
        {
            string query = @"INSERT INTO students
                        (admission_no, first_name, last_name, gender,
                         telephone_no, email_id, address, date_of_birth,
                         date_of_admission, grade_id, user_id)
                        VALUES (@admissionNo, @firstName, @lastName, @gender,
                                @telephoneNo, @emailId, @address, @dob,
                                @dateOfAdmission, @gradeId, @userId);
                        SELECT LAST_INSERT_ID();";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@admissionNo", MySqlDbType.VarChar) { Value = student.AdmissionNo },
                new MySqlParameter("@firstName", MySqlDbType.VarChar) { Value = student.FirstName },
                new MySqlParameter("@lastName", MySqlDbType.VarChar) { Value = student.LastName },
                new MySqlParameter("@gender", MySqlDbType.Enum) { Value = student.Gender },
                new MySqlParameter("@telephoneNo", MySqlDbType.VarChar) { Value = student.TelephoneNo ?? (object)DBNull.Value },
                new MySqlParameter("@emailId", MySqlDbType.VarChar) { Value = student.EmailId ?? (object)DBNull.Value },
                new MySqlParameter("@address", MySqlDbType.VarChar) { Value = student.Address ?? (object)DBNull.Value },
                new MySqlParameter("@dob", MySqlDbType.Date) { Value = student.DateOfBirth },
                new MySqlParameter("@dateOfAdmission", MySqlDbType.DateTime) { Value = student.DateOfAdmission },
                new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = student.GradeId },
                new MySqlParameter("@userId", MySqlDbType.Int32) { Value = student.UserId ?? (object)DBNull.Value }
            };

            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }

        public bool UpdateStudent(Student student)
        {
            string query = @"UPDATE students SET
                         first_name = @firstName,
                         last_name = @lastName,
                         gender = @gender,
                         telephone_no = @telephoneNo,
                         email_id = @emailId,
                         address = @address,
                         date_of_birth = @dob,
                         date_of_admission = @dateOfAdmission,
                         grade_id = @gradeId,
                         user_id = @userId,
                         updated_at = CURRENT_TIMESTAMP,
                         updated_by = @updatedBy
                         WHERE id = @studentId AND deleted_at IS NULL";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@studentId", MySqlDbType.Int32) { Value = student.Id },
                new MySqlParameter("@firstName", MySqlDbType.VarChar) { Value = student.FirstName },
                new MySqlParameter("@lastName", MySqlDbType.VarChar) { Value = student.LastName },
                new MySqlParameter("@gender", MySqlDbType.Enum) { Value = student.Gender },
                new MySqlParameter("@telephoneNo", MySqlDbType.VarChar) { Value = student.TelephoneNo ?? (object)DBNull.Value },
                new MySqlParameter("@emailId", MySqlDbType.VarChar) { Value = student.EmailId ?? (object)DBNull.Value },
                new MySqlParameter("@address", MySqlDbType.VarChar) { Value = student.Address ?? (object)DBNull.Value },
                new MySqlParameter("@dob", MySqlDbType.Date) { Value = student.DateOfBirth },
                new MySqlParameter("@dateOfAdmission", MySqlDbType.DateTime) { Value = student.DateOfAdmission },
                new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = student.GradeId },
                new MySqlParameter("@userId", MySqlDbType.Int32) { Value = student.UserId ?? (object)DBNull.Value },
                new MySqlParameter("@updatedBy", MySqlDbType.VarChar) { Value = student.UpdatedBy ?? (object)DBNull.Value }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool SoftDeleteStudent(int Id, string deletedBy)
        {
            string query = @"UPDATE students SET
                         deleted_at = CURRENT_TIMESTAMP,
                         deleted_by = @deletedBy
                         WHERE id = @studentId AND deleted_at IS NULL";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Id", MySqlDbType.Int32) { Value = Id },
                new MySqlParameter("@deletedBy", MySqlDbType.VarChar) { Value = deletedBy ?? (object)DBNull.Value }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetStudentsByGrade(int gradeId)
        {
            string query = @"SELECT s.id, s.admission_no, s.first_name, s.last_name,
                        s.date_of_birth, s.gender, s.email_id as email, 
                        s.telephone_no as phone, s.date_of_admission as enrollment_date
                        FROM students s
                        WHERE s.grade_id = @gradeId AND s.deleted_at IS NULL
                        ORDER BY s.last_name, s.first_name";

            var parameter = new MySqlParameter("@gradeId", MySqlDbType.Int32)
            {
                Value = gradeId
            };

            return DbHelper.GetData(query, parameter);
        }
    }
}