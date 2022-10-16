using System;

namespace KSBlazor.Components;
partial class Pagination
{
    
}

public class PagingInfo
{
    public int TotalItems { get; set; }
    public int PageSize { get; set; }
    public int CurrentPage { get; set; }
    public string? SearchTerm { get; set; }
    public string? OrderByProperty { get; set; }
    public bool ShowPagination { get; set; }
    public bool? Descending { get; set; }
    public int TotalPages
    {
        get
        {
            return (int)Math.Ceiling((decimal)TotalItems /
                                     PageSize);
        }
    }
}