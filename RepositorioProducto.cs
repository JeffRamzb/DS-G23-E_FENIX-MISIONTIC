using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepositorioProducto : IRepositorioProducto{
        private readonly AppContext appContext;

        public RepositorioVeterinario(AppContext appContextParam){
            this.appContext = appContextParam;
        }

        // CRUD ENTIDAD PRODUCTO

        EntidadProducto IRepositorioProducto.AgregarProducto (EntidadProducto producto){
              
            var veterinarioAgregado = this.appContext.Productos.Add(producto);
            this.appContext.SaveChanges();
            
            return productoAgregado.Entity;
        }

        EntidadProducto IRepositorioProducto.EditarProducto (EntidadProducto productoNuevo){
            
            var productoEncontrado = this.appContext.Productos.FirstOrDefault( p => p.Id == productoNuevo.Id);

            if(productoEncontrado != null){
                productoEncontrado.NombreProducto = productoNuevo.NombreProducto;
                productoEncontrado.DosisFormulada = productoNuevo.DosisFormulada;
                productoEncontrado.UnidadMedida = productoNuevo.UnidadMedida;
                productoEncontrado.Formula = productoNuevo.Formula;

                this.appContext.SaveChanges();
                return productoEncontrado;
            }else{
                return null;
            }

        }

        EntidadProducto IRepositorioProducto.GetVeterinario(int IdProducto){
            return this.appContext.Productos.FirstOrDefault( p => p.Id == IdProducto);
            
        }

        void IRepositorioProducto.EliminarProducto(int IdProducto){

            var productoEncontrado = this.appContext.Productos.FirstOrDefault( p => p.Id == IdProducto);            
            if(veterinarioEncontrado != null) {
                this.appContext.Productos.Remove(productoEncontrado);
                this.appContext.SaveChanges();
            }

        }

        IEnumerable <EntidadProducto> IRepositorioProducto.GetProductos(){
            return null;
        }

    }

}