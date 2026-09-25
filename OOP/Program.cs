using System;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //emp obj=new emp();
            //obj.Accept(1,"Ali", 20);
            //obj.Show();
            //emp obj1=new emp();
            //obj1.Accept(2,"Marjan", 20);
            //obj1.Show();
            //Student1[] s=new Student1[5];
            //for(int i=0; i<s.Length; i++)
            //{
            //    s[i] = new Student1();
            //    Console.WriteLine("Enter roll no of student:");
            //    int rollno=int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Fees of student:");
            //    int fees=int.Parse(Console.ReadLine());
            //    s[i].Data(rollno,fees);
            //}
            //int max = 0;
            //int studentindex = 0;
            //for(int i = 0; i < s.Length; i++)
            //{
            //    if (max < s[i].fee)
            //    {
            //        max=s[i].fee;
            //        studentindex = i;
            //    }
            //}
            //Console.WriteLine("Max fees is:{0}",max);
            //s[studentindex].Show();
            //Classroom cm = new Classroom();
            //for (int i = 0; i <3; i++)
            //{
            //    cm[i] = new Student();
            //    Console.WriteLine("Enter name");
            //    cm[i].Name = Console.ReadLine();
            //    Console.WriteLine("Enter Marks");
            //    cm[i].Marks =int.Parse( Console.ReadLine());
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Name: {0}, Marks: {1}", cm[i].Name, cm[i].Marks);
            //}   
            //Library lb = new Library();
            //for (int i = 0; i<=3; i++)
            //{
            //    lb[i] = new Book();
            //    Console.Write("Enter Title:");
            //    lb[i].Title = Console.ReadLine();
            //    Console.Write("Enter Price:");
            //    lb[i].Price=int.Parse(Console.ReadLine());
            //}
            //for(int i=0; i<=3; i++)
            //{
            //    Console.WriteLine("Tile of book: {0}, Price of Book: {1}", lb[i].Title, lb[i].Price);
            //}
            //int max = 0;
            //int priceindex = 0;
            //for (int i = 0;i <=3;i++)
            //{
            //    if (max < lb[i].Price)
            //    {
            //        max = lb[i].Price; 
            //        priceindex = i;
            //    }
            //}
            //Console.Write("Max price of Book is:" + max);
            //Console.WriteLine("Most expensive book is: " + lb[priceindex].Title);
            Company obj= new Company();
            for(int i = 0; i <=3; i++)
            {
                obj[i]=new Employee();
                Console.WriteLine("Enter name of Employee:");
                obj[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Salary of Employee:");
                obj[i].Salary =int.Parse( Console.ReadLine());
                obj[i].Applybonus();
            }
            for(int i = 0;i <=3;i++)
            {
                Console.WriteLine("Name of Employee:{0}, Salary of Employee:{1}", obj[i].Name, obj[i].Salary);
            }
            int counter = 0;  //counter is to check that how many employees have 50k+ salary
            for(int i = 0; i <= 3; i++)
            {
                if (obj[i].Salary>50000)
                {
                    counter++;
                }
            }
            Console.WriteLine("Number of employees having 50K+ salary:" + counter);
        }
    }
}