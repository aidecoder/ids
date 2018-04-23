﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{
    [Route("[controller]")]
    [Authorize]
    public class SuperpowersController : ControllerBase
    {
        [HttpGet]
        [Authorize(Policy = "AdminsOnly")]
        public IActionResult Get()
        {
            return new JsonResult("Superpowers!");
        }
    }
}