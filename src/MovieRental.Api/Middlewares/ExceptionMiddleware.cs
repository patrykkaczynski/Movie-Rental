using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Domain.Entities;
using MovieRental.Domain.Exceptions;
using System.Net;
using System.Text.Json;

namespace MovieRental.Api.Middlewares
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception);
            }
        }

        private async static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var exceptionType = exception.GetType();

            ValidationProblemDetails problemDetails;


            if (exceptionType == typeof(NotFoundException))
            {
                problemDetails = new ValidationProblemDetails(new Dictionary<string, string[]> { { "Error", new[] { exception.Message } } })
                {
                    Type = "https://tools.ietf.org/html/rfc7231#section-6.5.4",
                    Title = "Not Found",
                    Status = (int)HttpStatusCode.NotFound,
                    Instance = context.Request.Path
                };

                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
            else if(exceptionType == typeof(BadRequestException))
            {
                problemDetails = new ValidationProblemDetails(new Dictionary<string, string[]> { { "Error", new[] { exception.Message } } })
                {
                    Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                    Title = "Bad Request",
                    Status = (int)HttpStatusCode.BadRequest,
                    Instance = context.Request.Path
                };

                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else
            {
                problemDetails = new ValidationProblemDetails(new Dictionary<string, string[]> { { "Error", new[] { exception.Message } } })
                {
                    Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1",
                    Title = "Internal Server Error",
                    Status = (int)HttpStatusCode.InternalServerError,
                    Instance = context.Request.Path
                };

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = problemDetails.Status.Value;
            await JsonSerializer.SerializeAsync(context.Response.Body, problemDetails);
        }
    }
}
