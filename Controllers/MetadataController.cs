using Eagle.API.Services.Interfaces;
using Eagle.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace Eagle.API.Controllers
{

    [Route("metadata")]
    [ApiController]
    public class MetadataController : ControllerBase
    {
        private IMetadataService metadataService;

        public MetadataController(IMetadataService metadataService)
        {
            this.metadataService = metadataService;
        }


        #region GET


        [HttpGet("{movieId}")]
        public async Task<ActionResult<List<MetadataViewModel>>> GetMovieMetadata([FromRoute] int movieId)
        {
            return Ok(await metadataService.GetMetaData(movieId).ConfigureAwait(false));
        }



        #endregion


        #region POST

        [HttpPost]
        public async Task<ActionResult<MetadataViewModel>> CreateMetadate([FromBody] MetadataViewModel model)
        {
            return Ok(await metadataService.CreateMetaData(model).ConfigureAwait(false));
        }



        #endregion


        #region PUT



        #endregion


        #region DELETE


        #endregion





    }
}
