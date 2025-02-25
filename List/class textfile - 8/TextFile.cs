using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace class_textfile___8
{
    internal class TextFile
    {
        private Node<char> list; //רשימה שמכילה בתוכה את הטקסט
        private int tavCount; //סופר את מספר התווים בקובץ

        public TextFile() //פעולה בונה שלא מקבלת פרמטרים
        {
            this.list = null;
            this.tavCount = 0;
        }

        public int GetTavCount() { return tavCount; } //פעולה המחזירה את מספר התווים
        public Node<char> GetText() { return list; } //מחזירה את הרשימה שמכילה את הטקסט

        public void AddWord(string word) //O(n)
        {
            Node<char> p = list;
            if (list == null)
            {
                list = new Node<char>(word[0]);
                tavCount++;
                p = list;
            }

            else
            {
                while (p.HasNext())
                {
                    p = p.GetNext();
                }
                p.SetNext(new Node<char>(word[0]));
                p = p.GetNext();
            }

            for (int i = 1; i < word.Length; i++)
            {
                p.SetNext(new Node<char>(word[i]));
                tavCount++;
                p = p.GetNext();
            }
            p.SetNext(new Node<char>(' '));
            tavCount++;
        }
        public int WordCounter()//O(n)
        {
            int counter = 0;
            Node<char> p = list;

            while (p != null)
            {
                if (p.GetValue() == ' ')
                    counter++;
                p = p.GetNext();
            }

            return counter;
        }
        public bool IsSimilar(TextFile tf) //O(n)
        {
            if (this.GetTavCount() != tf.GetTavCount())
                return false;

            Node<char> p1 = list;
            Node<char> p2 = tf.GetText();

            while (p1 != null)
            {
                if (p1.GetValue() != p2.GetValue())
                    return false;

                p1 = p1.GetNext();
                p2 = p2.GetNext();
            }
            return true;
        }
        public void RemoveExtraSpace() //O(n), 
        {
            Node<char> p2 = list.GetNext();
            Node<char> p1 = list;
            while (p2 != null)
            {
                if (p1.GetValue() == p2.GetValue() && p1.GetValue() == ' ')
                {
                    p1.SetNext(p2.GetNext());
                    p2.SetNext(null);
                    p2 = p1.GetNext();
                }
                
                p1 = p2;
                p2 = p2.GetNext();
            }
        }
    }
}
