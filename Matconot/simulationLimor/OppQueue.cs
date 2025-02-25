using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulationLimor
{
    class OppQueue
    {
        private Queue<int> q;         //תור המספרים
        private int num;              //מספר שלם שונה מאפס

        public OppQueue(Queue<int> q, int num) // פעולה בונה
        {
            this.q = q;
            this.num = num;
        }

        public int OppLength() // פעולה המחזירה את אורך תת סדרה הנגדית של המספר
        {
            int counter = 0;
            Queue<int> copy = CopyOueue(q);
            bool seq = false;
            while (!copy.IsEmpty())
            {
                int x = copy.Remove();
                if (x == num)
                    seq = true;
                if (seq)
                    counter++;
                if (seq && x == -num)
                    return counter;
            }
            return -1;
        }

        public Queue<int> CopyOueue(Queue<int> q) // פעולה עזר המקבלת תור ומשכפלת אותו בלי לפגוע בתור המקורי
        {
            Queue<int> temp = new Queue<int>();
            Queue<int> copyOueue = new Queue<int>();

            while (!q.IsEmpty())
            {
                temp.Insert(q.Head());
                copyOueue.Insert(q.Remove());
            }

            while (!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }

            return copyOueue;
        }

        public int GetNum()
        {
            return this.num;
        }
    }
}
