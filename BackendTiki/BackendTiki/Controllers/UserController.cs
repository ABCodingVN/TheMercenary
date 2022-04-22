﻿using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;
        private readonly IConfiguration _configuration;
        public UserController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new UserService(configuration, context);
        }
        [Route("users")]
        [HttpGet]
        public JsonResult GetOrders()
        {
            List<User> users = _service.GetUsers();
            return users.Count == 0 ? new JsonResult(new { success = "fails" }) : new JsonResult(users);
        }
        [Route("get/{id}")]
        [HttpGet]
        public JsonResult GetById(string id)
        {
            User user = _service.GetById(id);
            return user == null ? new JsonResult(new { success = "fails" }) : new JsonResult(user);
        }
    }
}
