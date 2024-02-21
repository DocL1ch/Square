using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shapes.Api.Models;
using Shapes.Api.Models.Triangle;
using Shapes.Api.Services;
using Shapes.Lib;
using Swashbuckle.AspNetCore.Annotations;

namespace Shapes.Api.Controllers
{
    /// <summary>
    /// Предоставляет конечные точки для проведения операций с фигурами
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ShapesController : ControllerBase
    {
        private readonly CircleService _circle;
        private readonly TriangleService _triangle;

        public ShapesController(CircleService circle, TriangleService triangle)
        {
            _circle = circle;
            _triangle = triangle;
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <param name="triangle">Стороны треугольника</param>
        /// <returns><c>true</c> если является прямоугольным, иначе <c>false</c></returns>
        [HttpGet]
        [Route("triangle/is_rectangular")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(IsTriangleRectangularResponce))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public IActionResult IsTriangleRectangular([FromQuery] TriangleRequest triangle)
        {
            bool isRectangular = default;
            try
            {
                 isRectangular = _triangle.IsRectangular(triangle.A, triangle.B, triangle.C);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(new IsTriangleRectangularResponce() { IsRectangular = isRectangular});
        }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <param name="triangle">Стороны треугольника</param>
        /// <returns>Площадь треугольника</returns>
        [HttpGet]
        [Route("triangle/square")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(SquareResponce))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public IActionResult GetTriangleSquare([FromQuery] TriangleRequest triangle)
        {
            double square = default;
            try
            {
                square = _triangle.GetSquare(triangle.A, triangle.B, triangle.C);
            }catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(new SquareResponce() { Square = square});
        }

        /// <summary>
        /// Площадь окружности
        /// </summary>
        /// <param name="r">Радиус окружности</param>
        /// <returns>Площадь окружности</returns>
        [HttpGet]
        [Route("circle/square")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(SquareResponce))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public IActionResult GetCircleSquare([FromQuery] double r)
        {
            double square = default;
            try
            {
                square = _circle.GetSquare(r);
            }catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(new SquareResponce() { Square = square});
        }
    }
}
