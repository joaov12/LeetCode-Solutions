// Runtime 57ms
// Memory 40.66MB

public TreeNode InvertTree(TreeNode root)
{
    if (root == null) return null;
  
    var temp = root.left;
    root.left = root.right;
    root.right = temp;

    InvertTree(root.left);
    InvertTree(root.right);

    return root;
}
