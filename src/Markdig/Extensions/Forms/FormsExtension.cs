// Copyright (c) Igor Olenitsj & Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.

using Markdig.Renderers;

namespace Markdig.Extensions.Forms
{
    /// <summary>
    /// An extension that enables forms, including but not limited to:
    /// text fields, radio buttons, check boxes, drop downs and required fields.
    /// </summary>
    public class FormsExtension : IMarkdownExtension
    {
        public FormsExtension()
        {
           //
        }

        public void Setup(MarkdownPipelineBuilder pipeline)
        {
            if (!pipeline.InlineParsers.Contains<FormsInlineParser>())
            {
                var inlineParsers = pipeline.InlineParsers;
                inlineParsers.Insert(inlineParsers.Count, new FormsInlineParser());
            }
        }

        public void Setup(MarkdownPipeline pipeline, IMarkdownRenderer renderer)
        {
            throw new System.NotImplementedException();
        }
    }

}
