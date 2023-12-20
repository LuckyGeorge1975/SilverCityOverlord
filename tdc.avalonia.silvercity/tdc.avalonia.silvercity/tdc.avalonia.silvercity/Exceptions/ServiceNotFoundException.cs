using System;
using System.Security.Authentication.ExtendedProtection;
using Avalonia.Metadata;

namespace tdc.avalonia.silvercity.Exceptions;

public class ServiceNotFoundException(string service) : Exception()
{
    public string Service { get; private set; } = service;
}