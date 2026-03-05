using Microsoft.AspNetCore.Mvc;
using AcademicPerformanceAPI.DTO;


namespace AcademicPerformanceAPI.Controllers
{

        [ApiController]
        [Route("api/controller")]
        public class AcademicController : ControllerBase
        {

            [HttpPost("Evaluate")]
            public IActionResult Evaluate(AcademicDToRequest request)
            {
            if( request.AssignmentMark < 0 || request.AssignmentMark > 100 ||
                request.TestMark < 0 || request.TestMark > 100 ||
                request.ExamMark < 0 || request.ExamMark > 100)
            {
                return BadRequest("Marks must be between 0 and 100.");
            }

            double finalMark = (request.AssignmentMark * 0.3) + (request.TestMark * 0.3) + (request.ExamMark * 0.4);
        
            finalMark = Math.Round(finalMark);

            string result;

            if (finalMark >= 75)
            {
                result = "Pass with Distinction";
            }
            else if (finalMark >= 50)
            {
                result = "Pass";
            }
            else
            {
                result = "Fail";
            }

            var response = new AcademicDToResult
            {
                Id = request.Id,
                StudentName = request.StudentName,
                ModuleCode = request.ModuleCode,
                FinalMark = finalMark,
                Result = result,
                Message = "Evaluation completed ."
            };
            return Ok(response);
        }
    }
}