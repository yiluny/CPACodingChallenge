using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPACodingChallenge.ViewModels;

namespace CPACodingChallenge.Factories
{
    public interface IResultFactory
    {
        List<OutputResult> GetPassedResultsByUrl(string reqUrl);
    }
}
