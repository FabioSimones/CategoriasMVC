﻿using CategoriasMVC.Models;

namespace CategoriasMVC.Services
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaViewModel>> GetCategorias();
        Task<CategoriaViewModel> GetCategoriaPorId(int id);
        Task<CategoriaViewModel> CriaCategoria(CategoriaViewModel categoriaVM);
        Task<bool> DeleteCategoria(int id);
        Task<bool> AtualizaCategoria(int id, CategoriaViewModel categoriaVM);
    }
}
