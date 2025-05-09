namespace Template.Application.DTOs.Request;

public class PaginationDTORequest(int page, int pageSize)
{
    public int Page { get; set; } = page;
    public int PageSize { get; set; } = pageSize;
}
