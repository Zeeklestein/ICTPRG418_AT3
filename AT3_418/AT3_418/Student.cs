using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT3_418
{
    class Student
    {
        private string studentId;
        private string subject;
        private string result;
        private int recordSize;

        public Student()
        {
            
        }

        public Student(string StudentId, string Subject, string Result)
        {
            this.studentId = StudentId;
            this.subject = Subject;
            this.result = Result;
        }

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        public int Size
        {
            get { return calculateSize(); }
        }

        private int calculateSize()
        {
            recordSize = 60; //random size
            return recordSize;
        }

    }
}
