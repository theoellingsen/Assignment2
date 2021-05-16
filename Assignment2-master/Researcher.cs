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
            Position p = new Position();
            p = p.Title;
            Console.WriteLine("The reseacher's current job is: ", p);
            return p;
        }

        String CurrentJobTitle(Researcher r)
        {
            string n;
            getCurrentJob(r);
            n = r.Title;
            Console.WriteLine("Current job title: ", n);
            return n;
        }

        DateTime CurrentJobStart(Researcher r)
        {
            Position p = new Position();
            DateTime D = new DateTime();
            D = p.Start.Date;
            Console.WriteLine("Current job start date is: ", D);
            return D;
        }

        Position GetEarliestJob(Researcher r)
        {
            Position p = new Position();
            p = p.Start.level;
            Console.WriteLine("Earliest job is: ", p);
            return p;
        }

        DateTime EarliestStart(Researcher r)
        {
            DateTime D = new DateTime();
            Position p = new Position();
            D = p.Start.Date;
            Console.WriteLine("Earliest start date: ", D)
            return D;
        }

        float Tenure(Researcher r)
        {
            CurrentJobStart(r);
            DateTime D = new DateTime();
            D = DateTime.Now - DateTime.r;
            return D;
        }
        int PublicationsCount(Researcher r)
        {
            //call a function that returns all the publications from that researcher and find the total count. 
            return;
        }
    }
