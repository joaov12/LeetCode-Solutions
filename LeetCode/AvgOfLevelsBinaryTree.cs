// Runtime 115 ms
// Memory 50.2 MB

public class Solution {
    public IList<double> AverageOfLevels(TreeNode root) {
        Queue<TreeNode> queue = new();
        List<Double> ans = new List<Double>();
        queue.Enqueue(root);

         while(queue.Count > 0){
            double sum = 0;
            int size = queue.Count;
            for(int i = 0; i < size; i++){
                TreeNode node = queue.Dequeue();
                sum += node.val;
                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);
            }
            ans.Add(sum/size);
         }
         return ans;
    }
}


/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
