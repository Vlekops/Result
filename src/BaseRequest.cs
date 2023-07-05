using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vlekops.Result
{
    public class QueryRequest
    {
        public string Query { get; set; }
    }

    public class ListRequest
    {
        public List<FilterRequest> Filter { get; set; }

        [Required]
        public SortRequest Sort { get; set; }
        public int? Start { get; set; }
        public int? Length { get; set; }

        public ListRequest()
        {
            Filter = new List<FilterRequest>();
        }
    }
    public class FilterRequest
    {
        public string Field { get; set; }
        public string Search { get; set; }

        public FilterRequest()
        {

        }

        public FilterRequest(string field, string search)
        {
            Field = field;
            Search = search;
        }
    }

    public class SortRequest
    {
        public string Field { get; set; }
        public SortTypeEnum Type { get; set; }

        public SortRequest()
        {

        }

        public SortRequest(string field, SortTypeEnum type)
        {
            Field = field;
            Type = type;
        }
    }

    public enum SortTypeEnum
    {
        ASC,
        DESC
    }

    public class AddRequest<T>
    {
        public T Data { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get { return DateTime.Now; } }
    }

    public class UpdateRequest<T>
    {
        public T Data { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get { return DateTime.Now; } }
    }
}
