using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CPACodingChallenge.Models;

namespace CPACodingChallenge.Data
{
    public class RawData
    {
        public static List<RawResult> Data = new List<RawResult>()
        {
            new RawResult() {Year = 2015, Subject = "Strategic Management Accounting", IsPassed = false},
            new RawResult() {Year = 2016, Subject = "Strategic Management Accounting", IsPassed = true},

            new RawResult() {Year = 2015, Subject = "Financial Reporting", IsPassed = false},
            new RawResult() {Year = 2016, Subject = "Financial Reporting", IsPassed = true},

            new RawResult() {Year = 2016, Subject = "Advanced Taxation", IsPassed = true},

            new RawResult() {Year = 2015, Subject = "Financial Risk Management", IsPassed = true},

            new RawResult() {Year = 2015, Subject = "Advanced Audit and Assurance", IsPassed = true}
        };
    }
}