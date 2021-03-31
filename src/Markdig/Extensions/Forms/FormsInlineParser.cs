// Copyright (c) Igor Olenitsj & Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.

using Markdig.Helpers;
using Markdig.Parsers;

namespace Markdig.Extensions.Forms
{
    internal class FormsInlineParser : InlineParser
    {
        public FormsInlineParser()
        {
            //
        }

        public override bool Match(InlineProcessor processor, ref StringSlice slice)
        {
            throw new System.NotImplementedException();
        }
    }
}