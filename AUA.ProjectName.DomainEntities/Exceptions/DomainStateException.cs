﻿namespace AUA.ProjectName.DomainEntities.Exceptions
{
    public abstract  class DomainStateException : Exception
    {
        public string[] Parameters { get; set; }

        public DomainStateException(string message, params string[] parameters) : base(message)
        {
            Parameters = parameters;
        }

    }
}
