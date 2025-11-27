

namespace Interface_Casting_Operator_Overloading_Static_Extension.Models
{
    internal class Student
    {
        private string _fullname;
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                
               if (!CheckFullname(value))
                   throw new ArgumentException("Fullname düzgün formatda deyil (Ad + Soyad, hər ikisi böyük hərflə başlamalıdır).");

              _fullname = value;
                
            }
          
        }
        private string _GroupNo;
        public string GroupNo
        {
            get 
            {
                return _GroupNo; 
            }
            set
            {
                if (!CheckGroupNo(value))
                    throw new ArgumentException("GroupNo düzgün deyil");

                _GroupNo = value;
            }

        }
        public int Age { get; set; }
        public Student(string fullname,string groupno,int age)
        {
            Fullname = fullname;
            GroupNo = groupno;
            Age = age;
        }

        public static bool CheckFullname(string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname)) return false;

            string[] parts = fullname.Trim().Split(' ');

            if (parts.Length != 2) return false;

            return char.IsUpper(parts[0][0]) && char.IsUpper(parts[1][0]);
        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (string.IsNullOrEmpty(groupNo) || groupNo.Length != 4)
                return false;

            if (!char.IsUpper(groupNo[0]))
                return false;

            for (int i = 1; i < 4; i++)
            {
                if (!char.IsDigit(groupNo[i]))
                    return false;
            }

            return true;
        }
    }
}

