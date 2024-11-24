using Database.BaseClasses.Interfaces;
using Database.BaseClasses;
using Utilities.Logging;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.Workflow;
using Utilities.ReturnType;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;
using Database.Trupanion.Entity.VisionMigration.Dbo;
using Utilities.ArgumentEvaluation;
using Database.Trupanion.Crud.Interfaces;
using System;
using Microsoft.EntityFrameworkCore;

namespace Database.Trupanion.Crud.Workflow.Dbo;

public class WorkflowDboCrud : QaLibCrud, IQaLibCrud, IWorkflowDboCrud
{
    public WorkflowDboCrud(ILogManager logMgr) : base(logMgr)
    {

    }

    public async Task<ReturnValue<WFDboProcessDefinition>>RetrieveProcessDefinitionById(int Id, WorkflowDboContext? context = null)
    {
        EvaluateArgument.Execute(Id, fn => 0 < Id, "Process Id must be a positive non-zero integer");

        try
        {
            var ctx = this.EnsureContext(context);
            var processDefinition = await this.RetrieveByIdAsync<WFDboProcessDefinition, int, WorkflowDboContext>(Id, ctx);
            EvaluateArgument.Execute(processDefinition, fn => null != processDefinition, $"Unable to locate Process Definition for Id {Id}");
            EvaluateArgument.Execute(processDefinition, fn => processDefinition.IsValid, processDefinition.ErrorText);

            return this.GenerateReturnValue(processDefinition, $"Unable to find Process for Id {Id}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<WFDboProcessDefinition>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<WFDboProcessDefinition>.FromError(ex);
        }
    }

    public async Task<ReturnValue<WFDboProcessDefinition>> RetrieveFullProcessDefinitionById(int Id, WorkflowDboContext? context = null)
    {
        try
        {
            EvaluateArgument.Execute(Id, fn => 0 < Id, "Process Id must be a positive non-zero integer");

            Expression<Func<WFDboProcessDefinition, bool>> predicate = procDef => procDef.Id == Id;
            var ctx = this.EnsureContext(context);
            var processDefinition = await this.RetrieveByIdAsync<WFDboProcessDefinition, int, WorkflowDboContext>(Id, ctx);
            EvaluateArgument.Execute(processDefinition, fn => null != processDefinition, $"Unable to locate Process Definition for Id {Id}");
            EvaluateArgument.Execute(processDefinition, fn => processDefinition.IsValid, processDefinition.ErrorText);

            _ = await ctx.StateTransitionResolutionGroups.FirstOrDefaultAsync(rg => rg.Id == processDefinition!.Result!.StandardStateTransitionResolutionGroupId);
            _ = await ctx.ProcessDefinitionConfigurations.Where(dc => dc.ProcessDefinitionId == Id).ToListAsync();
            _ = await ctx.ProcessDefinitionFlows.Where(df => df.ProcessDefinitionId == Id).ToListAsync();
            _ = await ctx.ProcessInstances.Where(pi => pi.ProcessDefinitionId == Id).ToListAsync();


            return this.GenerateReturnValue(processDefinition, $"Unable to find Process for Id {Id}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<WFDboProcessDefinition>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<WFDboProcessDefinition>.FromError(ex);
        }
    }
}
