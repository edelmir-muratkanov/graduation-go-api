﻿namespace Api.Features.Property;

public static class PropertyErrorCodes
{
    public static class Create
    {
        public const string MissingName = nameof(MissingName);
        public const string LongName = nameof(LongName);

        public const string MissingUnit = nameof(MissingUnit);
        public const string LongUnit = nameof(LongUnit);
    }

    public static class GetById
    {
        public const string MissingId = nameof(MissingId);
        public const string InvalidId = nameof(InvalidId);
    }
}