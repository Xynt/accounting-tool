using backend.Records.Dtos;

namespace backend.Records;

public interface IRecordService
{
    public IReadOnlyList<RecordDto> GetAllRecords();

    public Task AddRecord(PostRecordDto dto);
}