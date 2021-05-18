using FC.Api.DTOs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FC.Api.Extension
{
    public static class UseCustomExceptionHandler
    {
        public static void UseCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(opt =>
            {
                opt.Run(async opt =>
                {
                    opt.Response.StatusCode = 500;
                    opt.Response.ContentType = "application/json";
                    var error = opt.Features.Get<IExceptionHandlerFeature>();
                    if (error.Error != null)
                    {
                        var exception = error.Error;
                        ErrorDto errorDto = new();
                        errorDto.Status = 500;
                        errorDto.Errors.Add(exception.Message);

                        await opt.Response.WriteAsync(JsonConvert.SerializeObject(errorDto));
                    }
                });
            });
        }
    }
}
