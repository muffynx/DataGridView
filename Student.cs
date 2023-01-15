using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB3
{
    internal class Student
    {
        public string name;
        public int _birthYear;
        public string _studentID;
        public int _height;
        public double _grade;
        public string _program;
        public Student(string name, int birthYear, string studentID, int height, double gradeValue, string program)
        {
            this.name = name;
            this._birthYear = birthYear;
            this._studentID = studentID;
            this._height = height;
            this._grade = gradeValue;
            this._program = program;
            
        }
        public void AddData(DataGridView grid)
        {
            grid.Rows.Add(name, _studentID, _birthYear, _height, _grade, _program);
        }
      
    }
}
