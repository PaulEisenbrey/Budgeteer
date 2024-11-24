using Database.Trupanion.Context;
using Database.Trupanion.Entity.Workflow;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface IWorkflowDboCrud
{
    Task<ReturnValue<WFDboProcessDefinition>> RetrieveFullProcessDefinitionById(int Id, WorkflowDboContext? context = null);
    Task<ReturnValue<WFDboProcessDefinition>> RetrieveProcessDefinitionById(int Id, WorkflowDboContext? context = null);
}