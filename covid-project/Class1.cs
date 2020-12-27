using System;
using System.Collections.Generic;
using System.Text;

namespace covid_project
{
    class Citizen
    {
        //Decalring Varibales
        private string _name;
        private string _cin;
        private string _colorCode;
        private Boolean _isAffected;
        private Boolean _isSuspected;
        private Boolean _isAlive;
        private String _state;

        //contructor
        public Citizen()
        {
        }

        //Getters and setters since everything is private in this case
        public string name
        {
            get {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string cin
        {
            get
            {
                return _cin;
            }
            set
            {
                _cin = value;
            }
        }
        public string colorCode
        {
            get
            {
                return _colorCode;
            }
            set
            {
                _colorCode = value;
            }
        }
        public Boolean isAffected
        {
            get
            {
                return _isAffected;
            }
            set
            {
                _isAffected = value;
            }
        }
        public Boolean isSuspected
        {
            get
            {
                return _isSuspected;
            }
            set
            {
                _isSuspected = value;
            }
        }
        public Boolean isAlive
        {
            get
            {
                return _isAlive;
            }
            set
            {
                _isAlive = value;
            }
        }
        public String state
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        private String generateColorCode()
        {
            if (this.isSuspected)
            {
                //this will be the in-betwwen case 
                colorCode = "orange";
            }else if (this.isAffected)
            {
                //the affected citizens will be marked with red
                colorCode = "red";
            }else if (!this.isAffected)
            {
                //the non-effected will be marked with green
                colorCode = "green";
            }
            return colorCode;
        }
    }
}
