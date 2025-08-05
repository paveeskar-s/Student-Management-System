using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.DAL
{
    internal class GradeDal
    {
        
            public DataTable GetAllGrades()
            {
                string query = @"SELECT id, grade_name, grade_order, grade_color, grade_group
                          FROM grades ORDER BY grade_order";

                return DbHelper.GetData(query);
            }

            public Grade GetGradeById(int gradeId)
            {
                string query = @"SELECT * FROM grades 
                          WHERE id = @gradeId AND deleted_at IS NULL";

                var parameter = new MySqlParameter("@gradeId", MySqlDbType.Int32)
                {
                    Value = gradeId
                };

                DataTable dt = DbHelper.GetData(query, parameter);
                if (dt.Rows.Count == 0) return null;

                DataRow row = dt.Rows[0];
                return new Grade
                {
                    Id = Convert.ToInt32(row["id"]),
                    GradeName = row["grade_name"].ToString(),
                    GradeOrder = Convert.ToDecimal(row["grade_order"]),
                    GradeColor = row["grade_color"].ToString(),
                    GradeGroup = row["grade_group"] != DBNull.Value ? Convert.ToInt32(row["grade_group"]) : (int?)null,
                    CreatedAt = Convert.ToDateTime(row["created_at"]),
                    CreatedBy = row["created_by"]?.ToString()
                };
            }

            public int AddGrade(Grade grade)
            {
                string query = @"INSERT INTO grades
                          (grade_name, grade_order, grade_color, grade_group, created_by)
                          VALUES (@gradeName, @gradeOrder, @gradeColor, @gradeGroup, @createdBy);
                          SELECT LAST_INSERT_ID();";

                var parameters = new MySqlParameter[]
                {
                new MySqlParameter("@gradeName", MySqlDbType.VarChar) { Value = grade.GradeName },
                new MySqlParameter("@gradeOrder", MySqlDbType.Decimal) { Value = grade.GradeOrder },
                new MySqlParameter("@gradeColor", MySqlDbType.VarChar) { Value = grade.GradeColor },
                new MySqlParameter("@gradeGroup", MySqlDbType.Int32) { Value = grade.GradeGroup ?? (object)DBNull.Value },
                new MySqlParameter("@createdBy", MySqlDbType.VarChar) { Value = grade.CreatedBy ?? (object)DBNull.Value }
                };

                return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
            }

            public bool UpdateGrade(Grade grade)
            {
                string query = @"UPDATE grades SET
                          grade_name = @gradeName,
                          grade_order = @gradeOrder,
                          grade_color = @gradeColor,
                          grade_group = @gradeGroup,
                          updated_at = CURRENT_TIMESTAMP,
                          updated_by = @updatedBy
                          WHERE id = @gradeId AND deleted_at IS NULL";

                var parameters = new MySqlParameter[]
                {
                new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = grade.Id },
                new MySqlParameter("@gradeName", MySqlDbType.VarChar) { Value = grade.GradeName },
                new MySqlParameter("@gradeOrder", MySqlDbType.Decimal) { Value = grade.GradeOrder },
                new MySqlParameter("@gradeColor", MySqlDbType.VarChar) { Value = grade.GradeColor },
                new MySqlParameter("@gradeGroup", MySqlDbType.Int32) { Value = grade.GradeGroup ?? (object)DBNull.Value },
                new MySqlParameter("@updatedBy", MySqlDbType.VarChar) { Value = grade.UpdatedBy ?? (object)DBNull.Value }
                };

                return DbHelper.ExecuteNonQuery(query, parameters) > 0;
            }

            public bool SoftDeleteGrade(int gradeId, string deletedBy)
            {
                string query = @"UPDATE grades SET
                          deleted_at = CURRENT_TIMESTAMP,
                          deleted_by = @deletedBy
                          WHERE id = @gradeId AND deleted_at IS NULL";

                var parameters = new MySqlParameter[]
                {
                new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = gradeId },
                new MySqlParameter("@deletedBy", MySqlDbType.VarChar) { Value = deletedBy ?? (object)DBNull.Value }
                };

                return DbHelper.ExecuteNonQuery(query, parameters) > 0;
            }

            public DataTable GetSubjectsForGrade(int gradeId)
            {
                string query = @"SELECT s.id, s.subject_name, s.subject_index, s.subject_order, s.subject_color
                          FROM grade_subject gs
                          JOIN subjects s ON gs.subject_id = s.id
                          WHERE gs.grade_id = @gradeId 
                          AND gs.deleted_at IS NULL
                          AND s.deleted_at IS NULL
                          ORDER BY s.subject_order";

                var parameter = new MySqlParameter("@gradeId", MySqlDbType.Int32)
                {
                    Value = gradeId
                };

                return DbHelper.GetData(query, parameter);
            }
        }
    }
}

