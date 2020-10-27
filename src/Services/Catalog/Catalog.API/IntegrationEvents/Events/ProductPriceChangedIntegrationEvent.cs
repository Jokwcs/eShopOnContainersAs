﻿namespace Microsoft.eShopOnContainers.Services.Catalog.API.IntegrationEvents.Events
{
    using BuildingBlocks.EventBus.Events;

    // Integration Events notes: 
    // An Event is “something that has happened in the past”, therefore its name has to be   
    // An Integration Event is an event that can cause side effects to other microsrvices, Bounded-Contexts or external systems.
    /// <summary>
    /// 产品价格变更整合事件
    /// </summary>
    public class ProductPriceChangedIntegrationEvent : IntegrationEvent
    {        
        public int ProductId { get; private set; }

        public decimal NewPrice { get; private set; }

        public decimal OldPrice { get; private set; }

        public ProductPriceChangedIntegrationEvent(int productId, decimal newPrice, decimal oldPrice)
        {
            ProductId = productId;
            NewPrice = newPrice;
            OldPrice = oldPrice;
        }
    }
}