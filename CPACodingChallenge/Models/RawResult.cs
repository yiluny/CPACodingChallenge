using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPACodingChallenge.Models
{
    /// <summary>
    /// This is for Coding Challenge PART 2 only
    /// See Data folder for details
    /// </summary>
    public class RawResult
    {
        public int Year { get; set; }

        public string Subject { get; set; }

        public bool IsPassed { get; set; }
    }
}