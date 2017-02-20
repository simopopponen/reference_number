using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            bool result = false;
            string uRefNo = "";
            //string uRefNo = "";
            classRef iRef = new classRef();
            Console.WriteLine("Give option 1 to check refnumber; option 2 to create refnumber; option 3 to create amount of refnumbers!");
            result = int.TryParse(Console.ReadLine(), out option);

            if (result == true)
            {
                if (option == 1)
                {
                    Console.WriteLine("Give reference number to check");
                    uRefNo = Console.ReadLine();

                    string uReference = uRefNo;
                    string uReference_number =  iRef.RefNo(uRefNo,Convert.ToString(option));

                    if (uReference_number != "0" )
                    {
                        Console.WriteLine("{0} -OK",uRefNo);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Reference number Incorrect");
                        Console.ReadLine();
                    }

                }
                else if (option == 2)
                {
                    Console.WriteLine("Give reference number for create:");

                    uRefNo = Console.ReadLine();
                    if (result)
                    {
                        //Create domestic reference number
                        string RefNo = iRef.RefNo(uRefNo, Convert.ToString(option));

                        Console.WriteLine("Reference number {0}", RefNo);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Not a valid reference");
                        Console.ReadLine();
                    }

                }

                else if (option == 3)
                {
                    Console.WriteLine("Give reference number basepart:");
                    uRefNo = Console.ReadLine();

                    Console.WriteLine("Give amount of referencenumbers:");
                    int amount = int.Parse(Console.ReadLine());

                    for (int i = 0; i < amount; i++)
                    {

                    }
                }
            }
            else
            {
                Console.WriteLine("Give option 1,2 or 3");
                Console.ReadLine();
            }

            }
        }
    } 
