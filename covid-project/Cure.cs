using System;
using System.Collections.Generic;
using System.Text;

namespace covid_project
{
    class Cure
    {
        private string _name;
        private Boolean _isSafe;
        private Boolean _isWorking;
        static int _peopleCured;

        public Cure()
        {

        }
        //Setters and Getters
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Boolean isSafe
        {
            get
            {
                return _isSafe;
            }
            set
            {
                _isSafe = value;
            }
        }
        public Boolean isWorking
        {
            get
            {
                return _isWorking;
            }
            set
            {
                _isWorking = value;
            }
        }

    }
}
