

/* Hidden stub code will pass a root argument to the function below. Complete the function to solve the challenge. Hint: you may want to write one or more helper functions.  

    boolean checkBST(Node root) {
        boolean isTree = false;

        if (root == null)
            return true;

        if (root.left != null && root.left.data < root.data)
        {
            isTree = true;
            checkBST(root.left);
        }

        if (root.right != null && root.right.data > root.data)
        {
            isTree = true;
            checkBST(root.right);
        }

        return isTree;         
    }
