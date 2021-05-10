using System;
using System.Collections.Generic;
using System.Text;

namespace A2SDD
{
    //ESSENTIAL

    class Researcher
    {
        public int ID { get; set; }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public string Title { get; set; }

        public string School { get; set; }

        public string Campus { get; set; }

        public string Email { get; set; }

        public string Photo { get; set; }



        Position getCurrentJob(Researcher r)
        {
            //TODO
            Position p;
            return p;
        }

        String CurrentJobTitle(Researcher r)
        {
            //TODO
            return "Current Job Title";
        }

        DateTime CurrentJobStart(Researcher r)
        {
            //TODO
            DateTime today = DateTime.Today;
            return today;
        }

        Position GetEarliestJob(Researcher r)
        {
            //TODO
            Position p;
            return p;
        }

        DateTime EarliestStart(Researcher r)
        {
            //TODO
            return DateTime.Now;
        }

        // float ten

    }
}
