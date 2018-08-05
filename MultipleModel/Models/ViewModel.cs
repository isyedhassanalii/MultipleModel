using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MultipleModel.Models
{
    public class ViewModel
    {
        public IEnumerable<ModelA> ModelAs { get; set; }
        public IEnumerable<ModelB> ModelBs { get; set; }
    }
}