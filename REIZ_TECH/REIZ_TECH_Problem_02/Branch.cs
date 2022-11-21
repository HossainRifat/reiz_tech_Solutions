using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIZ_TECH_Problem_02
{


    public class Branch
    {
        /*
              branch1
             /       \
        branch2     branch3
           /      /     |    \
      branch4    /      |     \
                /       |      \  
               /        |       \
             branch5 branch6 branch7
             /       /     \
        branch8  branch9 branch10
                    |
                 branch11

        */

        public List<Branch> branches;
        public int id;
    }

    public class Program
    {
        public static int d = 1;
        public static int depth = 0;
        
        public void depthFind(Branch branch)
        {
           
            
            if (branch.branches.Count > 0)
            {
                d++;
                if (d > depth)
                {
                    depth = d;
                }
                foreach (Branch branch2 in branch.branches)
                {
                    Console.WriteLine("branch" + branch2.id + "iteration" + d);
                    depthFind(branch2);
                }
                
            }
            else
            {
                d--;
                Console.WriteLine("0");
            }

            
            
        }

        static void Main(string[] args)
        {
            Branch branch1 = new Branch();
            branch1.branches = new List<Branch>();
            branch1.id = 1;

            Branch branch2 = new Branch();
            branch2.branches = new List<Branch>();
            branch2.id = 2;

            Branch branch3 = new Branch();
            branch3.branches = new List<Branch>();
            branch3.id = 3;

            Branch branch4 = new Branch();
            branch4.branches = new List<Branch>();
            branch4.id = 4;

            Branch branch5 = new Branch();
            branch5.branches = new List<Branch>();
            branch5.id = 5;

            Branch branch6 = new Branch();
            branch6.branches = new List<Branch>();
            branch6.id = 6;

            Branch branch7 = new Branch();
            branch7.branches = new List<Branch>();
            branch7.id = 7;

            Branch branch8 = new Branch();
            branch8.branches = new List<Branch>();
            branch8.id = 8;
            
            Branch branch9 = new Branch();
            branch9.branches = new List<Branch>();
            branch9.id = 9;
            
            Branch branch10 = new Branch();
            branch10.branches = new List<Branch>();
            branch10.id = 10;

            Branch branch11 = new Branch();
            branch11.branches = new List<Branch>();
            branch11.id = 11;

            branch1.branches.Add(branch2);
            branch1.branches.Add(branch3);
            branch2.branches.Add(branch4);

            branch3.branches.Add(branch5);
            branch3.branches.Add(branch6);
            branch3.branches.Add(branch7);

            branch5.branches.Add(branch8);

            branch6.branches.Add(branch9);
            branch6.branches.Add(branch10);
            branch9.branches.Add(branch11);
            

            int i = 1;

            Console.WriteLine("Branch1");
            foreach (Branch br in branch1.branches)
            {
                i++;
                Console.WriteLine("|_Branch" + br.id);
                if (br.branches.Count > 0)
                {
                    int j = 0;
                    foreach (Branch br2 in br.branches)
                    {
                        j++;
                        Console.WriteLine("   |_branch" + br2.id);

                        if (br2.branches.Count > 0)
                        {
                            int k = 0;
                            foreach (Branch br3 in br2.branches)
                            {
                                k++;
                                Console.WriteLine("         |_branch" + br3.id);
                                if (br3.branches.Count > 0)
                                {
                                    int l = 0;
                                    foreach (Branch br4 in br3.branches)
                                    {
                                        l++;
                                        Console.WriteLine("               |_branch" + br4.id);
                                    }
                                }
                            }
                        }
                    }

                }
            }


            Program P = new Program();

            P.depthFind(branch1);

            Console.WriteLine("depth of the tree is: " + depth);

            Console.ReadLine();
        }
    }
}
