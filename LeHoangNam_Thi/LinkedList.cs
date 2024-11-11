using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHoangNam_ThiFinalTest
{
    internal class LinkedList
    {
        private LinkedListNode head;
        public void AddMeaning(string meaning)
        {
            if(head == null)
            {
                head = new LinkedListNode(meaning);
            }
            else
            {
                LinkedListNode current = head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next=new LinkedListNode(meaning);
            } 
        }
        public void DisplayMeaning()
        {
            LinkedListNode current = head;
            while (current != null)
            {
                Console.WriteLine("- "+current.Meaning);
                current = current.Next;
            }
        }
        public class TreeNode
        {
            public string EnglishWord;
            public LinkedList Meaning;
            public TreeNode Left;
            public TreeNode Right;
            public TreeNode(string englishWord, string meaning)
            {
                EnglishWord = englishWord;
                Meaning = new LinkedList();
                Left = null;
                Right = null;
            }
        }
        //Cây nhị phân tìm kiếm
        public class BinarySearchTree
        {
            private TreeNode root;
            public void AddWord(string englishWord,string meaning)
            {
                root = AddWord(root, englishWord, meaning);
            }
            private TreeNode AddWord(TreeNode node,string englishWord , string meaning)
            {
                if (node == null)
                {
                    Console.WriteLine("Thêm từ mới"+englishWord);
                    return new TreeNode(englishWord,meaning);
                }
                if (string.Compare(englishWord, node.EnglishWord, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    node.Left=AddWord(node.Left, englishWord, meaning); 
                }
                else if(string.Compare(englishWord, node.EnglishWord, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    node.Right=AddWord(node.Right, englishWord, meaning);
                }
                else
                {
                    Console.WriteLine("Từ này đã có trong từ điển" + englishWord);
                }
                return node;
            }
            public void SearchWord(string englishWord)
            {
                TreeNode result = SearchWord(root, englishWord);
                if(result != null)
                {
                    Console.WriteLine("Nghĩa của từ ' " + englishWord+ " ':" );
                    result.Meaning.DisplayMeaning();
                }
                else
                {
                    Console.WriteLine("Không tìm thấy từ ' " + englishWord+" ' trong từ điển. ");
                }
            }
            private TreeNode SearchWord(TreeNode node,string englishWord)
            {
                if (node == null || string.Equals(node.EnglishWord, englishWord, StringComparison.OrdinalIgnoreCase))
                {
                    return node;
                }
                if (string.Compare(englishWord, node.EnglishWord, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    return SearchWord(node.Left, englishWord);
                }
                else
                {
                    return SearchWord(node.Right, englishWord);
                }
            }
            //In các từ và nghĩa theo thứ tự 
            public void PrintDictionary()
            {
                PrintInOrder(root);
            }
            private void PrintInOrder(TreeNode node)
            {
                if (node != null)
                {
                    PrintInOrder(node.Left);
                    Console.WriteLine("Từ: "+node.EnglishWord);
                    node.Meaning.DisplayMeaning();
                    PrintInOrder(node.Right);
                }
            }
        }
    }
}
