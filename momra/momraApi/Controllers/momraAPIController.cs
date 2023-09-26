using Microsoft.AspNetCore.Mvc;
using momraApi.Data;
using momraApi.Dto;
using momraApi.Models;


namespace momraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class momraAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<accountsDTO> GetAccounts()
        {

            return accountStore.accountList;
        }
        [HttpPost]
         
        public ActionResult<accountsDTO> CreateAccount([FromBody]accountsDTO accountsDTO) 
        { 
            if(accountsDTO == null)
            {
                    return BadRequest(accountsDTO);
            }
            return Ok(accountsDTO);
        }

      //  [Route("/issuesList")]
        [HttpGet]
        public IEnumerable<issuesListDTO> GetissuesList()
        {

            return issuesListStore.issueList;
        }
        [HttpPost]

        public ActionResult<issuesListDTO> CreateIssue([FromBody] issuesListDTO issuesDTO)
        {
            if (issuesDTO == null)
            {
                return BadRequest(issuesDTO);
            }
            return Ok(issuesDTO);
        }
    }

}
