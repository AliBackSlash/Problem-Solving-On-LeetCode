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
    public TreeNode BalanceBST(TreeNode root) {
        List<int> values = new List<int>();
        InOrder(root, values);
        return BuildBalanced(values, 0, values.Count - 1);
    }

    private void InOrder(TreeNode node, List<int> values) {
        if (node == null) return;

        InOrder(node.left, values);
        values.Add(node.val);
        InOrder(node.right, values);
    }

    private TreeNode BuildBalanced(List<int> values, int left, int right) {
        if (left > right) return null;

        int mid = left + (right - left) / 2;

        TreeNode root = new TreeNode(values[mid]);
        root.left = BuildBalanced(values, left, mid - 1);
        root.right = BuildBalanced(values, mid + 1, right);

        return root;
    }
}