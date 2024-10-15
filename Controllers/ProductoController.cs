using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using monher.Models;

namespace monher.Controllers
{
    //[Route("[controller]")]
    public class ProductoController : Controller
    {
        /*private readonly ILogger<ProductoController> _logger;

        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        {
            var productos = new List<Producto>
        {            
            new Producto { Id = 1, Nombre = "Producto 1", Descripcion = "aceite ", Precio = 99, ImagenUrl = "/img/aceite.jpg" },
            new Producto { Id = 2, Nombre = "Producto 2", Descripcion = "arroz ", Precio = 99, ImagenUrl = "/img/arroz.jpg" },
            new Producto { Id = 3, Nombre = "Producto 3", Descripcion = "cereal ", Precio = 99, ImagenUrl = "/img/cereal.png" },
            new Producto { Id = 4, Nombre = "Producto 4", Descripcion = "filtrante", Precio = 99, ImagenUrl = "/img/filtrante.png" },
            new Producto { Id = 5, Nombre = "Producto 5", Descripcion = "gaseosa ", Precio = 99, ImagenUrl = "/img/gaseosa.jpg" },
            new Producto { Id = 6, Nombre = "Producto 6", Descripcion = "harina ", Precio = 99, ImagenUrl = "/img/harina.jpg" },
            new Producto { Id = 7, Nombre = "Producto 7", Descripcion = " leche", Precio = 99, ImagenUrl = "/img/leche.jpg" },
            new Producto { Id = 8, Nombre = "Producto 8", Descripcion = "lechecondensada ", Precio = 99, ImagenUrl = "/img/lechecondensada.jpg" },
            new Producto { Id = 9, Nombre = "Producto 9", Descripcion = "mantequilla ", Precio = 99, ImagenUrl = "/img/mantequilla.jpg" },
            new Producto { Id = 10, Nombre = "Producto 10", Descripcion = "papelhigienico ", Precio = 99, ImagenUrl = "/img/papelhigienico.png" },
            new Producto { Id = 11, Nombre = "Producto 11", Descripcion = "psycho ", Precio = 99, ImagenUrl = "/img/psycho.png" },
            new Producto { Id = 12, Nombre = "Producto 12", Descripcion = "quesoCrema ", Precio = 99, ImagenUrl = "/img/quesoCrema.png" },
            new Producto { Id = 13, Nombre = "Producto 13", Descripcion = "ron ", Precio = 99, ImagenUrl = "/img/ron.jpg" },
            new Producto { Id = 14, Nombre = "Producto 14", Descripcion = "sprite ", Precio = 99, ImagenUrl = "/img/sprite.jpg" },
            new Producto { Id = 15, Nombre = "Producto 15", Descripcion = "yogurt ", Precio = 99, ImagenUrl = "/img/yogurt.jpg" }            
        };
            return View(productos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}