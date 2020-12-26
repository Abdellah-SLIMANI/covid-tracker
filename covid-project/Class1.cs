using System;
using System.Collections.Generic;
using System.Text;

namespace covid_project
{
    class Citizen
    {
        private string _name;
        private string _cin;
        private string _colorCode;
        private Boolean _isAffected;
        private Boolean _isSuspected;
        public Citizen(string name ,string cin, string colorCode)
        {
            _name = name;
            _cin = cin;
            _colorCode = colorCode;
        }

        //Getters and setters since everything is private in this case



        private void state()
        {

        }
         private Boolean isAlive()
        {
            return false;
        }

        private String generateColorCode()
        {
            return "red";
        }
    }
}
