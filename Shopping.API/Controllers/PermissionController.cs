﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Shopping.Application.Contracts.Infrastructure.Interfaces;

namespace Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionService;

        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }



        [HttpGet]
        public IActionResult GetPermissions(int ModuleID)
        {
            var permissions = _permissionService.GetPermissionsForModuleAsync(ModuleID);
            return Ok(permissions);
        }
    }
}