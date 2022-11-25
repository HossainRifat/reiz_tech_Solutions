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
    }

    public class Program
    {
        public static int depth = 1;
        public static int maxDepth = 1;
        public static int goingBack = 0;

        public void depthFind(Branch branch)
        {
            
            if (branch.branches.Any())
            {
                depth++;

                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }
                
                foreach (Branch branch2 in branch.branches)
                {
                    Console.WriteLine("Branch, Depth- " + depth);
                    depthFind(branch2);
                }
                goingBack++;

            }

            depth = Math.Abs(depth - goingBack);
            goingBack = 0;

        }

        static void Main(string[] args)
        {
            Branch branch1 = new Branch();
            branch1.branches = new List<Branch>();

            Branch branch2 = new Branch();
            branch2.branches = new List<Branch>();

            Branch branch3 = new Branch();
            branch3.branches = new List<Branch>();

            Branch branch4 = new Branch();
            branch4.branches = new List<Branch>();

            Branch branch5 = new Branch();
            branch5.branches = new List<Branch>();

            Branch branch6 = new Branch();
            branch6.branches = new List<Branch>();

            Branch branch7 = new Branch();
            branch7.branches = new List<Branch>();

            Branch branch8 = new Branch();
            branch8.branches = new List<Branch>();
            
            Branch branch9 = new Branch();
            branch9.branches = new List<Branch>();
            
            Branch branch10 = new Branch();
            branch10.branches = new List<Branch>();

            Branch branch11 = new Branch();
            branch11.branches = new List<Branch>();

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

            Console.WriteLine("Branch1");
            foreach (Branch br in branch1.branches)
            {
                Console.WriteLine("|_Branch");
                if (br.branches.Count > 0)
                {
                    foreach (Branch br2 in br.branches)
                    {
                        Console.WriteLine("   |_branch");

                        if (br2.branches.Count > 0)
                        {
                            foreach (Branch br3 in br2.branches)
                            {
                                Console.WriteLine("         |_branch");
                                if (br3.branches.Count > 0)
                                {
                                    foreach (Branch br4 in br3.branches)
                                    {
                                        Console.WriteLine("               |_branch");
                                    }
                                }
                            }
                        }
                    }

                }
            }

            Console.WriteLine();
            Console.WriteLine("Branch, Depth- 1");

            Program P = new Program();
            P.depthFind(branch1);

            Console.WriteLine("\nMax depth of the branches is: " + maxDepth);

            Console.ReadLine();
        }
    }
}
