using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Assignment
    {
        private int id;

        public Assignment(int id,String assign, String description, short maxpoints,DateTime dueDate, AssignmentTypesEnum types, Section section)
        {
            this.AssignmentGrades = new HashSet<AssignmentGrade>();
            this.Id = id;
            this.Assign = assign;
            this.Description = description;
            this.MaxPoints = maxpoints;
            this.DueDate = dueDate;
            this.Section = section;
            section.Assignments.Add(this);
            this.Type = types;
        
        }

        public AssignmentGrade FindAssignmentGrade(int studentId)
        {
            AssignmentGrade foundGrade = null;
            foreach (AssignmentGrade g in this.AssignmentGrades)
            {
                if (g.Enrollment.Student.Id == studentId)
                {
                    foundGrade = g;
                    break;
                }
            }
            return foundGrade;
        }
    }
}
