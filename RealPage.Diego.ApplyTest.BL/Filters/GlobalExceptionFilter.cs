namespace RealPage.Diego.ApplyTest.BL.Filters
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using RealPage.Diego.ApplyTest.BL.Exceptions;
    using RealPage.Diego.ApplyTest.Core.DTOs.Responses;
    using System.Net;

    /// <summary>
    /// Global Exception Filter
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Filters.IExceptionFilter" />
    public class GlobalExceptionFilter : IExceptionFilter
    {
        /// <summary>
        /// Called after an action has thrown an <see cref="T:System.Exception" />.
        /// </summary>
        /// <param name="context">The <see cref="T:Microsoft.AspNetCore.Mvc.Filters.ExceptionContext" />.</param>
        public void OnException(ExceptionContext context)
        {
            if (context.Exception.GetType() == typeof(BLException))
            {
                var exception = (BLException)context.Exception;
                var response = new GenericResponseDTO<string>()
                {
                    IsSuccess = false,
                    Message = exception.Message,
                    ObjResult = exception?.InnerException?.Message
                };

                context.Result = new BadRequestObjectResult(response);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.ExceptionHandled = true;
            }
            else
            {
                var exception = context.Exception;
                var response = new GenericResponseDTO<string>()
                {
                    IsSuccess = false,
                    Message = exception.Message,
                    ObjResult = exception?.InnerException?.Message
                };

                context.Result = new BadRequestObjectResult(response);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.ExceptionHandled = true;
            }
        }
    }
}
