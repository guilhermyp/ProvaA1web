
using api_avaliacao.Data;
using api_avaliacao.Data.Interfaces;
using api_avaliacao.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_avaliacao.Controllers;

[ApiController]
[Authorize]
[Route("api/comentario")]
public class ComentarioController : ControllerBase
{
    private readonly IComentarioRepository _comentarioRepository;
    public ComentarioController(IComentarioRepository comentarioRepository)
    {
        comentarioRepository = comentarioRepository;
    }

    [HttpGet("listar")]
    public IActionResult Listar()
    {
        return Ok(_comentarioRepository.Listar());
    }

    [HttpPost("cadastrar")]
    public IActionResult Cadastrar([FromBody] Comentario comentario)
    {
        _comentarioRepository.Cadastrar(comentario);
        return Created("", comentario);
    }

}