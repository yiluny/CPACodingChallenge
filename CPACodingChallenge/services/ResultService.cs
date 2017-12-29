using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CPACodingChallenge.Data;
using CPACodingChallenge.Models;

namespace CPACodingChallenge.services
{
    public class ResultService : IResultService
    {
        public List<ProgramResult> GetProgramResults()
        {
            List<ProgramResult> output = new List<ProgramResult>();
            var rawResultsList = RawData.Data.GroupBy(o => o.Subject).ToList();

            foreach (var results in rawResultsList)
            {
                ProgramResult subjectResult = new ProgramResult()
                {
                    Subject = results.First().Subject,
                    Results = results.Select(o => new Result()
                    {
                        Year = o.Year,
                        Grade = o.IsPassed ? "PASS" : "FAIL"
                    }).ToList()
                };
                output.Add(subjectResult);
            }
            return output;
        }
    }
}