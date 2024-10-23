using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    public class Employee
    {
        int id;
        string name;
        int age;
        decimal salary;
        #region Setters & gette  [Gates]
        public void SetId(int _id)
        {
            id = _id;
        }
        public int GetId()
        {
            return id;
        }
        public void SetName(string _name)
        {
            name = _name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAge(int _age)
        { age = _age; }

        public int GetAge()
        {
            return age;
        }
        public void SetSalary(decimal _salary)
        {
            if (_salary >= 5000 && _salary <= 10_000)
            {
                salary = _salary;
            }
            else
            {
                salary = 5000;
            }
        }
        public decimal GetSalary()
        {
            return salary;
        }
        //RECOMMENDED
        public string PrintV2()
        {
            return $"{id}:{name}:{age}:{salary}";
        }
        #endregion

    }
}
