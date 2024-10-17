using System;
using UiPath.CodedWorkflows;

namespace AuxisReFramework
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        private Lazy<AuxisReFramework.WorkflowRunnerService> _workflowRunnerServiceLazy;
        private Lazy<ConnectionsManager> _connectionsManagerLazy;
        public CodedWorkflow()
        {
            _ = new System.Type[]{};
            _workflowRunnerServiceLazy = new Lazy<AuxisReFramework.WorkflowRunnerService>(() => new AuxisReFramework.WorkflowRunnerService(this.services));
#pragma warning disable
            _connectionsManagerLazy = new Lazy<ConnectionsManager>(() => new ConnectionsManager(serviceContainer));
#pragma warning restore
        }

        protected AuxisReFramework.WorkflowRunnerService workflows => _workflowRunnerServiceLazy.Value;
        protected ConnectionsManager connections => _connectionsManagerLazy.Value;
    }
}