using ElectricBike.Application.Core.Services.Manufacturers;
using Microsoft.AspNetCore.Mvc;

namespace ElectricBike.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ManufacturerController : ControllerBase
{
    private readonly ILogger<ManufacturerController> _logger;
    private readonly IManufacturerService _service;

    public ManufacturerController(ILogger<ManufacturerController> logger, IManufacturerService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpPost(nameof(Create))]
    public async Task<ManufacturerDto> Create(ManufacturerDto dto)
    {
        _logger.Log(LogLevel.Information, $"{nameof(ManufacturerController)} => {nameof(Create)}");
        return await _service.Create(dto).ConfigureAwait(false);
    }
    
    [HttpGet(nameof(GetAll))]
    public async Task<IEnumerable<ManufacturerDto>> GetAll()
    {
        _logger.Log(LogLevel.Information, $"{nameof(ManufacturerController)} => {nameof(GetAll)}");
        return await _service.GetAll().ConfigureAwait(false);
    }

    [HttpGet($"{nameof(GetById)}/"+"{id}")]
    public async Task<ManufacturerDto> GetById(Guid id)
    {
        _logger.Log(LogLevel.Information, $"{nameof(ManufacturerController)} => {nameof(GetById)} => {id}");
        return await _service.GetById(id).ConfigureAwait(false);
    }
   
    [HttpPut(nameof(Update))]
    public async Task<bool> Update(ManufacturerDto dto)
    {
        _logger.Log(LogLevel.Information, $"{nameof(ManufacturerController)} => {nameof(Update)}");
        return await _service.Update(dto).ConfigureAwait(false);
    }
    
    [HttpDelete($"{nameof(Delete)}"+"/{id}")]
    public async Task<bool> Delete(Guid id)
    {
        _logger.Log(LogLevel.Information, $"{nameof(ManufacturerController)} => {nameof(Delete)} => {id}");
        return await _service.Delete(id).ConfigureAwait(false);
    }
}