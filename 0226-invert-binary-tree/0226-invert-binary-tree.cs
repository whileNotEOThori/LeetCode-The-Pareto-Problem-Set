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
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        var curr = root;

        if(root == null)
            return root;

        // use recursion to solve
        //swap
        TreeNode temp = curr.left; // store reference use temporary node
        curr.left = curr.right;
        curr.right = temp;

        InvertTree(curr.left);
        InvertTree(curr.right);
        
        return root;
    }
}