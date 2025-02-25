using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knesset___7
{
    public class Kneset
    {
        private Node<Party> coalition;  //  רשימה של מפלגות הקואליציה
        private Node<Party> oposition;  //  רשימה של מפלגות האופוזיציה

        public string BiggestBlock(Node<Party> parties)
        {
            Node<Party> p = parties;
            int right = 0;

            while (p != null)
            {
                if (p.GetValue().GetPoliticalView() == "right")
                    right += p.GetValue().GetMandats();
                p = p.GetNext();
            }

            if (right > 60)
                return "right";

            return "left";
        }

        public Kneset(Node<Party> parties)
        {
            string winning = BiggestBlock(parties);
            int col_mandats = 0;
            Node<Party> max_node = parties;

            while (col_mandats <= 60)
            {
                Node<Party> p = parties;
                while (p != null)
                {
                    if (p.GetValue().GetMandats() > max_node.GetValue().GetMandats() && p.GetValue().GetPoliticalView() == winning)
                        max_node = p;
                    p = p.GetNext();
                }
                col_mandats += max_node.GetValue().GetMandats();
                if (this.coalition == null)
                    this.coalition = max_node;
                else
                    this.coalition.SetNext(max_node);

                p = parties;
                Node<Party> pnext = parties.GetNext();
                while (pnext != null)
                {
                    if (pnext == max_node)
                    {
                        p.SetNext(pnext.GetNext());
                        max_node.SetNext(null);
                    }
                    p = p.GetNext();
                    pnext = pnext.GetNext();
                }

            }
            this.oposition = parties;
        }

        public void JoinCoalition() //פעולה הרצה על מפלגות האופוזיציה ושואלת אותן אם הן רוצות לעבור לקואליציה
        {

            Node<Party> last = this.coalition;

            while (last.HasNext())
                last = last.GetNext();

            Console.WriteLine("The {0} party, do you want to join the coalition? y or n", oposition.GetValue().GetPartyName());
            char ans = char.Parse(Console.ReadLine());

            Node<Party> p = this.oposition; //מצביע על האופוזיציה

            if (ans == 'y')
            {
                this.oposition = this.oposition.GetNext();
                p.SetNext(null);
                last.SetNext(p);
                last = last.GetNext();
                p = this.oposition;
            }

            while (p.GetNext() != null)
            {
                Console.WriteLine("The {0} party, do you want to join the coalition? y or n", p.GetValue().GetPartyName());
                ans = char.Parse(Console.ReadLine());

                if (ans == 'y')
                {
                    Node<Party> pos = p.GetNext();
                    p.SetNext(pos.GetNext());
                    pos.SetNext(null);
                    last.SetNext(pos);
                    last = last.GetNext();
                }
                p = p.GetNext();
            }
        }

        public string FuturePM()
        {
            Node<Party> BiggestParty = this.oposition;
            Node<Party> pOpp = this.oposition;

            while (pOpp != null)
            {
                if (pOpp.GetValue().GetMandats() > BiggestParty.GetValue().GetMandats())
                    BiggestParty = pOpp;
                pOpp = pOpp.GetNext();
            }

            Node<Party> pCol = this.coalition;
            while (pCol != null)
            {
                if (pCol.GetValue().GetMandats() > BiggestParty.GetValue().GetMandats())
                    BiggestParty = pCol;
                pCol = pCol.GetNext();
            }
            return BiggestParty.GetValue().GetHeadMaster();
        }
    }
}