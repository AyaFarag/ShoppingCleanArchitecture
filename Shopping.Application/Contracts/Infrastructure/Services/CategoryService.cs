using AutoMapper;
using Shopping.Application.Contracts.Infrastructure.Interfaces;
using Shopping.Application.Contracts.Infrastructure.Interfaces.Repository;
using Shopping.Application.DTOs;
using Shopping.Domain.Entities;


namespace Shopping.Application.Contracts.Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _categoryRepository.GetAllAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _categoryRepository.GetByIdAsync(id);
        }

        public async Task<Category> CreateCategoryAsync(CategoryDTO categoryDTO)
        {
            // Automapper category => categoryDTO
            var catdto = _mapper.Map<Category>(categoryDTO);
            return await _categoryRepository.AddAsync(catdto);
        }

        public async Task<Category> UpdateCategoryAsync(CategoryDTO categoryDTO)
        {
            var catdto = _mapper.Map<Category>(categoryDTO);
            return await _categoryRepository.UpdateAsync(catdto);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }
    }
}
