using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Contracts
{
    /// <summary>
    /// Abstract class for all command handlers
    /// </summary>
    internal abstract class CommandHandlerBase<TRequest,TResult> : IHandler where TRequest : Command where TResult : CommandResult
    {
        /// <summary>
        /// method that execute the command
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        protected abstract TResult ExecuteCommand(TRequest command);


        public CommandResult Execute(Command command)
        {
            return ExecuteCommand((TRequest)command);
        }
    }

    /// <summary>
    /// interface for all type of Handlers
    /// </summary>
    internal interface IHandler
    {
           CommandResult Execute(Command command);
    }
}
