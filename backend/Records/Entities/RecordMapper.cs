using backend.Records.Dtos;

namespace backend.Records.Entities;

public static class RecordMapper
{
    public static RecordDto toRecordDto(this Record record)
    {
        return new RecordDto
        {
            Amount = record.Amount,
            Description = record.Description,
            Date = record.Date,
            Id = record.Id,
            CreditId = record.Credit.Id,
            DebitId = record.Debit.Id
        };
    }
}