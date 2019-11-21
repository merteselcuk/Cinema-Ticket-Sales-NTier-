using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core
{
    public static class ServiceResultHelper
    {
        public static ServiceResult ServiceResultControl<TEntity>(TEntity processResult, string SuccessMessage, string WarningMessage, string ErrorMessage)
            where TEntity : IEntity
        {
            ServiceResult result;
            try
            {
                if (processResult != null)
                {
                    result = new ServiceResult(SuccessMessage, ResultState.Success);
                }
                else
                {
                    result = new ServiceResult(WarningMessage, ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                result = new ServiceResult(ErrorMessage, ResultState.Error);
            }

            return result;
        }
    }
}
