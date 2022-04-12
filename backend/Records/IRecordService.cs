using backend.Records.Dtos;
using CSharpFunctionalExtensions;

namespace backend.Records;

public interface IRecordService
{
    public IReadOnlyList<RecordDto> GetAllRecords();

    public Task<Result> AddRecord(PostRecordDto dto);
}