using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSorter
{
    public class WebPieces
    {
        public const string CongressBlock = @"<div class=""indent-left"">
        <div class=""width-100"">
            <span class=""span-block italics larger"">[CongressName]</span>
            <span class=""span-block indent"">[MeetingDay], [MeetingDate]</span>
            <span class=""span-block indent"">[MeetingTime]</span>
            <span class=""span-block indent"">[Location]</span>
        </div>
        <ul>
[FCUBlock]
        </ul>
        <div class=""break minor""></div>
    </div>";

        public const string StateBlock = @"    <h2 class=""underline"">[StateName]</h2>
    <div class=""break major""></div>
[CongressBlock]";
        public const string FCUBlock = @"<li class=""bold"">[FCUName]</li>";


        public const string End = @"</body>
</html>";
        public const string Start = @"<!DOCTYPE html>
<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"">
<head>
    <meta charset=""utf-8"" />
    <title>Meeting Schedule</title>
</head>
<body>";
        public const string CSS = @"    <style type=""text/css"">
        body {
            font-family: ""Arial"";
        }

        .indent-left {
            padding-left: 50px;
            float: left;
            width: 100%;
        }

        li, ul {
            padding-top: 3px;
        }

        .larger {
            font-size: 1.4em;
        }

        .width-100 {
            width: 100%;
        }

        div {
            float: left;
        }

        .left {
            float: left;
        }

        ul li ul li {
            font-weight: normal;
        }

        .bold {
            font-weight: bolder;
        }

        .break {
            float: left;
            width: 90%;
            margin-bottom: 5px;
        }

            .break.major {
                background-color: blue;
                height: 3px;
            }

            .break.minor {
                background-color: gray;
                height: 2px;
            }

        .italics {
            font-style: italic;
        }

        .underline {
            text-decoration: underline;
        }

        .span-block {
            display: inline-block;
            font-weight: bold;
            font-size: 1.1em;
        }

            .span-block.indent {
                margin-left: 20px;
            }

        ul {
            margin-left: 100px;
        }
    </style>";
    }
}
