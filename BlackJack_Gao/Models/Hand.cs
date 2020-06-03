using System;
using System.Collections.Generic;

namespace BlackJack.CardGameFramework
{
    public class Hand
    {
        // Creates a list of cards
        protected List<Card> cards = new List<Card>();
        public int NumCards { get { return cards.Count; } }
        public List<Card> Cards { get { return cards; } }

        /// Checks to see if the hand contains a card of a certain face value
        public bool ContainsCard(FaceValue item)
        {
            foreach (Card c in cards)
            {
                if (c.FaceVal == item)
                {
                    return true;
                }
            }
            return false;
        }
    }

    //Creates a BlackJack hand that inherits from class hand
    public class BlackJackHand : Hand
    {
        // This method compares two BlackJack hands
        public int CompareFaceValue(object otherHand)
        {
            BlackJackHand aHand = otherHand as BlackJackHand;
            if (aHand != null)
            {
                return this.GetSumOfHand().CompareTo(aHand.GetSumOfHand());
            }
            else
            {
                throw new ArgumentException("Argument is not a Hand");
            }
        }

        // Gets the total value of a hand from BlackJack values
         public int GetSumOfHand()
        {
            int val = 0;
            int numAces = 0;

            foreach (Card c in cards)
            {
                if (c.FaceVal == FaceValue.Ace)
                {
                    numAces++;
                    val += 11;
                }
                else if (c.FaceVal == FaceValue.Jack || c.FaceVal == FaceValue.Queen || c.FaceVal == FaceValue.King)
                {
                    val += 10;
                }
                else
                {
                    val += (int)c.FaceVal;
                }
            }

            while (val > 21 && numAces > 0)
            {
                val -= 10;
                numAces--;
            }

            return val;
        }
    }
}
