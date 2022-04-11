using backend.Records.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace backend.Records;

[ApiController]
[Route("/records")]
public class RecordController : ControllerBase
{
    private readonly IRecordService _recordService;

    public RecordController(IRecordService recordService)
    {
        _recordService = recordService;
    }

    [HttpGet]
    public ActionResult<List<RecordDto>> GetAllRecords()
    {
        return Ok(_recordService.GetAllRecords());
    }
    
    [HttpPost]
    public async Task<ActionResult> AddRecord([FromBody]PostRecordDto dto)
    {
        await _recordService.AddRecord(dto);
        return Ok();
    }
}