using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioProducto{

        EntidadProducto AgregarProducto(EntidadProducto producto);
        EntidadProducto EditarProducto(EntidadProducto producto);
        EntidadProducto GetProducto(int IdProducto);
        void EliminarProducto(int IdProducto);
        IEnumerable <EntidadProducto> GetProductos();
    }


}