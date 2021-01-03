using System;
using System.Collections.Generic;
using System.Text;

namespace covid_project
{
    class Journal
    {
        private DateTime _infectionTime;
        private DateTime _curedTimed;
        private DateTime _deathTime;

        public Journal() { }

        public DateTime infectionTime
        {
            get
            {
                return _infectionTime;
            }
            set
            {
                _infectionTime = value;
            }
        }
        public DateTime curedTime
        {
            get
            {
                return _curedTimed;
            }
            set
            {
                _curedTimed = value;
            }
        }
        public DateTime deathTime
        {
            get
            {
                return _deathTime;
            }
            set
            {
                _deathTime = value;
            }
        }
         public DateTime generateInfectionTime()
        {
            DateTime infectedAt = DateTime.Now;
            return infectedAt;
        }
        public DateTime generateCuredTime()
        {
            DateTime curedAt = DateTime.Now;
            return curedAt;
        }
        public DateTime generateDeathTime()
        {
            DateTime deadAt = DateTime.Now;
            return deadAt;
        }
    }
}
