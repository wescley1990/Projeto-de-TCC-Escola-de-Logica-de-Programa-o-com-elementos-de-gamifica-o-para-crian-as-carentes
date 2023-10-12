﻿using NetDevPack.Domain;

namespace TCC.Domain.Models
{
    public class PedidoLoja : Entity, IAggregateRoot
    {
        public PedidoLoja()
        {

        }

        public Usuario Usuario { get; set; }
        public DateTime Timestamp { get; set; }
        public ItemLoja ItemComprado { get; set; }

        public bool IsExpired()
        {
            var duration = TimeSpan.FromTicks(ItemComprado.Duracao);
            var validade = Timestamp + duration;

            return validade < DateTime.Now;
        }
    }
}
