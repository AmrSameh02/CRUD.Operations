using EF_Core.Contexts;
using EF_Core.Entities;

namespace EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD

            using AppDbContext context = new AppDbContext();
            #region Create

            //var employee0 = new Employee()
            //{
            //    Name = "Ahmed Sameh",
            //    Salary = 20000,
            //    Address = "Cairo",
            //    Age = 27
            //};

            //var employee1 = new Employee()
            //{
            //    Name = "Kareem Sameh",
            //    Salary = 18000,
            //    Address = "Fakous",
            //    Age = 24
            //};
            //var employee2 = new Employee()
            //{
            //    Name = "Amr Sameh",
            //    Salary = 16000,
            //    Address = "10Th Of Ramadan",
            //    Age = 22
            //};
            //var employee3 = new Employee()
            //{
            //    Name = "Moomen Sameh",
            //    Salary = 10000,
            //    Address = "Giza",
            //    Age = 15

            //};

            //var department = new Department()
            //{
            //    DeptName = "CS",
            //    Manager = employee2
            //};
            //var department1 = new Department()
            //{
            //    DeptName = "Web",
            //    Manager = employee1
            //};
            //var department2 = new Department()
            //{
            //    DeptName = "Security",
            //    Manager = employee2
            //};
            //var department3 = new Department()
            //{
            //    DeptName = "AI",
            //    Manager = employee3
            //};

            //context.Employees.Add(employee0);
            //context.Employees.Add(employee1);
            //context.Employees.Add(employee2);
            //context.Employees.Add(employee3);
            //context.Departments.Add(department);
            //context.Departments.Add(department2);
            //context.Departments.Add(department3);
            //context.Departments.Add(department1);
            //context.SaveChanges();

            #endregion

            #region Read

            //var result = context.Employees.FirstOrDefault(E => E.Id == 2);
            //var result1 = context.Departments.FirstOrDefault(e => e.Id == 3);
            //Console.WriteLine(result.Name);
            //Console.WriteLine(result1);

            #endregion

            #region Update

            //var result = context.Employees.FirstOrDefault(E => E.Id == 2);

            //result.Name = "Ahmed Sameh";
            //result.Address = "6 October";
            //result.Age = 27;

            //context.SaveChanges();
            #endregion

            #region Delete
            //4-Delete

            //var result = context.Employees.FirstOrDefault(E => E.Id == 2);

            //context.Employees.Remove(result);

            //context.SaveChanges();
            #endregion
        }
    }
}
