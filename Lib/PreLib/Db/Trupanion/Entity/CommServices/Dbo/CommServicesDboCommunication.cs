using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Trupanion.Entity.CommServices.Dbo
{
    public  class CommServicesDboCommunication
    {
        public CommServicesDboCommunication()
        {
            CommunicationCampaignEntities = new HashSet<CommServicesDboCommunicationCampaignEntity>();
        }

        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? CreatedOnBehalfOf { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public Guid? ModifiedOnBehalfOf { get; set; }
        public DateTime ScheduledDateTime { get; set; }
        public int CommunicationStatusId { get; set; }
        public int DeliveryInfoId { get; set; }
        public Guid RecipientId { get; set; }
        public Guid? CampaignId { get; set; }

        public virtual CommServicesDboCommunicationStatus CommunicationStatus { get; set; }
        public virtual CommServicesDboDeliveryInfo DeliveryInfo { get; set; }
        public virtual ICollection<CommServicesDboCommunicationCampaignEntity> CommunicationCampaignEntities { get; set; }
    }
}
