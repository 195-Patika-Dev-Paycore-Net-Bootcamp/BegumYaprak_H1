using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayCore__HW1.NewFolder;

namespace PayCore__HW1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : ControllerBase
    {


        [HttpGet]
        public ActionResult<InterestResultModel> InterestCalculation([FromQuery] InterestModel interestModel)
        {
            InterestResultModel interestResultModel = new InterestResultModel();




            if (!ModelState.IsValid)
            {

               return BadRequest(ModelState);

            }
            
            
            var principal = interestModel.Principal;
            var interestAmount = interestModel.InterestAmount;
            var expiry = interestModel.Expiry;


            interestResultModel.InterestAmount = interestAmount;

            interestResultModel.TotalBalance = principal * Math.Pow((1 + interestAmount), expiry);





            return Ok(interestResultModel);

           
        }


    }

}


