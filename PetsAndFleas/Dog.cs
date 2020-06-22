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
    public class Dog : Pet
    {
        //Fields
        private int _huntedAnimals = 0;

        private DateTime _lastHuntTime;

        //Properties
        public int HuntedAnimals
        {
            get { return _huntedAnimals; }
        }

        //Methods
        public bool HuntAnimal()
        {
            bool success = true;
            if (_lastHuntTime == null || _lastHuntTime < DateTime.Now.AddSeconds(-1.0))
            {
                _huntedAnimals++;
                _lastHuntTime = DateTime.Now;
            }
            else
            {
                success = false;
            }
            return success;
        }

        public override string ToString()
        {
            return "I am a dog.";
        }
    }
}