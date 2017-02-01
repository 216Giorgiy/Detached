﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Detached.EntityFramework.Tests.Plugins.Pagination
{
    public class PaginationEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}