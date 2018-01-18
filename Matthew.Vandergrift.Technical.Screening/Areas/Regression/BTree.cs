using System.Text;

namespace Matthew.Vandergrift.Technical.Screening.Areas.Regression
{
    public class BTree
    {
        public BTreeNode Root;
        public StringBuilder Output;

        public BTree()
        {
            Root = null;
            Output = new StringBuilder();
        }

        public BTreeNode ReturnRoot()
        {
            return Root;
        }

        public void Insert(int value)
        {
            var newNode = new BTreeNode {Value = value};

            //if the root is null then we are in the beginning, set the root to the new node from the new value
            if (Root == null)
                Root = newNode;
            //if the root is NOT null then we are traversing and setting nodes according to left less than, right else
            else
            {
                //Assign the current node for inspection to being the root
                var current = Root;

                //continual loop of traversing till we reach the bottom most values or null assignments
                while (true)
                {
                    //set the parent to the current (which starts as root and then parent gets assigned down the traverse)
                    var parent = current;
                    if (value < current.Value)
                    {
                        //set the current node for inspection to the current nodes left side
                        current = current.Left;

                        //if the current left side is NOT null then continue to traverse down
                        if (current != null) continue;

                        //if the current left side IS NULL then set it to the new node and return out. 
                        parent.Left = newNode;
                        return;
                    }

                    //else the value is equal or greater than the current (go ahead and assign the right side)
                    current = current.Right;

                    //if the current is NOT null then continue out as the assignment was successful
                    if (current != null) continue;

                    //if the current IS NULL then set it to the new node and return out
                    parent.Right = newNode;
                    return;
                }
            }
        }

        public void PreOrder(BTreeNode node)
        {
            if (node == null) return;
            Output.Append($"{node.Value} ");

            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void InOrder(BTreeNode node)
        {
            if (node == null) return;

            InOrder(node.Left);
            Output.Append($"{node.Value} ");
            InOrder(node.Right);
        }

        public void PostOrder(BTreeNode node)
        {
            if (node == null) return;

            PostOrder(node.Left);
            PostOrder(node.Right);
            Output.Append($"{node.Value} ");
        }

    }
}