using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapsulation
{
    public class Student
    {
        public string Name { get; private set; }
        public Grade Grade { get; private set; }

        private Group _group;
        public int Group { 
            get 
            { 
                return (int)this._group;
            }
            private set 
            { 
                
            } 
        }
        private string _secretNickName;

        public Student(string name, Grade grade, Group group)
        {
            Name = name;
            Grade = grade;
            _group = group;
            _secretNickName = "MySecretNickName";
        }

        public void Upgrade()
        {
            if(Grade != Grade.A)
                Grade--;
        }

        public void Downgrade()
        {
            if(Grade != Grade.F)
                Grade++;
        }

    }

    public enum Grade
    {
        A,
        B,
        C,
        D,
        E,
        F
    };

    public enum Group
    {
        Group_1 = 1,
        Group_2 = 2,
        Group_3 = 3,
        Group_4 = 4,
        Group_5 = 5
    }
}
