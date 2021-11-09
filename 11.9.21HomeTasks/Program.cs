using System;

namespace _11._9._21HomeTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            byte choise = 255;
            Console.WriteLine("Welcome to Department informatio System\n");
            Console.WriteLine("You can choose following choises:\n");
            DepartmentService departmentService = new DepartmentService();
            do
            {
                
               
                Console.WriteLine("1. Create department");
                Console.WriteLine("2. Update department");
                Console.WriteLine("3. Delete department");      
                Console.WriteLine("4. Find department");
                Console.WriteLine("5. Read Departments");
                Console.WriteLine("0. Exit");
             

                Console.WriteLine();
                if (byte.TryParse(Console.ReadLine(),out choise))
                {
                    switch (choise)
                    {
                        case 1:
                            Department newdepartment = new Department();

                            newdepartment.Id = departmentService.FindId();

                            Console.WriteLine("Enter name");
                            newdepartment.Name = Console.ReadLine();
                            newdepartment.EmployeeCount += 1;

                            departmentService.Create(newdepartment);
                            Console.WriteLine("New department Successfully added!") ;


                            break;
                        case 2:
                            Console.WriteLine("Select Id of the department for update:");

                            foreach (var item in departmentService.Read())
                            {

                                Console.WriteLine($" Id: {item.Id} Name: {item.Name}");
                            }
                            int depId = Convert.ToInt32(Console.ReadLine());

                            Department department = departmentService.Find(depId);

                            Console.WriteLine($"Enter the new name {department.Name}");
                            department.Name = Console.ReadLine();

                            departmentService.Uptade(depId, department);

                            Console.WriteLine("Succsess Uptaded department Name!");
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine("Selecet id of the department for delete:");

                            Department[] departments2 = departmentService.Read();
                            for (int i = 0; i < departments2.Length; i++)
                            {
                                Console.WriteLine($"{i+1}. Id: {departments2[i].Id}, Name: {departments2[i].Name}");
                            }
                            int IdForDelete = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Department deleted Successfully!");
                            Console.WriteLine();

                            break;

                        case 4:
                            Console.WriteLine("Enter id");
                            int Id = Convert.ToInt32(Console.ReadLine());
                            Department department1 = departmentService.Find(Id);
                            Console.WriteLine($"{department1.Name} Name . Id {department1.Id}");
                            Console.WriteLine();
                            break;
                        case 5:
                            Department[] departments = departmentService.Read();
                            for (int i = 0; i < departments.Length; i++)
                            {
                                Console.WriteLine($"ID :{departments[i].Id} Name :{departments[i].Name}");
                            }
                            Console.WriteLine();
                            break;
                        case 0:
                            Console.WriteLine("Exit");
                            Console.WriteLine();
                            break;

                        default: Console.WriteLine("Cohise the list");
                            Console.WriteLine();
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Choise the list");
                    choise = 255;
                }


            } while (choise!=0);

        }
    }
    #region Task1
    //class Ticket
    //{
    //    public FilmInfo filmInfo { get; set; }

    //    public TimeSpan timespan { get; set; }
    //    public DateTime datetime { get; set; }
        


    //}
    //class DateTime
    //{

    //    public int Date { get; set; }
    //    public int SellDate { get; set; }


    //}
    //class TimeSpan
    //{
    //    public int Duration { get; set; }
    //    public int _timespan { get; set; }


    //}
    //class FilmInfo
    //{
    //    public string poster { get; set; }

    //    public string MoveiName { get; set; }
    //    public string genre { get; set; }

    //}
    #endregion
}
