using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student
    {
        public Student(string groupno)
        {
            if (CheckGroupNo(groupno))
                this.GroupNo = groupno;
            else
                Console.WriteLine("GroupNo deyeri yanlisdir!");
        }
        public string Fullname { get; set; }
        public string GroupNo { get; set; }
        public byte Age { get; set; }
        public static bool CheckGroupNo(string groupno)
        {
            if (!string.IsNullOrWhiteSpace(groupno) && groupno.Length == 4)
            {
                if (char.IsUpper(groupno[0]) && char.IsDigit(groupno[1]) && char.IsDigit(groupno[2]) && char.IsDigit(groupno[3]) && groupno[1] != '0')
                    return true;
            }
            return false;
        }
        public static bool CheckFullname(string value)
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Contains(" "))
            {
                string[] fullnameArr = value.Split(' ');
                foreach (var word in fullnameArr)
                {
                    if (char.IsUpper(word[0]))
                    {
                        for (int i = 1; i < word.Length; i++)
                        {
                            if (!(char.IsLetter(word[i]) && char.IsLower(word[i])))
                            {
                                return false;
                            }
                        }
                    }
                    else
                        return false;
                }
                return true;
            }
            return false;

        }

    }
}
