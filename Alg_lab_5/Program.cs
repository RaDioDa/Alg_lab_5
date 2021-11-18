using System;
using System.Collections.Generic;

namespace Alg_lab_5
{
    internal class Program
    {
       
        private static void Main(string[] args)
        {
            bool exit = false;
            

            
            while (!exit) 
            {
                Console.WriteLine("1.\n" +
                "2.\n");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        {
                            Console.Clear();
                            Random rList = new Random();
                            Random rTree = new Random();
                            int maxVal = 100;
                            int n = 25;
                            BinaryTree<int> tree = new BinaryTree<int>(maxVal, null);
                            List<int> list = new List<int>();
                            list.Add(rList.Next(maxVal));
                            BinaryTree<int> tree2 = new BinaryTree<int>(maxVal, null);
                            List<int> list2 = new List<int>();
                            list2.Add(rList.Next(maxVal));


                            for (int i = 0; i < n; i++)
                            {
                                int val = rList.Next(0, maxVal);
                                int val2 = rList.Next(0, maxVal);
                                if (!list.Contains(val) && !list2.Contains(val2))
                                {
                                    list.Add(val);
                                    list2.Add(val2);
                                    tree.add(val);
                                    tree2.add(val2);
                                }
                            }

                            tree.Print();
                            tree2.Print();
                            if (tree.Equals(tree2))
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Write(tree.Equals(tree2));
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write(tree.Equals(tree2));
                            }
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                        case 2:
                        {
                            Console.Clear();
                            Random rList = new Random();
                            Random rTree = new Random();
                            int maxVal = 100;
                            int n = 25;
                            BinaryTree<int> tree = new BinaryTree<int>(maxVal, null);
                            List<int> list = new List<int>();
                            list.Add(rList.Next(maxVal));
                            BinaryTree<int> tree2 = new BinaryTree<int>(maxVal, null);
                            List<int> list2 = new List<int>();
                            list2.Add(rList.Next(maxVal));

                            for (int i = 0; i < n; i++)
                            {
                                int val = rList.Next(0, maxVal);
                                int val2 = rList.Next(0, maxVal);
                                if (!list.Contains(val) && !list2.Contains(val2))
                                {
                                    list.Add(val);
                                    
                                    tree.add(val);
                                    
                                }
                            }

                            tree2 = tree;

                            tree.Print();
                            tree2.Print();
                            if(tree.Equals(tree2))
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Write(tree.Equals(tree2));
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write(tree.Equals(tree2));
                            }
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            }
            
        }
    }
}
