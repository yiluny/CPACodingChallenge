using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPACodingChallenge.Models;

namespace CPACodingChallenge.services
{
    public interface IResultService
    {
        List<ProgramResult> GetProgramResults();
    }
}
