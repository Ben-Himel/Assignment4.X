using System.IO;


namespace Assignment4._3
{
    public partial class Form1 : Form
    {
        Student stu = new Student();

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void buttonInputStu_Click(object sender, EventArgs e)
        {
            
            stu.studentID = Convert.ToInt32(textBoxStudentID.Text);
            stu.firstName = textBoxFirstName.Text;
            stu.lastName = textBoxLastName.Text;
            stu.address = textBoxAddress.Text;
            stu.monthofadmition = textBoxMonthAdmin.Text;
            stu.grade = textBoxGrade.Text;

            dataGridView1.Rows.Add(stu.studentID, stu.firstName, stu.lastName, stu.address, stu.monthofadmition, stu.grade);           

        }

        struct Student
        {
            public int studentID;
            public string firstName, lastName, address;
            public string monthofadmition;
            public string grade;

            public Student(int id, string first, string last, string add, string admin, string grade)
            {
                this.studentID = id;
                this.firstName = first;
                this.lastName = last;
                this.address = add;
                this.monthofadmition = admin;
                this.grade = grade;
            }

            enum months { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
            enum grades { A, B, C, D, F, INC, W, NA };

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void buttonSaveForm_Click(object sender, EventArgs e)
        {
            string saveLocation = "save.txt";
            StreamWriter writer = new StreamWriter(saveLocation);
            
            //writer.WriteLine($"{ stu.studentID.ToString()} {stu.firstName} {stu.lastName} {stu.address} {stu.monthofadmition} {stu.grade}");
            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                for(int j =0; j < dataGridView1.Columns.Count; j++)
                {
                    writer.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()} ");
                }
                writer.WriteLine();
            }
            
            //writer.WriteLine(dataGridView1.ToString());
            writer.Close();

            MessageBox.Show($"Information saved as \"{saveLocation}\"", "Save Location", MessageBoxButtons.OK);
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}