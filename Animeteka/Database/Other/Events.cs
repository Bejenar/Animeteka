using System;
using System.Collections.Generic;

namespace Animeteka
{
    public partial class Events
    {
        public int Id { get; set; }
        public int RecordId { get; set; }
        public int EventTypeId { get; set; }
        public DateTimeOffset EventDate { get; set; }
        public string ColumnName { get; set; }
        public string OriginalValue { get; set; }
        public string NewValue { get; set; }
        public int TenantId { get; set; }
        public int AppUserId { get; set; }
        public int TableName { get; set; }
    }
}
