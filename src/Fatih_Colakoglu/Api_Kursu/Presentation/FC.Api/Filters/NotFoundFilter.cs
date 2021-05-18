using FC.Core.Services;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Threading.Tasks;
using FC.Api.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FC.Api.Filters
{
    public class NotFoundFilter : ActionFilterAttribute
    {
        private readonly IProductService _productService;

        public NotFoundFilter(IProductService productService)
        {
            _productService = productService;
        }
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {

            var id = (int)context.ActionArguments.Values.FirstOrDefault();
            var product = _productService.GetByIdAsync(id);

            if (product != null)
                await next();
            else
            {
                ErrorDto errorDto = new ErrorDto();
                errorDto.Status = 404;
                errorDto.Errors.Add($"{id} not found");
                context.Result = new NotFoundObjectResult(errorDto);
            }
        }
    }
}
