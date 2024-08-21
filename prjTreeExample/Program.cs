using System.ComponentModel;

namespace prjTreeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>();
            tree.Root = new TreeNode<int>() { Data = 100 };
            tree.Root.Children = new List<TreeNode<int>>
            {
                new TreeNode<int>() { Data = 100, Parent = tree.Root },
                new TreeNode<int>() { Data = 1, Parent = tree.Root },
                new TreeNode<int>() { Data = 150, Parent = tree.Root }
            };
            tree.Root.Children[2].Children = new List<TreeNode<int>>()
            {
                new TreeNode<int>{Data = 30, Parent=tree.Root.Children[2]}
            };
            tree.Root.Children[0].Children = new List<TreeNode<int>>()
            {
                new TreeNode<int>{Data = 8, Parent=tree.Root.Children[0]},
                new TreeNode<int>{Data= 11, Parent=tree.Root.Children[0]}
            };
            tree.Root.Children.Add(new TreeNode<int>(){ Data=70, Parent = tree.Root });

            //Console.WriteLine("Data of child " + tree.Root.Children[3].Data.ToString());


            // WORK OUT BY YOURSELF
            //Print all tree data
            int count = tree.Root.Children.Count;
            Console.WriteLine("Root: " + tree.Root.ToString());

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Child: " + tree.Root.Children[i].Data.ToString());
                int c = tree.Root.Children[i].Children.Count;  //problem over here
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine("\tInner child: " + tree.Root.Children[i].Children[j].Data.ToString());
                    break;
                }
            }
        }
    }
}
