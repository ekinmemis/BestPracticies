using AutoMapper;
using FC.Core.Models;
using FC.Core.Services;
using FC.Web.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FC.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<CategoryDto>>(await _categoryService.GetAllAsync()));
        }

        public async Task<IActionResult> GetById(int id)
        {
            return View(_mapper.Map<CategoryDto>(await _categoryService.GetByIdAsync(id)));
        }

        public async Task<IActionResult> GetWithProductById(int id)
        {
            return View(_mapper.Map<CategoryWithProductDto>(await _categoryService.GetWithProductsByIdAsync(id)));
        }

        public IActionResult Insert() => View();

        [HttpPost]
        public async Task<IActionResult> Insert(CategoryDto dto)
        {
            _mapper.Map<CategoryDto>(await _categoryService.AddAsync(_mapper.Map<Category>(dto)));
            return RedirectToAction("Index");
        }

        [HttpPut]
        public IActionResult Update(CategoryDto dto)
        {
            _categoryService.Update(_mapper.Map<Category>(dto));
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _categoryService.Remove(_categoryService.GetByIdAsync(id).Result);
            return View();
        }

    }
}
