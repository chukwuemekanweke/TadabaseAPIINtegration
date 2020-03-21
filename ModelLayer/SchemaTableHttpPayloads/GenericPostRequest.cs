using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ModelLayer.APIRequests
{

    public class DeleteRequest
    {
        public string TableId { get; set; }
        public string RecordId { get; set; }
    }

    public class EmployeeRequest<T> where T : class
    {
        public string TableId { get; set; }
        public T Data { get; set; }
    }

    public class GenericPostResponse
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public TadabasePostResponse  TadabasePostResponse { get; set; }
    }

    public class TadabasePostResponse
    {
        public string Type { get; set; }
        public string Msg { get; set; }
    }
}
