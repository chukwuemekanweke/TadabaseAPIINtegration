using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer.Entity
{
    public class ObjectFieldSchema
    {
        public Guid Id { get; set; }
        public string Key { get; set; }
        public Guid TableSchemaId { get; set; }
        public IEnumerable<ScalarFieldSchema> SubFields { get; set; }
      
    }
}
