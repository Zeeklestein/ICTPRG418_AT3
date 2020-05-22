using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AT3_418
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //creates 
            createDatFile();
            dataToComboBox(dataFilePath);
        }

        static string dataFilePath = @".\students.dat";

        public static int position = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            //checks if text box requirements are met
            if(txtStudentId.TextLength > 10)
            {
                MessageBox.Show("Student ID must be 10 or less characters.");
                
            }
            else if(txtSubject.TextLength > 17)
            {
                MessageBox.Show("Subject must be 17 or less characters.");
                
            }
            else if(txtResult.TextLength > 3)
            {
                MessageBox.Show("Result must be 3 or less characters.");
                
            }
            else
            {
                //Creates a new student and writes it to the binary file using the writeToFile method
                Student student = new Student(txtStudentId.Text, txtSubject.Text, txtResult.Text);

                //increase the position on new student
                position++;
                //write to the student file
                writeToFile(dataFilePath, student, position, student.Size);

                MessageBox.Show("Student added successfully.");

                //Clears and reloads the combobox to give up-to-date data
                cbxStudent.Items.Clear();
                dataToComboBox(dataFilePath);
                //clears the text boxes
                txtResult.Clear();
                txtStudentId.Clear();
                txtSubject.Clear();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //uses the readFromFile method when the view button is clicked
            readFromFile(dataFilePath);
        }

        private void dataToComboBox(string filename)
        {
            //retrieves the student ids from the binary file and displays them in the combo box
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryReader br = new BinaryReader(fs);

            Student student = new Student();
            int record = 0;
            for (int i = 0; i < fs.Length / student.Size; i++)
            {
                record++;
                fs.Seek(record * student.Size, 0);

                student.StudentId = br.ReadString().ToString();
                
                cbxStudent.Items.Add(student.StudentId);
                
            }
            br.Close();
            fs.Close();
        }   

        private void createDatFile()
        {
            //creates a .dat file in the specified location, but only if it does not exist
            if (!File.Exists(dataFilePath))
            {
                
                FileInfo datFile = new FileInfo(dataFilePath);

                BinaryWriter newStudentBinaryWriter = new BinaryWriter(datFile.OpenWrite());
                newStudentBinaryWriter.Close();
            }
        }
           

        private void writeToFile(string filename, Student obj, int pos, int size)
        {
            //writes studentId, subject and result to the specified file
            FileStream fs = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.None);
            BinaryWriter bw = new BinaryWriter(fs);

            fs.Position = pos * size;

            bw.Write(obj.StudentId);
            bw.Write(obj.Subject);
            bw.Write(obj.Result);

            bw.Close();
            fs.Close();
        }

        private void readFromFile(string filename)
        {
            //reads the data from the specified file
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryReader br = new BinaryReader(fs);

            Student student = new Student();
            int record = 0;
            int index = cbxStudent.SelectedIndex + 1;

            for (int i = 0; i < fs.Length / student.Size; i++)
            {
                fs.Seek(index * student.Size, 0);

                student.StudentId = br.ReadString().ToString();
                student.Subject = br.ReadString().ToString();
                student.Result = br.ReadString().ToString();

                //Prints the results in the label
                lblStudentResults.Text = ($"{student.StudentId} \t {student.Subject} \t {student.Result}");
                record++;
            }
            //update new position after the last record
            position = record;

            br.Close();
            fs.Close();
        }

        private void dataToArray(string filename)
        {
            //reads the binary file and sends the student data to an array. Prints the array in a listbox
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryReader br = new BinaryReader(fs);

            string[] studentArray = new string[] { };

            Student student = new Student();
            int record = 0;
            for (int i = 0; i < fs.Length / student.Size; i++)
            {
                record++;
                fs.Seek(record * student.Size, 0);

                student.StudentId = br.ReadString().ToString();
                student.Subject = br.ReadString().ToString();
                student.Result = br.ReadString().ToString();
                
                //Adds the student data to the array
                studentArray = studentArray.Concat(new string[] { (string)student.StudentId + "\t" + (string)student.Subject + "\t" + (string)student.Result }).ToArray();
                Array.Sort(studentArray);
                lbxArray.Items.Clear();

                foreach (string arrayItem in studentArray)
                {
                    lbxArray.Items.Add(arrayItem);
                }
            }
            br.Close();
            fs.Close();
        }

        private void btnLoadArray_Click(object sender, EventArgs e)
        {
            //runs the dataToArray method when the load button is clicked
            dataToArray(dataFilePath);
        }
    }
}
