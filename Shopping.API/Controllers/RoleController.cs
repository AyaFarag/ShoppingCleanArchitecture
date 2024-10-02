using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopping.Application.Contracts.Infrastructure.Interfaces;
using Shopping.Application.DTOs;

namespace Shopping.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }


        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _roleService.GetAllRolesAsync();
            return Ok(roles);
        }

        [HttpPost("CreateRole")]
        public async Task<IActionResult> CreateRole([FromBody] RoleDto roleDto)
        {
            await _roleService.CreateRoleAsync(roleDto);
            return Ok();
        }

        [HttpPost("{roleId}/permissions")]
        public async Task<IActionResult> AssignPermissionToRole(int roleId, [FromBody] PermissionDto permissionDto)
        {
            await _roleService.AssignPermissionToRole(roleId, permissionDto.PermissionName);
            return Ok();
        }


    }
}
