using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelLayer.Entity
{
    public class ScalarFieldSchema
    {
        public Guid Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public Guid ObjectFieldSchemaId { get; set; }

        [ForeignKey("ObjectFieldSchemaId")]
        public virtual ObjectFieldSchema ObjectFieldSchema{get; set;}

    }
}
