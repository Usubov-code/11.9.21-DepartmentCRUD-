using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._9._21HomeTasks
{
    class DepartmentService : Interface1
    {
        private Department[] departments = new Department[0];
        public Department Create(Department department)
        {
            Array.Resize(ref departments, departments.Length + 1);
            departments[departments.Length - 1] = department;
            return department;
        }

        public bool Delete(int id)
        {
            departments = Array.FindAll(departments, e => e.Id != id);
            return true;
        }

        public Department[] Read()
        {

            return departments;
        }

        public Department Uptade(int id, Department department)
        {
            Department uptadedepartment = Array.Find(departments, e => e.Id == id);
            uptadedepartment = department;
            return uptadedepartment;
        }

        public Department Find(int id)
        {
            Department foundDepartment = Array.Find(departments, e => e.Id == id);
            return foundDepartment;
        }

        public int FindId()
        {
            if (departments.Length == 0)
            {
                return 1;
            }

            return departments[departments.Length - 1].Id + 1;
        }


    }
}
