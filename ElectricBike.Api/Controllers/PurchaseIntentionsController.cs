using ElectricBike.Application.Core.Services.PurchaseIntentions;
using ElectricBike.Application.Core.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace ElectricBike.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PurchaseIntentionsController : ControllerBase
{
    private readonly ILogger<PurchaseIntentionsController> _logger;
    private readonly IPurchaseIntentionService _service;
    private readonly IUserService _userService;

    public PurchaseIntentionsController(ILogger<PurchaseIntentionsController> logger, IPurchaseIntentionService service, IUserService userService)
    {
        _logger = logger;
        _service = service;
        _userService = userService;
    }

    [HttpPost(nameof(Create))]
    public async Task<PurchaseIntentionDto> Create(PurchaseIntentionDto dto)
    {
        _logger.Log(LogLevel.Information, $"{nameof(PurchaseIntentionsController)} => {nameof(Create)}");
        return await _service.Create(dto).ConfigureAwait(false);
    }
    
    [HttpGet(nameof(GetAll))]
    public async Task<IEnumerable<PurchaseIntentionDto>> GetAll()
    {
        _logger.Log(LogLevel.Information, $"{nameof(PurchaseIntentionsController)} => {nameof(GetAll)}");
        var intentions = await _service.GetAll().ConfigureAwait(false);
        foreach (var intention in intentions)
        {
            intention.User = await _userService.GetById(intention.UserId).ConfigureAwait(false);
        }
        return intentions;
    }

    [HttpGet($"{nameof(GetById)}/"+"{id}")]
    public async Task<PurchaseIntentionDto> GetById(Guid id)
    {
        _logger.Log(LogLevel.Information, $"{nameof(PurchaseIntentionsController)} => {nameof(GetById)} => {id}");
        return await _service.GetById(id).ConfigureAwait(false);
    }
   
    [HttpPut(nameof(Update))]
    public async Task<bool> Update(PurchaseIntentionDto dto)
    {
        _logger.Log(LogLevel.Information, $"{nameof(PurchaseIntentionsController)} => {nameof(Update)}");
        return await _service.Update(dto).ConfigureAwait(false);
    }
    
    [HttpDelete($"{nameof(Delete)}"+"/{id}")]
    public async Task<bool> Delete(Guid id)
    {
        _logger.Log(LogLevel.Information, $"{nameof(PurchaseIntentionsController)} => {nameof(Delete)} => {id}");
        return await _service.Delete(id).ConfigureAwait(false);
    }
}