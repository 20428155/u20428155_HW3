﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u20428155_HW3.Models
{
    public class FileModel
    {
        [Display(Name = "File Name")]
        public string FileName { get; set; }
    }
}