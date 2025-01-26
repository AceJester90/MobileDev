using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EntryAndEditor
{
    class Student
    {
        public static ObservableCollection<Student> List = new ObservableCollection<Student>();

        public string Name { get; set; }
        public string Course { get; set; }
        public string EmailAdd { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string Remarks { get; set; }
    }
}
