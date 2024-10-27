﻿using Application.Common;
using Application.UseCase.IUseCase;
using Domain.Domain.Interfaces.IRepositorySqlServer;
using Domain.Entities;
using Microsoft.Extensions.Logging;

namespace Application.UseCase
{
    public class GetAll : IGetAll
    {
        private readonly IRepository _productRepository;
        private readonly ILogger<GetAll> _logger;

        public GetAll(IRepository productRepository, ILogger<GetAll> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public async Task<Result<IEnumerable<Product>>> GetAllAsync()
        {
            _logger.LogInformation("Start GetAllAsync");

            try
            {
                var products = await _productRepository.GetAll();
                return Result<IEnumerable<Product>>.CreateSuccess(products, "Productos encontrados.");
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<Product>>.CreateError($"Error al obtener los productos: {ex.Message}");
            }
        }
    }
}
