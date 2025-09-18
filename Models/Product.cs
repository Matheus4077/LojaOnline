namespace LojaOnline.Models;

public class Product
{
    public int id { get; set; }                     //identificador único
    public string Name { get; set; } = "";          //nome do produto
    public string Description { get; set; } = "";   //descrição curta            
    public decimal Price { get; set; }              //preço em decimal (ideal para dinheiro)
    public int Stock { get; set; }                  //estoque disponivel
    public string? ImageUrl { get; set; }           //link da imagem (pode ser null)
}