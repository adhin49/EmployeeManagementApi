using EmployeeManagementApi.DTOs.Employee;
using EmployeeManagementApi.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _employeeService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _employeeService.GetByIdAsync(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeCreateDto dto)
        {
            var response = await _employeeService.AddAsync(dto);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            else
            {
                return Ok(response);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, EmployeeUpdateDto dto)
        {
            var response = await _employeeService.UpdateAsync(id, dto);
            if (!response.Success)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _employeeService.DeleteAsync(id);
            if (!response.Success)
            {
                return NotFound(response);
            }
            return Ok(response);

        }
    }
}
