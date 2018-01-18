using System.Text;

namespace Matthew.Vandergrift.Technical.Screening.Areas.Regression
{
    public class BTree
    {
        public BTreeNode Root;
        public StringBuilder output;

        public BTree()
        {
            Root = null;
            output = new StringBuilder();
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
            if (node != null)
            {
                output.Append($"{node.Value} ");

                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        public void InOrder(BTreeNode node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                output.Append($"{node.Value} ");
                InOrder(node.Right);
            }
        }

        public void PostOrder(BTreeNode node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                output.Append($"{node.Value} ");
            }
        }

        //public object DeleteNode(object data)

        //{

        //    TNode tempDelete = this.GetNode(data);

        //    if (tempDelete != null)

        //    {

        //        if ((tempDelete.Left == null) && (tempDelete.Right == null)) //Its a Leaf node

        //        {

        //            tempParent = tempDelete.Parent;

        //            if (tempDelete == tempParent.Left) //Justremove by making it null

        //                tempParent.Left = null;

        //            else

        //                tempParent.Right = null;

        //        }

        //        else if ((tempDelete.Left == null) || (tempDelete.Right == null)) //It has either Left orRight child

        //        {

        //            tempChild = tempDelete.Left == null ? tempDelete.Right : tempDelete.Left; //Get the child

        //            tempParent = tempDelete.Parent; //Getthe parent

        //            if (tempDelete == tempParent.Left) //Makeparent points to it's child so it will automatically deleted like Linked list

        //                tempParent.Left = tempChild;

        //            else

        //                tempParent.Right = tempChild;

        //        }

        //        else if ((tempDelete.Left != null) || (tempDelete.Right != null)) //It has both Left andRight child

        //        {

        //            TNodepredNode = this.GetNode(this.TreePredecessor_Ite(data));  //Findit's predecessor

        //            if (predNode.Left != null) // Predecessor node canhave no or left child. Do below two steps only if it has left child

        //            {

        //                tempChild = predNode.Left;

        //                predNode.Parent.Right = tempChild; //Assignleft child of predecessor to it's Parent's right.

        //            }

        //            tempDelete.Data = predNode.Data; //Replace the value of predecessor nodeto the value of to be deleted node

        //            //predNode = null; //Remove predecessornode as it's no longer required.

        //        }



        //        return data + " Deleted";

        //    }

        //    else

        //        return "Please enter the valid tree element!";

        //}
    }
}