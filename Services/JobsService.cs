using System.Collections.Generic;
using greg_control.Models;
using greg_control.db;
using System;
namespace greg_control.Services
{
    public class JobsService
    {
        public IEnumerable<Job> Get()
        {
            return FakeDb.Jobs;
        }

        public Job GetOne(string id)
        {
            Job found = FakeDb.Jobs.Find(j => j.id == id);
            if (found == null)
            {
                throw new Exception("BAD ID");
            }
            return found;
        }

        public Job Create(Job newJob)
        {
            FakeDb.Jobs.Add(newJob);
            return newJob;
        }

        public Job Edit(string id, Job bodyJob)
        {
            Job foundJob = FakeDb.Jobs.Find(h => h.id == id);
                if (foundJob == null)
                {
                    throw new Exception("BAD ID");
                }
                if(bodyJob.company != null) 
                { 
                   foundJob.company = bodyJob.company; 
                }
                if(bodyJob.jobTitle != null)
                {
                    foundJob.jobTitle = bodyJob.jobTitle;
                }
                if(bodyJob.hours  != null)
                {
                    foundJob.hours = bodyJob.hours;
                }
                if(bodyJob.rate != null)
                {
                   foundJob.rate = bodyJob.rate;
                }
                if(bodyJob.description != null)
                {
                    foundJob.description = bodyJob.description;
                }
                int index = FakeDb.Jobs.FindIndex(c => c.id == id);
                foundJob.id = id;
                FakeDb.Jobs[index] = foundJob;
                return foundJob;
        }

        public string Delete(string id)
        {
            Job found = FakeDb.Jobs.Find(j => j.id == id);
            if (found == null)
            {
                throw new Exception("BAD ID");
            }
            FakeDb.Jobs.Remove(found);
            return "Job Gone Boss.";
        }
    }
}