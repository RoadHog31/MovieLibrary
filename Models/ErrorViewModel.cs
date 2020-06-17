using System;

namespace MovieLibrary.Models
{
    //Business logic belongs in the model. 
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
