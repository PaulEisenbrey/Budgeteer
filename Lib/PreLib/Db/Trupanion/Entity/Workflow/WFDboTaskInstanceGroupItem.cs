﻿namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceGroupItem
{
    public WFDboTaskInstanceGroupItem()
    {
        TaskInstanceBatchItems = new HashSet<WFDboTaskInstanceBatchItem>();
    }

    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int TaskInstanceGroupId { get; set; }
    public int TaskInstanceId { get; set; }

    public virtual WFDboTaskInstance? TaskInstance { get; set; }
    public virtual ICollection<WFDboTaskInstanceBatchItem> TaskInstanceBatchItems { get; set; }
}
