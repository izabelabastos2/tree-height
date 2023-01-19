//Programa em C# para encontrar a profundidade de uma árvore
using System;
 
// nó de uma árvore binária
public class Node
{
    public int data;
    public Node left, right;

    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

public class BinaryTree
{
    Node root;

    /* calcula a profundidade da árvore = número de nós  no caminho mais longo desde a raiz à folha = "maxDepth" */
    int maxDepth(Node node)
    {
        if (node == null)
            return 0;
        else
        {
            /* calcula a profundidade de cada sub árvore */
            int lDepth = maxDepth(node.left);
            int rDepth = maxDepth(node.right);

            /* usa o maior */
            if (lDepth > rDepth)
                return (lDepth + 1);
            else
                return (rDepth + 1);
        }
    }

    public static void Main(String[] args)
    {
        BinaryTree tree = new BinaryTree();

        tree.root = new Node(3);
        tree.root.left = new Node(2);
        tree.root.right = new Node(5);
        tree.root.left.left = new Node(1);
        tree.root.right.left = new Node(4);
        tree.root.right.right = new Node(6);
        tree.root.right.right = new Node(7);
        tree.root.right.right.right = new Node(7);

        Console.WriteLine("Height of tree is "
                          + tree.maxDepth(tree.root));
    }
}