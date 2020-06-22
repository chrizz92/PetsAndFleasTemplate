/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 4ABIF
 *--------------------------------------------------------------
 *              Name: Christian Schadler
 *--------------------------------------------------------------
 * Description:
 *
 *--------------------------------------------------------------
*/

using System;

namespace PetsAndFleas
{
    public class Flea
    {
        //Fields
        private Pet _actualPet;

        private int _amountBites;

        //Properties
        public int AmountBites
        {
            get { return _amountBites; }
        }

        public Pet ActualPet
        {
            get { return _actualPet; }
        }

        //Methods
        public void JumpOnPet(Pet pet)
        {
            _actualPet = pet;
        }

        public int BitePet(int amount)
        {
            int numberOfBites = 0;
            if (_actualPet != null && amount > 0)
            {
                numberOfBites = _actualPet.GetBiten(amount);
                _amountBites += numberOfBites;
            }
            return numberOfBites;
        }

        public override string ToString()
        {
            return "I am a flea.";
        }
    }
}