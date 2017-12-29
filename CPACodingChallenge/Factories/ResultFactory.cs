using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using CPACodingChallenge.Models;
using CPACodingChallenge.ViewModels;
using Newtonsoft.Json;

namespace CPACodingChallenge.Factories
{
    public class ResultFactory : IResultFactory
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<OutputResult> GetPassedResultsByUrl(string reqUrl)
        {
            //Use webclient to read raw data
            var response = getWebClientResponse(reqUrl);

            //Convert to a list object
            List<ProgramResult> programResults = JsonConvert.DeserializeObject<List<ProgramResult>>(response);

            //Process and get the passed results
            var output = programResults.SelectMany(o => o.Results.Where(s=> s.Grade == "PASS")
                                                                 .Select(s=> new OutputResult() {Subject = o.Subject,PassedYear = s.Year}))
                                       .OrderByDescending(o => o.PassedYear)
                                       .ToList();

            return output;
        }

        private string getWebClientResponse(string reqUrl)
        {
            WebClient request = new WebClient();
            var response = request.DownloadString(reqUrl);
            return response;
        }
    }
}