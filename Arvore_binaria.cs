using System;

namespace BinaryTree {
    class Node {
        public int data;
        public Node left;
        public Node right;
    }

    class BinaryTree {
        private Node root;

        public BinaryTree() {
            root = null;
        }

        public void Insert(int data) {
            Node newNode = new Node();
            newNode.data = data;

            if (root == null) {
                root = newNode;
            } else {
                Node current = root;
                Node parent;

                while (true) {
                    parent = current;

                    if (data < current.data) {
                        current = current.left;

                        if (current == null) {
                            parent.left = newNode;
                            break;
                        }
                    } else {
                        current = current.right;

                        if (current == null) {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
    }
        public bool Search(int data) {
            Node current = root;

            while (current != null) {
                if (data == current.data) {
                    return true;
                } else if (data < current.data) {
                    current = current.left;
                } else {
                    current = current.right;
                }
            }

            return false;
        }

        public bool Remove(int data) {
            Node current = root;
            Node parent = root;
            bool isLeftChild = true;

            while (current.data != data) {
                parent = current;

                if (data < current.data) {
                    isLeftChild = true;
                    current = current.left;
                } else {
                    isLeftChild = false;
                    current = current.right;
                }

                if (current == null) {
                    return false;
                }
            }

            if (current.left == null && current.right == null) {
                if (current == root) {
                    root = null;
                } else if (isLeftChild) {
                    parent.left = null;
                } else {
                    parent.right = null;
                }
            } else if (current.right == null) {
                if (current == root) {
                    root = current.left;
                } else if (isLeftChild) {
                    parent.left = current.left;
                } else {
                    parent.right = current.left;
                } 
            } else if (current.left == null) {
                if (current == root) {
                    root = current.right;
                } else if (isLeftChild) {
                    parent.left = current.right;
                } else {
                    parent.right = current.right;
                }
            } else {
                Node successor = GetSuccessor(current);

                if (current == root) {
                    root = successor;
                } else if (isLeftChild) {
                    parent.left = successor;
                } else {
                    parent.right = successor;
                }

                successor.left = current.left;
            }

            return true;
        }

        private Node GetSuccessor(Node node) {
            Node successorParent = node;
            Node successor = node;
            Node current = node.right;

            while (current != null) {
                successorParent = successor;
                successor = current;
                current = current.left;
            }

            if (successor != node.right) {
                successorParent.left = successor.right;
                successor.right = node;
            }
            
            return successor;
    }

    public void InOrderTraversal(Node node) {
        if (node != null) {
            InOrderTraversal(node.left);
            Console.Write(node.data + " ");
            InOrderTraversal(node.right);
        }
    }

    public void PreOrderTraversal(Node node) {
        if (node != null) {
            Console.Write(node.data + " ");
            PreOrderTraversal(node.left);
            PreOrderTraversal(node.right);
        }
    }

    public void PostOrderTraversal(Node node) {
        if (node != null) {
            PostOrderTraversal(node.left);
            PostOrderTraversal(node.right);
            Console.Write(node.data + " ");
        }
    }
}

class Program {
    static void Main(string[] args) {
        BinaryTree tree = new BinaryTree();

        while (true) {
            Console.WriteLine("\n1. Inserir um valor");
            Console.WriteLine("2. Pesquisar um valor");
            Console.WriteLine("3. Remover um valor");
            Console.WriteLine("4. Exibir todos os valores em ordem");
            Console.WriteLine("5. Exibir todos os valores em pré-ordem");
            Console.WriteLine("6. Exibir todos os valores em pós-ordem");
            Console.WriteLine("7. Sair\n");

            Console.Write("Digite uma opção: ");
            int option = int.Parse(Console.ReadLine());

            switch (option) {
                case 1:
                    Console.Write("\nDigite um valor para inserir: ");
                    int value = int.Parse(Console.ReadLine());
                    tree.Insert(value);
                    Console.WriteLine("\nValor inserido com sucesso!");
                    break;

                case 2:
                    Console.Write("\nDigite um valor para pesquisar: ");
                    int searchValue = int.Parse(Console.ReadLine());

                    if (tree.Search(searchValue)) {
                        Console.WriteLine("\nValor encontrado!");
                    } else {
                        Console.WriteLine("\nValor não encontrado!");
                    } break;

                case 3:
                    Console.Write("\nDigite um valor para remover: ");
                    int removeValue = int.Parse(Console.ReadLine());

                    if (tree.Remove(removeValue)) {
                        Console.WriteLine("\nValor removido com sucesso!");
                    } else {
                        Console.WriteLine("\nValor não encontrado!");
                    } break;

                case 4:
                    Console.Write("\nValores em ordem: ");
                    tree.InOrderTraversal(tree.root);
                    Console.WriteLine();
                    break;

                case 5:
                    Console.Write("\nValores em pré-ordem: ");
                    tree.PreOrderTraversal(tree.root);
                    Console.WriteLine();
                    break;

                case 6:
                    Console.Write("\nValores em pós-ordem: ");
                    tree.PostOrderTraversal(tree.root);
                    Console.WriteLine();
                    break;

                case 7:
                    Console.WriteLine("\nSaindo...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }
        }
    }
}
