using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LonaPark___4
{
    class Show : Attraction
    {
        private string kind; // סוג ההופעה
        private bool translation; // האם יש תרגום לאנגלית

        public Show(string kind, bool translation, string name, int maxNum, int minAge) : base(name, maxNum, minAge)
        {
            this.kind = kind;
            this.translation = translation;
        }

        //Set
        public void SetKind(string kind) { this.kind = kind; }
        public void SetTranslation(bool translation) { this.translation = translation;}

        //Get
        public string GetKind() { return this.kind; }
        public bool IsTranslation() { return this.translation; }
    }
}    