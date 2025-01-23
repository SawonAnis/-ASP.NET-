using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebApi_Crud.Models;


namespace WebApi_Crud.Controllers
{
    public class CrudApiController : ApiController
    {
        web_api_crud_dbEntities db=new web_api_crud_dbEntities();
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetEmployees()
        {
          List<Employee> list=db.Employees.ToList();
            return Ok(list);    
        }
      
    }
}
