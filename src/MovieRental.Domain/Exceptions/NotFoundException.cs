﻿
namespace MovieRental.Domain.Exceptions
{
    public sealed class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
