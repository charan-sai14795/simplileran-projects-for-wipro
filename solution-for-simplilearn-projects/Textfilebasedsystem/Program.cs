using System;
using System.Collections.Generic;
using System.IO;
namespace Textfilebasedsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            List<Teacher> l = new List<Teacher>();
            
            string file2 = @"C:\Users\chara\Desktop\teacher";
            string []lines=File.ReadAllLines(file2);
            foreach (string line in lines)
            {
                Teacher y = new Teacher();
                string [] split = line.Split(' ');
                y.id=Convert.ToInt32(split[0]);
                y.f_name=split[1];
                y.l_name=split[2];
                y.clss=split[3];
                y.section=split[4];
                l.Add(y);
            }
            do
            {
                int m = 0;
                Console.WriteLine("Hello World!");
                string file = @"C:\Users\chara\Desktop\teacher";
                Console.WriteLine("1.add/create new record\n2.update an existing record\n3.search/reteive a record\n4.delete a record\n5.display\n6.save all the data in to text files(use it only when all your changes are done)");
                Console.WriteLine("enter which operation to be performed");
                int x = Int32.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        //create
                        Console.WriteLine("enter the data to be added with id, fistname,lastname class section");
                        string data = Console.ReadLine();
                        string[] a = data.Split(" ");
                        Teacher p = new Teacher();
                        p.id = Convert.ToInt32(a[0]);
                        p.f_name = a[1];
                        p.l_name = a[2];
                        p.clss = a[3];
                        p.section = a[4];
                        l.Add(p);
                        p.addrecord(file, data);
                        break;
                    case 2:
                        //update 
                        Console.WriteLine("enter id to of the field you want to update");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the field to be modified-----id(0),f_name(1),l_name(2),clss(3),section(4)");
                        int j=Convert.ToInt32(Console.ReadLine());
                        foreach(Teacher q in l)
                            if (q.id == i)
                            {
                                if(j==0)
                                { Console.WriteLine($"enter id");
                                int d=Convert.ToInt32(Console.ReadLine());
                                q.id= d;}
                                else if (j == 1)
                                {
                                    Console.WriteLine($"enter first name");
                                    string fname=Console.ReadLine();
                                    q.f_name= fname;
                                }
                                else if (j == 2)
                                {
                                    Console.WriteLine("enter last name");
                                    string lname=Console.ReadLine();
                                    q.l_name= lname;
                                }
                                else if(j == 3)
                                { Console.WriteLine("enter the class");
                                string c=Console.ReadLine();
                                q.clss= c;
                                }
                                else
                                {
                                    Console.WriteLine("enter the section");
                                    string s=Console.ReadLine();
                                    q.section= s;
                                }
                                Console.WriteLine($"updated data is {q.id} {q.f_name} {q.l_name} {q.clss} {q.section}.");
                            }
                        break;
                    case 3:
                        //seach or retrieve
                        Console.WriteLine("enter the id whose record to be searched/retrived");
                        int id = Convert.ToInt32(Console.ReadLine());
                        foreach (Teacher t in l)
                        {
                            if (t.id == id)
                            {
                                Console.WriteLine($"{id} is present and its details are {t.id} {t.f_name} {t.l_name} {t.clss} {t.section}.");
                                m = 1;
                                break;
                            }

                        }
                        if (m == 0) Console.WriteLine($"{id} is not present");
                        break;
                    case 4:
                        //delete a record.
                        Console.WriteLine("enter the id to be removed");
                        int tid=Convert.ToInt32(Console.ReadLine());
                        foreach(Teacher ted in l)
                        {
                            if (ted.id == tid)
                            {
                                l.Remove(ted);
                                break;
                            }
                        }
                        Console.WriteLine($"the data of teacher with id {tid} has been removed");
                        break;
                    case 5:
                        //display
                        foreach(Teacher te in l)
                        {
                            Console.WriteLine($"{te.id} {te.f_name} {te.l_name} {te.clss} {te.section}.");
                        }
                        break;
                    case 6:
                        //saving in to text file.
                        string[] save=new string[l.Count];
                        int ct = 0;
                        foreach(Teacher lis in l)
                        {
                            save[ct] = $"{lis.id} {lis.f_name} {lis.l_name} {lis.clss} {lis.section}";
                            ct += 1;
                        }
                        File.WriteAllLines(file, save);
                        break;
                }
                Console.WriteLine("do you want to perform other operation.press 1(yes)/2(no)");
                n=Convert.ToInt32(Console.ReadLine());
            }while(n==1);

            
        }

    }
}
