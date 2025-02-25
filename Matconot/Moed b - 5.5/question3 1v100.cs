using System;

namespace Moed_b___5._5
{
    public class OneAg100
    {
        private int[] prices;   // סכום הזכייה בכל שאלה. אורך המערך ככמות השאלות המקסימלית במשחק
        private int team;    // גודל הנבחרת הנוכחית.  
        private int total;     // סכום הכסף המצטבר של השחקן    

        public OneAg100(int[] prices) // פעולה בונה
        {
            this.prices = prices;
            this.team = 100;     // גודל הנבחרת הנוכחית.  בהתחלה גודלה 100
            this.total = 0;
        }

        public void Game() // פעולה שקולטת בכל שלב שני מספרים טבעיים ומעדכנת את המשחק בהתאם
        {
            Console.WriteLine("Is the player right?");
            int correct = int.Parse(Console.ReadLine());
            Console.WriteLine("How Many people were wrong?");
            int team_wrong = int.Parse(Console.ReadLine());
            int counter = 0;


            while (counter < this.prices.Length || this.team > 0 || correct == 1)
            {
                this.team -= team_wrong;
                this.total += this.prices[counter] * team_wrong;
                counter++;
                Console.WriteLine("Is the player right?");
                correct = int.Parse(Console.ReadLine());
                Console.WriteLine("How Many people were wrong?");
                team_wrong = int.Parse(Console.ReadLine());
            }

            if (counter == this.prices.Length)
            {
                this.total = 1000000;
                Console.WriteLine("The player won: " + total);
            }

            if (this.team == 0)
                Console.WriteLine("The player won: " + total);

            if (correct == 0)
                Console.WriteLine("The team won: " + total / this.team);
        }
    }
}
