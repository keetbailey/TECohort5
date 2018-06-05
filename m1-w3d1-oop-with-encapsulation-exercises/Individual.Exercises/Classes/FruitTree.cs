using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        private string typeOfFruit;
        private int piecesOfFruitLeft;

        public int PiecesOfFruitLeft
        {
            get
            {
                return piecesOfFruitLeft;
            }
            private set
            {
                piecesOfFruitLeft = value;
            }
        }
        public string TypeOfFruit
        {
            get
            {
                return typeOfFruit;
            }
        }
        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            piecesOfFruitLeft = startingPiecesOfFruit;
            this.typeOfFruit = typeOfFruit;
        }
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if (piecesOfFruitLeft - numberOfPiecesToRemove >= 0)
            {
                piecesOfFruitLeft -= numberOfPiecesToRemove;
                return true;
            }

            return false;
        }
    }
}
