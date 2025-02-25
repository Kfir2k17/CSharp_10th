using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class School
    {
        private string nameSchool;  	//שם בית הספר
        private Node<Teacher> teachers;  // רשימת מורי בית הספר

        public void TeachersWhileMiluim(string[] miluim)//פעולה המקבלת רשימה של מילואים, ומדפיסה את שמות המורים אם הם לא במילואים, והמחליף אם הם כן. o(nm)
        {
            Node<Teacher> p = teachers;
            while (p != null)
            {
                bool inMiluim = false;
                for (int i = 0; i < miluim.Length && !inMiluim; i++)
                {
                    if (p.GetValue().GetName() == miluim[i])
                    {
                        Console.WriteLine(p.GetValue().GetReplace());
                        inMiluim = true;
                    }
                }

                if (!inMiluim)
                    Console.WriteLine(p.GetValue().GetName());
                p = p.GetNext();
            }
        }

        public void UpdateActor(string name, string repName, int age)//פעולה הבודקת מעדכנת/מוסיפה מורה בהתאם לתנאים הרשומים
        {
            Node<Teacher> p = teachers;

            while(p != null)
            {
                if (p.GetValue().GetName() == name && p.GetValue().GetReplace() != repName)
                {
                    p.SetValue(p.GetValue().GetReplace(), repName);
                }
            }
        }
    }
}