// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.Parsing;
using Microsoft.DotNet.Cli;
using LocalizableStrings = Microsoft.DotNet.Tools.Build.LocalizableStrings;

namespace Microsoft.DotNet.Tools.MSBuild
{
    internal static class MSBuildCommandParser
    {
        public static readonly string DocsLink = "https://aka.ms/dotnet-msbuild";

        public static Command GetCommand()
        {
            var command = new DocumentedCommand("msbuild", DocsLink, LocalizableStrings.AppFullName);

            command.Handler = CommandHandler.Create<ParseResult>(MSBuildCommand.Run);

            return command;
        }
    }
}
