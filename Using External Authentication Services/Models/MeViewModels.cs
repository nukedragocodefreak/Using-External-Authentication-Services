using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Using_External_Authentication_Services.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}