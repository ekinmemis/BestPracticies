using FC.Api.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace FC.Api.Filters
{
    public class ValidationFilter : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                ErrorDto errorDto = new ErrorDto();
                errorDto.Status = 400;

                IEnumerable<ModelError> modelErrors = context.ModelState.Values.SelectMany(f => f.Errors);
                modelErrors.ToList().ForEach(f =>
                {
                    errorDto.Errors.Add(f.ErrorMessage);
                });

                context.Result = new BadRequestObjectResult(errorDto);
            }
        }


    }
}
