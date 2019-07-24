using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class BinarySearchTreeLevelInOrder {
    
    
   static void inOrder(Node root){
        
        if(root != null)
        {
           inOrder(root.left);
           inOrder(root.right);
           
           Console.Write(root.data + " ");
        }
    }

    static Node insert(Node root, int data){

        if(root==null) {
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }

    static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        inOrder(root);
        
    }
}
