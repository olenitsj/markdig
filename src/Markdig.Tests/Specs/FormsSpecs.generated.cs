
// --------------------------------
//               Forms
// --------------------------------

using System;
using NUnit.Framework;

namespace Markdig.Tests.Specs.Forms
{
    [TestFixture]
    public class TestExtensionsForms
    {
        // # Extensions
        // 
        // This section describes the different extensions supported:
        // 
        // ## Forms
        // 
        // Radio buttons:
        [Test]
        public void ExtensionsForms_Example001()
        {
            // Example 1
            // Section: Extensions / Forms
            //
            // The following Markdown:
            //     sex = (x) male () female
            //
            // Should be rendered as:
            //     <label>Sex:</label> 
            //     <input type="radio" name="sex" id="male" value="male" checked="checked"/><label for="male">Male</label>
            //     <input type="radio" name="sex" id="female" value="female"/><label for="female">Female</label>  

            Console.WriteLine("Example 1\nSection Extensions / Forms\n");
            TestParser.TestSpec("sex = (x) male () female", "<label>Sex:</label> \n<input type=\"radio\" name=\"sex\" id=\"male\" value=\"male\" checked=\"checked\"/><label for=\"male\">Male</label>\n<input type=\"radio\" name=\"sex\" id=\"female\" value=\"female\"/><label for=\"female\">Female</label>  ", "forms|advanced");
        }

        // Check boxes:
        [Test]
        public void ExtensionsForms_Example002()
        {
            // Example 2
            // Section: Extensions / Forms
            //
            // The following Markdown:
            //     phones = [] Android [x] iPhone [x] Blackberry
            //
            // Should be rendered as:
            //     <label>Phones:</label> 
            //     <input type="checkbox" name="phones" id="Android" value="Android"/><label for="Android">Android</label>
            //     <input type="checkbox" name="phones" id="iPhone" value="iPhone" checked="checked"/><label for="iPhone">iPhone</label>
            //     <input type="checkbox" name="phones" id="Blackberry" value="Blackberry" checked="checked"/><label for="Blackberry">Blackberry</label>

            Console.WriteLine("Example 2\nSection Extensions / Forms\n");
            TestParser.TestSpec("phones = [] Android [x] iPhone [x] Blackberry", "<label>Phones:</label> \n<input type=\"checkbox\" name=\"phones\" id=\"Android\" value=\"Android\"/><label for=\"Android\">Android</label>\n<input type=\"checkbox\" name=\"phones\" id=\"iPhone\" value=\"iPhone\" checked=\"checked\"/><label for=\"iPhone\">iPhone</label>\n<input type=\"checkbox\" name=\"phones\" id=\"Blackberry\" value=\"Blackberry\" checked=\"checked\"/><label for=\"Blackberry\">Blackberry</label>", "forms|advanced");
        }

        // Drop down:
        [Test]
        public void ExtensionsForms_Example003()
        {
            // Example 3
            // Section: Extensions / Forms
            //
            // The following Markdown:
            //     city = {BOS, SFO, (NYC)}
            //
            // Should be rendered as:
            //     <label for="city">City:</label>
            //     <select id="city" name="city">
            //       <option value="BOS">BOS</option>
            //       <option value="SFO">SFO</option>
            //       <option value="NYC" selected="selected">NYC</option>
            //     </select>

            Console.WriteLine("Example 3\nSection Extensions / Forms\n");
            TestParser.TestSpec("city = {BOS, SFO, (NYC)}", "<label for=\"city\">City:</label>\n<select id=\"city\" name=\"city\">\n  <option value=\"BOS\">BOS</option>\n  <option value=\"SFO\">SFO</option>\n  <option value=\"NYC\" selected=\"selected\">NYC</option>\n</select>", "forms|advanced");
        }

        // Required fields:
        [Test]
        public void ExtensionsForms_Example004()
        {
            // Example 4
            // Section: Extensions / Forms
            //
            // The following Markdown:
            //     zip code* = ________
            //
            // Should be rendered as:
            //     <label for="zip-code" class="required-label">Zip code*:</label>
            //     <input type="text" name="zip-code" id="zip-code" class="required-input"/>

            Console.WriteLine("Example 4\nSection Extensions / Forms\n");
            TestParser.TestSpec("zip code* = ________", "<label for=\"zip-code\" class=\"required-label\">Zip code*:</label>\n<input type=\"text\" name=\"zip-code\" id=\"zip-code\" class=\"required-input\"/>", "forms|advanced");
        }
    }
}
