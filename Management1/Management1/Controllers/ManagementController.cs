using Management1.Models;
using Management1.Processor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Management1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ManagementController : ControllerBase
    {
        private readonly IDataProcessor _data;
        private readonly ILogger<ManagementController> _logger;
        public ManagementController(IDataProcessor data, ILogger<ManagementController> logger)
        {
            _data =data;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GetPatientDetails()
        {
            List<ViewPatient>lstpt= _data.GetPatientList();
            return Ok(lstpt);
        }
        [HttpPost]
        public IActionResult ScheduleAppointment(ScheduleAppoinment req)
        {
            bool response = false;
            try
            {
                response= _data.ScheduleAppointment(req);
            }catch(Exception ex)
            {
                _logger.LogError("Exception occured in:", ex);
               
            }
            return response ? Ok(response) : BadRequest();
        }

        [HttpPost]
        public IActionResult ResponseReport(ResponseReport req)
        {
            bool response = false;
            try
            {
                response = _data.ReportResponse(req);
            }
            catch (Exception ex)
            {
               _logger.LogError("Exception occured in:", ex);
            }
            return response ? Ok(response) : BadRequest();
        }
    }
}
