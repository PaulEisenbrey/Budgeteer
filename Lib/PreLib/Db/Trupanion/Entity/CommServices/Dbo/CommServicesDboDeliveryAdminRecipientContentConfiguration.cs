using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Trupanion.Entity.CommServices.Dbo
{
    public  class CommServicesDboDeliveryAdminRecipientContentConfiguration
    {
        public int Id { get; set; }
        public int TemplateDefinitionId { get; set; }
        public int DeliveryAddressId { get; set; }
        public bool SendToCc { get; set; }

        public virtual CommServicesDboDeliveryAddress DeliveryAddress { get; set; }
    }
}
