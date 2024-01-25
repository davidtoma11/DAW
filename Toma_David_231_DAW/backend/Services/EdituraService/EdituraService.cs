using AutoMapper;
using backend.Models;
using backend.Models.DTOs;
using backend.Repositories.EdituraRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Services.EdituraService
{
    public class EdituraService : IEdituraService
    {
        private readonly IEdituraRepository _edituraRepository;
        private readonly IMapper _mapper;

        public EdituraService(IEdituraRepository edituraRepository, IMapper mapper)
        {
            _edituraRepository = edituraRepository ?? throw new ArgumentNullException(nameof(edituraRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task CreateEditura(EdituraDTO editura)
        {
            var edituraEntity = _mapper.Map<Editura>(editura);
            await _edituraRepository.CreateAsync(edituraEntity);
            await _edituraRepository.SaveAsync();
        }

        public async Task<List<Editura>> GetAll()
        {
            return await _edituraRepository.GetAllAsync();
        }
    }
}

