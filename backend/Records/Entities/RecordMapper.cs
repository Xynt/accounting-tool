using backend.Records.Dtos;

namespace backend.Records.Entities;

public static class RecordMapper
{
    public static RecordDto ToRecordDto(this Record record)
    {
        return new RecordDto
        {
            Amount = record.Amount,
            Description = record.Description,
            Date = record.Date,
            Id = record.Id,
            CreditId = record.CreditId,
            DebitId = record.DebitId
        };
    }
}