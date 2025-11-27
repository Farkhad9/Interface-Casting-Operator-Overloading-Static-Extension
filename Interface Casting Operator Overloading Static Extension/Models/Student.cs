

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
                value.Split(' ');
                 Fullname = value.Trim(); //TODO: fix later
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
                if (string.IsNullOrEmpty(value) || value.Length != 4)
                {
                    throw new ArgumentException("Göndərilən GroupNo ya boşdur, ya da uzunluğu 4-ə bərabər deyil.");
                }

                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Göndərilən GroupNo-nun ilk hərfi böyük hərf deyil.");
                }

                // Rəqəmləri yoxla
                for (int i = 1; i < 4; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        throw new ArgumentException("Göndərilən GroupNo-nun son 3 simvolu rəqəm olmalıdır.");
                    }
                }

                int number = int.Parse(value.Substring(1, 3));
                if (number < 1 || number > 999)
                {
                    throw new ArgumentException("GroupNo-nun rəqəm hissəsi 001-999 arasında olmalıdır.");
                }

                _GroupNo = value;
            }

        }
        public int Age { get; set; }
        public Student()
        {
           
        }

    }
}
