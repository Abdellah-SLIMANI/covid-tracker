using System;
using System.Collections.Generic;
using System.Text;

namespace covid_project
{
    class Person
    {
        //Decalring Varibales
        private string _personName;
        private string _cin;
        private string _colorCode;
        private int _age;
        private Boolean _isAffected;
        private Boolean _isSuspected;
        private Boolean _isAlive;

        //contructor
        public Person(string name, string cin, int age, string colorCode = "")
        {
            _personName = name;
            _cin = cin;
            _age = age;
            _colorCode = colorCode;
        }

        //Getters and setters since everything is private in this case
        public string personName
        {
            get
            {
                return _personName;
            }
            set
            {
                _personName = value;
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

        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
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

        public String generateColorCode()
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

        public void personTestResult(Test tst, Journal jrnl)
        {
            if (tst.testResult)
            {
                this.isAffected = true;
            }
            jrnl.infectionTime = tst.testTime;
            generateColorCode();
        }
    }
}
