using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace tracking.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}