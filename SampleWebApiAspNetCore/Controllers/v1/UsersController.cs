using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SampleWebApiAspNetCore.Models;
using DataAccess;
using System.Data;

namespace SampleWebApiAspNetCore.v1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsersController : ControllerBase
    {
        IDbConnection connection = null;
        public UsersController(IDbConnection connection)
        {
            this.connection = connection;
        }

        [Route("Users")]
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            try
            {
                SqlDataAccess sq = new SqlDataAccess(connection);
                List<User> userList = sq.GetUserModel();
                return Ok(userList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
