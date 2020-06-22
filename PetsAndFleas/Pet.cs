/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class:
 *--------------------------------------------------------------
 *              Name:
 *--------------------------------------------------------------
 * Description:
 *
 *--------------------------------------------------------------
*/

using System;

namespace PetsAndFleas
{
    public abstract class Pet
    {
        static private int _lastPetId = 0;

        //Fields
        private int _petId;

        private int _remainingBites = 100;

        //Properties
        static public int LastPetID
        {
            get { return _lastPetId; }
        }

        public int PetID
        {
            get { return _petId; }
        }

        public int RemainingBites
        {
            get { return _remainingBites; }
        }

        //Constructors
        public Pet()
        {
            _lastPetId++;
            _petId = _lastPetId;
        }

        //Methods
        public int GetBiten(int amount)
        {
            if (amount < 0)
            {
                amount = 0;
            }
            else if (amount < _remainingBites)
            {
                _remainingBites = _remainingBites - amount; ;
            }
            else
            {
                amount = _remainingBites;
                _remainingBites = 0;
            }

            return amount;
        }
    }
}