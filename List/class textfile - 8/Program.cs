using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace class_textfile___8
{
    internal class Program
    {
        public static void Print(Node<char> list)
        {
            Node<char> p = list;
            while (p != null)
            {
                Console.Write(p.GetValue());
                p = p.GetNext();
            }
            Console.WriteLine();
        }

        public static Node<TextFile> SmallestTF(Node<TextFile> list)
        {
            return SmallestTF(list, list);
        }

        public static Node<TextFile> SmallestTF(Node<TextFile> list, Node<TextFile> min)
        {
            if (list == null)
                return min;

            if (min.GetValue().GetTavCount() > list.GetValue().GetTavCount())
                return SmallestTF(list.GetNext(), list);

            return SmallestTF(list.GetNext(), min);
        }

        static void Main(string[] args)
        {
            TextFile textFile = new TextFile();
            textFile.AddWord("Hello");
            textFile.AddWord(" World");
            Node<char> text = textFile.GetText();
            textFile.RemoveExtraSpace();
            Print(text);
            Console.WriteLine(textFile.WordCounter());
            Console.ReadLine();
        }
    }
}
