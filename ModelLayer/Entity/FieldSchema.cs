using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer.Entity
{
    public class FieldSchema
    {
        public Guid Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public bool IsArray { get; set; }

        public Guid TableSchemaId { get; set; } 
    }
}
