using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SampleWebApiAspNetCore.Models;
using DataAccess;
using System.Data;

namespace SampleWebApiAspNetCore.v2.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsersController : ControllerBase
    {
        IDbConnection connection = null;
        public UsersController(IDbConnection connection)
        {
            this.connection = connection;
        }


        [HttpGet]
        public ActionResult GetUsers()
        {
            return Ok("This is version 2");
        }
    }
}
