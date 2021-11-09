using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._9._21HomeTasks
{
    interface Interface1
    {
        Department Create(Department department);
        Department Uptade(int id, Department department);
        bool Delete(int id);
        Department[] Read();

        Department Find(int id);
        int FindId();
    }
}
