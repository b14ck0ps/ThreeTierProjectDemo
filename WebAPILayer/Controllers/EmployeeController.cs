using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPILayer.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/employee/get")]
        public HttpResponseMessage Get()
        {
            try
            {
                var employees = BusinessLogicLayer.Services.EmployeeService.GetEmployees();
                return Request.CreateResponse(HttpStatusCode.OK, employees);
            }
            catch (System.Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }
        }
    }
}
