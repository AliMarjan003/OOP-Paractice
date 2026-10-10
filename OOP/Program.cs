using System;
using System.Reflection.Metadata;
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
            //Company obj = new Company();
            //for (int i = 0; i <= 3; i++)
            //{
            //    obj[i] = new Employee();
            //    Console.WriteLine("Enter name of Employee:");
            //    obj[i].Name = Console.ReadLine();
            //    Console.WriteLine("Enter Salary of Employee:");
            //    obj[i].Salary = int.Parse(Console.ReadLine());
            //    obj[i].Applybonus();
            //}
            //for (int i = 0; i <= 3; i++)
            //{
            //    Console.WriteLine("Name of Employee:{0}, Salary of Employee:{1}", obj[i].Name, obj[i].Salary);
            //}
            //int counter = 0;  //counter is to check that how many employees have 50k+ salary
            //for (int i = 0; i <= 3; i++)
            //{
            //    if (obj[i].Salary > 50000)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine("Number of employees having 50K+ salary:" + counter);
            //inheritstudent obj=new inheritstudent();
            //obj.Name = "Ali";
            //obj.Age = 20;
            //obj.marks = 78;
            //obj.Showperson();
            //obj.Showstudent();
            //Teacher t = new Teacher();
            //t.Name = "Sir Ahmed";
            //t.Age = 40;
            //t.salary = 50000;
            //t.Showperson();
            //t.Showteacher();
            //Sportcar obj=new Sportcar();
            //Console.WriteLine("Enter Brand of car:");
            //obj.Brand = Console.ReadLine();
            //Console.WriteLine("Enter Speed of car:");
            //obj.Speed = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Doors of car:");
            //obj.Doors = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Topspeed of car:");
            //obj.Topspeed = int.Parse(Console.ReadLine());
            
            //obj.Showvehicle();
            //obj.Showcar();
            //obj.Showsportcar();
            //employee obj= new employee();
            //Console.WriteLine("Enter id of Employee:");
            //obj.Id=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Name of Employee:");
            //obj.Name=Console.ReadLine();
            //Console.WriteLine("Enter Salary of Employee:");
            //obj.Salary=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter id of Employee:");
            //obj.Id=int.Parse(Console.ReadLine());
            //obj.Showadmin();
            //obj.Showmanager();
            //obj.Addincentive();
            //Creditcardpayment obj=new Creditcardpayment();
            //Console.WriteLine("Enter card number:");
            //obj.Cardnumber = Console.ReadLine();
            //Console.WriteLine("Enter Amount:");
            //obj.Amount = double.Parse(Console.ReadLine());
            //obj.Showreceipt();
            //obj.Processpayment();
            //Cashpayment obj1 = new Cashpayment();
            //Console.WriteLine("Enter Amount:");
            //obj1.Amount = double.Parse(Console.ReadLine());
            //obj1.Showreceipt();
            //obj1.Processpayment();
            Bankaccount obj=new Bankaccount();
            double amount;
            
            int choice=0;
            while(choice!=3)
            {
                Console.WriteLine("1. Deposit  2. Withdraw  3. Exit");
                try
                {
                choice=int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("Enter amount:");
                        amount = Convert.ToDouble(Console.ReadLine());
                        obj.Deposit(amount);
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Enter amount:");
                        amount = Convert.ToDouble(Console.ReadLine());
                        obj.Withdraw(amount);
                    }
                    else if (choice != 3) 
                    {
                        Console.WriteLine("Invalid choice");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter numbers only");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Your balance is:"+obj.Balance);
                }
            }
                Console.WriteLine("exiting........");
        }
    }
}