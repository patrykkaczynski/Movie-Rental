﻿namespace MovieRental.Application.Features.Accounts.Commands.RegisterUser.ValidatorHelpers;

internal static class PasswordHelper
{
    static readonly string specialCharacters = @"!@#$%^&*()-_=+\|[]{};:/?.><";
    public static bool HasNumber(string password) => password.Any(x => x >= '0' && x <= '9');
    public static bool HasCapitalLetter(string password) => password.Any(x => x >= 'A' && x <= 'Z');
    public static bool HasSmallLetter(string password) => password.Any(x => x >= 'a' && x <= 'z');
    public static bool HasSpecialCharacters(string password) => password.Any(x => specialCharacters.Contains(x));
}
