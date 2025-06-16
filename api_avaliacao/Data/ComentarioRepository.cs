using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using api_avaliacao.Models;
using api_avaliacao.Data.Interfaces;

namespace api_avaliacao.Data;

public class ComentarioRepository : IComentarioRepository
{
    private readonly AppDataContext _context;
    public ComentarioRepository(AppDataContext context)
    {
        _context = context;
    }

    public void Cadastrar(Comentario comentario)
    {
        _context.Comentarios.Add(comentario);
        _context.SaveChanges();
    }

    public List<Comentario> Listar()
    {
        return _context.Comentarios.ToList();
    }
}