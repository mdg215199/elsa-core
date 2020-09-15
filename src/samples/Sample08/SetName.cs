using Elsa;
using Elsa.Attributes;
using Elsa.Expressions;
using Elsa.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample08
{
    [ActivityDefinition(Category = "Users", Description = "Activate a User", Icon = "fas fa-user-check", Outcomes = new[] { OutcomeNames.Done, "Not Found" })]
    public class SetName : Activity
    {
        [ActivityProperty(Hint = "Enter an expression that evaluates to the ID of the user to activate.")]
        public WorkflowExpression<string> Name
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }
    }
}
