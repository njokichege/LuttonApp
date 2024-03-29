﻿namespace FimiAppLibrary.Models
{
    public class StudentResultsModel
    {
        public int SessionYearId { get; set; }
        public int ClassId { get; set; }
        public int TermId { get; set; }
        public int ExamTypeId { get; set; }
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public double English { get; set; }
        public double Kiswahili { get; set; }
        public double Mathematics { get; set; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Biology { get; set; }
        public double HistoryGovernment { get; set; }
        public double Cre { get; set; }
        public double HomeScience { get; set; }
        public double Agriculture { get; set; }
        public double BusinessStudies { get; set; }
    }
}
