﻿namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboWaitingPeriod
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid? ApprovalId { get; set; }
    public Guid? TemplateId { get; set; }
    public string? Name { get; set; }
    public Guid DurationTypeId { get; set; }
    public int Duration { get; set; }
    public Guid CoverageId { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboCoverage? Coverage { get; set; }
    public virtual ProductDboWaitingPeriod? Template { get; set; }
    public virtual List<ProductDboCoverageWaitingPeriod> CoverageWaitingPeriods { get; set; } = new();
    public virtual List<ProductDboWaitingPeriod> InverseTemplate { get; set; } = new();
}
