using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CPACodingChallenge.Models;
using CPACodingChallenge.services;

namespace CPACodingChallenge.API
{
    public class ResultController : ApiController
    {
        private readonly IResultService _resultService;
        public ResultController()
        {
            _resultService = new ResultService();
        }

        // GET api/<controller>
        public IHttpActionResult GetResult()
        {
            var results = _resultService.GetProgramResults();
            return Json(results);
        }

    }
}