﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Application.ViewModels
{
    public class AulaViewModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}
