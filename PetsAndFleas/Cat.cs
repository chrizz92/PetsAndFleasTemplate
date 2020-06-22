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
    public class Cat : Pet
    {
        //Fields
        private int _treesClimbed;

        private bool _isOnTree;

        //Properties
        public int TreesClimbed
        {
            get { return _treesClimbed; }
        }

        //Methods
        public bool ClimbOnTree()
        {
            bool success = true;
            if (_isOnTree)
            {
                success = false;
            }
            else
            {
                _treesClimbed++;
                _isOnTree = true;
            }
            return success;
        }

        public bool ClimbDown()
        {
            bool success = false;
            if (_isOnTree)
            {
                success = true;
                _isOnTree = false;
            }
            return success;
        }

        public override string ToString()
        {
            return "I am a cat.";
        }
    }
}