using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Form1 : Form
    {
        //array <-> List
        //List<Student> _students = new List<Student>();
        
        public Form1()
        {
            InitializeComponent();
        }
        int clickCount = 0;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
         
            String grade = this.textBoxGrade.Text;
            double gradeValue = double.Parse(grade);
          
            Student std = new Student(textBoxName.Text, int.Parse(textBoxBirthYear.Text), textBoxStudentID.Text, int.Parse(textBoxHeight.Text), gradeValue, textBoxProgram.Text)
            { };
            std.AddData(dataGridView1);
            string input = "3.14";
            double result = double.Parse(input);
            //clear textbox
            this.textBoxName.Text = "";
            this.textBoxBirthYear.Text = "";
            this.textBoxGrade.Text = "";
            this.textBoxHeight.Text = "";
            this.textBoxProgram.Text = "";
            this.textBoxStudentID.Text = "";
            List<double> numbers = new List<double>();
            numbers.Add(gradeValue);


           // double minGrade = double.MaxValue;
            //double maxGrade = double.MinValue;

          


            //double highest = double.MinValue;
           // double lowest = double.MaxValue;

            //foreach (double i in numbers)
            //{
            ///    highest = Math.Max(highest, i);
            //    lowest = Math.Min(lowest, i);
            //    double minValue = numbers.Min();
            //    double maxValue = numbers.Max();
            //}

            double highest = numbers.Min();
            double lowest = numbers.Max();

            double[] columnData = (from DataGridViewRow row in dataGridView1.Rows 
                                where row.Cells[4].FormattedValue .ToString() != string.Empty
                                select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();
            max.Text = columnData.Max().ToString();
            min1.Text = columnData.Min().ToString();
            //min1.Text = lowest.ToString();

            //this.dataGridView1.DataSource = source;
            clickCount++;
            labelClickCount.Text = clickCount.ToString();
        }
    }
}