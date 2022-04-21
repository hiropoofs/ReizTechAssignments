internal class Program
{
    static void Main(string[] args)
    {
        Branch root = initializeTree();

        Console.WriteLine(RecursiveMethodMeasureDepth(root));
        //At first I kept encapsulation of List<root> by keeping it private, but for the use of LINQ I had to make it public
        //Or I had to make a method to copy the elements of imutable array and put it into a new mutable one with return.
        Console.WriteLine(RecursiveMethodMeasureDepthLINQ(root));

        Console.ReadKey();
    }
    /// <summary>
    /// More of a generic way to perform iteration over multiple branches before diving deeper into the tree
    /// Although as it is more easily readable, LINQ method does it quicker.
    /// </summary>
    /// <param name="branch"></param>
    /// <returns></returns>
    static int RecursiveMethodMeasureDepth(Branch branch)
    {
        int value = 1;
        int highestValue = 1;
        for (int i = 0; i < branch.Count(); i++)
        {
            value = RecursiveMethodMeasureDepth(branch.GetBranch(i)) + 1;
            highestValue = value > highestValue ? value : highestValue;
        }
        return highestValue;
    }
    /// <summary>
    /// Using LINQ .Aggregate which applies an accumulator function over a sequence. The .Aggregate method makes it simple
    /// to perform a calculation over a sequence of values by constantly calling further branch of a tree.
    /// We get the same results as with the regular for loop, but the performance is way quicker.
    /// </summary>
    /// <param name="branch"></param>
    /// <returns></returns>
    static int RecursiveMethodMeasureDepthLINQ(Branch branch)
    {
        int currentDepth = 1;
        return branch
            .branches
            .Aggregate(1, (depth, next) =>
            {
            currentDepth = RecursiveMethodMeasureDepthLINQ(next) + 1;
            return depth < currentDepth ? currentDepth : depth;
            });
    }
    /// <summary>
    /// Method that initializes a tree of the same structure as in given task with the maximum depth of 5
    /// </summary>
    /// <returns>sets the Branch object with the generated tree one</returns>
    static Branch initializeTree()
    {
        Branch root = new Branch();
        Branch branch2 = new Branch();
        Branch branch3 = new Branch();
        root.AddBranch(branch2);
        root.AddBranch(branch3);
        Branch branch4 = new Branch();
        branch2.AddBranch(branch4);
        Branch branch5 = new Branch();
        Branch branch6 = new Branch();
        Branch branch7 = new Branch();
        branch3.AddBranch(branch5);
        branch3.AddBranch(branch6);
        branch3.AddBranch(branch7);
        Branch branch8 = new Branch();
        branch5.AddBranch(branch8);
        Branch branch9 = new Branch();
        Branch branch10 = new Branch();
        branch6.AddBranch(branch9);
        branch6.AddBranch(branch10);
        Branch branch11 = new Branch();
        branch9.AddBranch(branch11);
        return root;
    }
}
public class Branch
{
    public List<Branch> branches;
    public Branch()
    {
        branches = new List<Branch>();
    }
    public void AddBranch(Branch branch)
    {
        branches.Add(branch);
    }
    public Branch GetBranch(int index)
    {
        return branches[index];
    }
    public int Count()
    {
        return branches.Count;
    }
}