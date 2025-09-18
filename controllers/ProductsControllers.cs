using Microsoft.AspNetCore.Mvc;
using LojaOnline.Models;

namespace LojaOnline.Controllers;

//[ApiController] indica que essa classe é uma API, com validações automáticas.
//[Route("api/[controller]")] define a rota base: "api/products"
[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    //Lista mockada de produtos(por enquanto só em memória)
    private static readonly List<Product> _produtos = new()
    {
        new Product { id = 1, Name = "Camiseta", Description = "Camiseta 100% algodão", Price = 59.90m, Stock = 12},
        new Product { id = 2, Name = "Tênis", Description = "Tênis esportivo de corrida", Price = 199.90m, Stock = 7},
        new Product { id = 3, Name = "Caneca", Description = "Caneca cerâmica 300ml", Price = 29.90m, Stock = 25}
    };

    //GET: api/products
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        return Ok(_produtos); // retorna status 200 + JSON com lista
    }

    // GET api/products/{id}
    [HttpGet("{id}")]
    public ActionResult<Product> GetById(int id)
    {
        var produto = _produtos.FirstOrDefault(p => p.id == id);
        if (produto == null)
            return NotFound(); // retorna 404 se não achar 
        return Ok(produto);
    }
}