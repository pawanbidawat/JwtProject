﻿using JwtProject.Interfaces;
using JwtProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JwtProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService; 
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public List<Employee> Get()
        {
           var employee = _employeeService.GetEmployeeDetails();
            return employee;

        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            var emp = _employeeService.GetEmployee(id);
            return emp;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public Employee Post([FromBody] Employee value)
        {
           var emp = _employeeService.AddEmployee(value);
            return emp;
        }


        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public Employee Put(int id, [FromBody] Employee value)
        {
            var emp = _employeeService.UpdateEmployee(value);
            return emp;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var emp = _employeeService.DeleteEmployee(id);
            return emp;
        }
    }
}
