using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartWatch.Data;
using SmartWatch.DTOs;
using SmartWatch.DTOs.ColorWatch;
using SmartWatch.DTOs.DetailWatch;
using SmartWatch.Services;
using SmartWatch.Services.BrandWatch;
using SmartWatch.Services.ColorWatch;
using SmartWatch.Services.DetailWatch;

namespace SmartWatch.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SmartWatchsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDBContext _dBContext;
        private readonly IBrandWatchService _brandWatch;
        private readonly IDetailWatchService _detailWatch;
        private readonly IColorWatchService _colorWatch;

        public SmartWatchsController(
            IMapper mapper, 
            AppDBContext dBContext,
            IBrandWatchService brandWatch,
            IDetailWatchService detailWatch,
            IColorWatchService colorWatch)
        {
            this._mapper = mapper;
            this._dBContext = dBContext;
            this._brandWatch = brandWatch;
            this._detailWatch = detailWatch;
            this._colorWatch = colorWatch;
        }

        [HttpGet("BrandWatch")]
        public async Task<IActionResult> GetBrandWatch()
        {
            var result = await _brandWatch.GetBrandWatch();
            if(result.IsSuccess){
                return Ok(result);
            }else {
                throw new Exception(result.Message);
            }
        }

        [HttpGet("SeartBrandWatch/{id}")]
        public async Task<IActionResult> SeartBrandWatch(int id)
        {
            var result = await _brandWatch.SeartBrandWatch(id);
            if(result.IsSuccess){
                return Ok(result);
            }else {
                throw new Exception(result.Message);
            }
        }

        [HttpPost("CreateBrandWatch")]
        public async Task<IActionResult> CreateBrandWatch(BrandWatchDTO_ToCreate create)
        {
            var result = await _brandWatch.CreateBrandWatch(create);
            if(result.IsSuccess){
                return Ok(result);
            }else {
                throw new Exception(result.Message);
            }
        }

        [HttpPut("UpdateBrandWatch")]
        public async Task<IActionResult> UpdateBrandWatch(int id, BrandWatchDTO_ToUpdate update)
        {
            var result = await _brandWatch.UpdateBrandWatch(id , update);
            if(result.IsSuccess){
                return Ok(result);
            }else {
                throw new Exception(result.Message);
            }
        }

        //DetailWatch


        [HttpGet("GetDetailWatch")]
        public async Task<IActionResult> GetDetailWatch()
        {
            var result = await _detailWatch.GetDetailWatch();
            if(result.IsSuccess){
                return Ok(result);
            }else {
                throw new Exception(result.Message);
            }
        }

        [HttpGet("SearchDetailWatch/{id}")]
        public async Task<IActionResult> SearchDetailWatch(int id)
        {
            var result = await _detailWatch.SearchDetailWatch(id);
            if(result.IsSuccess){
                return Ok(result);
            }else {
                throw new Exception(result.Message);
            }
        }


        [HttpPost("CreateDetailWatch")]
        public async Task<IActionResult> CreateDetailWatch(DetailWatchDTO_ToCreate create)
        {
            var result = await _detailWatch.CreateDetailWatch(create);
            if(result.IsSuccess){
                return Ok(result);
            }else {
                throw new Exception(result.Message);
            }
        }

        //ColorWatch


        [HttpGet("GetColorWatch")]
        public async Task<IActionResult> GetColorWatch()
        {
            var result = await _colorWatch.GetColorWatch();
            if(result.IsSuccess){
                return Ok(result);
            }else {
                throw new Exception(result.Message);
            }
        }

        [HttpGet("SearchColorWatch/{id}")]
        public async Task<IActionResult> SearchColorWatch(int id)
        {
            var result = await _colorWatch.SearchColorWatch(id);
            if(result.IsSuccess){
                return Ok(result);
            }else {
                throw new Exception(result.Message);
            }
        }


        [HttpPost("CreateColorWatch")]
        public async Task<IActionResult> CreateColorWatch(ColorWatchDTO_ToCreate create)
        {
            var result = await _colorWatch.CreateColorWatch(create);
            if(result.IsSuccess){
                return Ok(result);
            }else {
                throw new Exception(result.Message);
            }
        }

    }
}