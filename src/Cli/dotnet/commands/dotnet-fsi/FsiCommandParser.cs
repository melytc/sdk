// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.Parsing;
using Microsoft.DotNet.Tools.Fsi;

namespace Microsoft.DotNet.Cli
{
    internal static class FsiCommandParser
    {
        public static readonly string DocsLink = "https://aka.ms/dotnet-fsi";

        public static Command GetCommand()
        {
            var command = new DocumentedCommand("fsi", DocsLink);

            command.Handler = CommandHandler.Create<ParseResult>(FsiCommand.Run);

            return command;
        }
    }
}
