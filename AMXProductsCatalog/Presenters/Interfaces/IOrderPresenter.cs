﻿namespace AMXProductsCatalog.Presenters.Interfaces
{
    using AMXProductsCatalog.Views.Orders.CreateOrder.Request;
    using AMXProductsCatalog.Views.Orders.CreateOrder.Response;

    public interface IOrderPresenter
    {
        Task<CreateOrderResponseDTO> CreateOrder(CreateOrderRequestDTO[] createOrderDto);
    }
}
