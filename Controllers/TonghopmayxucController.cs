﻿using Api.Models.Tonghopmayxuc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Tonghopmayxuc;
using WebApi.Models.Tonghopthietbi;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TonghopmayxucController : ControllerBase
    {
        private readonly ITonghopmayxucService _tonghopmayxucService;
        public TonghopmayxucController(ITonghopmayxucService tonghopmayxucService)
        {
            _tonghopmayxucService = tonghopmayxucService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTonghopmayxuc()
        {
            var mayxuc = await _tonghopmayxucService.GetTonghopmayxuc();
            if (mayxuc == null)
            {
                return NotFound();
            }
            return Ok(mayxuc);
        }

        [HttpPost]
        public async Task<ActionResult> AddTonghopmayxuc([FromBody] MayxucCreateRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            await _tonghopmayxucService.AddTonghopmayxuc(request);
            return Ok();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult> GetById(int Id)
        {
            var mayxuc = await _tonghopmayxucService.GetById(Id);
            return Ok(mayxuc);
        }

        [HttpGet("DatailById/{Id}")]
        public async Task<ActionResult> GetDetailById(int Id)
        {
            var mayxuc = await _tonghopmayxucService.getDatailById(Id);
            return Ok(mayxuc);
        }


        [HttpPut("update")]
        public async Task<ActionResult> UpdateTonghopmayxuc([FromBody] MayxucUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _tonghopmayxucService.UpdateTonghopmayxuc(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteTonghopmayxuc(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            await _tonghopmayxucService.DeleteTonghopmayxuc(id);
            return Ok();
        }

        [HttpGet("paging")]
        public async Task<IActionResult> Get([FromQuery] GetManagerTonghopMayxucPagingRequest request)
        {
            var query = await _tonghopmayxucService.GetAllPaging(request);
            return Ok(query);

        }



    }
}
