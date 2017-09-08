using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSorter
{
    public class WebPieces
    {
        public const string CUCSS = @"
<style type=""text/css"">
.indent-left {
            padding-left: 10%;
        }

ul {
    list-style: none outside none;
    margin: 0 0 15px;
    padding: 0;
}
ul li {
    padding: 0 0 0 17px;
    margin: 0 30px 5px 15px;
    background: url('http://www.nafcu.org/images/blue-bullet.png') no-repeat 0 6px;
}

        .larger {
            font-size: 1.4em;
        }

        .width-100 {
            width: 100%;
        }

        .bold {
            font-weight: bold;
        }

        .break {
            margin-bottom: 5px;
        }

h2.underline {
margin-bottom:2px;
background-color: #003768;
color: #ffffff;
margin-top:20px;
padding:5px;
}
            
.break.major {
margin-top: 0; 
padding-top: 0;               
                height: 2px;
width:100%;
            }

            .break.minor {
                background-color: #cccccc;
                height: 1px;
            }

        .italics {
            font-style: italic;
        }

        .span-block {
            display: inline-block;
            font-weight: bold;
            font-size: 1.1em;
        }

            .span-block.indent {
                margin-left: 20px;
            }

    </style>
";
        public const string MOCCSS = @"
<style type=""text/css"">

.indent-left {
            padding-left: 10%;
        }
ul {
    list-style: none outside none;
    margin: 0 0 15px;
    padding: 0;
}
ul li {
    padding: 0 0 0 17px;
    margin: 0 30px 5px 15px;
    background: url('http://www.nafcu.org/images/blue-bullet.png') no-repeat 0 6px;
}

        .larger {
            font-size: 1.4em;
        }

        .width-100 {
            width: 100%;
        }

        .bold {
            font-weight: bold;
        }

        .break {
            margin-bottom: 5px;
        }

h2.underline {
margin-bottom:2px;
background-color: #003768;
color: #ffffff;
margin-top:20px;
padding:5px;
}
            
.break.major {
margin-top: 0; 
padding-top: 0;               
                height: 2px;
width:100%;
            }

            .break.minor {
                background-color: #cccccc;
                height: 1px;
            }

        .italics {
            font-style: italic;
        }

        .span-block {
            display: inline-block;
            font-weight: bold;
            font-size: 1.1em;
        }

            .span-block.indent {
                margin-left: 20px;
            }

    
</style>


";


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





        public const string End = @"</body>
</html>";
        public const string Start = @"<!DOCTYPE html>
<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"">
<head>
    <meta charset=""utf-8"" />
    <title>Meeting Schedule</title>
<link type=""text/css"" rel=""stylesheet"" href=""content.css"" />
</head>
<body>";

                public const string StartWithNAFCUCSS = @"<!DOCTYPE html>
<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"">
<head>
    <meta charset=""utf-8"" />
    <title>Meeting Schedule</title>
<link href=""http://www.nafcu.org/css/styles.css"" rel=""stylesheet"" type=""text/css"">
<link href=""http://www.nafcu.org/css/medium.css"" rel=""stylesheet"" type=""text/css"">
<link href=""http://www.nafcu.org/css/small.css"" rel=""stylesheet"" type=""text/css"">
</head>
<body>";

        public static string CSS
        {
            get
            {
                return _CSS;
            }
        }
        private static string _CSS = @"    <style type=""text/css"">
        body {
            font-family: ""Arial"";
        }

        .indent-left {
            padding-left: 50px;
            float: left;
            width: 100%;
        }

.div-indent-100{
margin-left:100px;
width:100%;
margin-bottom:30px;
}

.div-indent-60{
margin-left:60px;
width:100%;
}
.margin-top-15{
margin-top:15px;
}

.div-indent-70{
margin-left:70px;
width:100%;
}
.width-40{
width:40%;
}
.width-30{
width:30%;
}
.width-20{
width:20%;
}

.margin-left-20{
margin-left:20px;
}
        li, ul {
            padding-top: 3px;
        }

        .larger {
            font-size: 1.8em;
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

.font-larger{
font-size: 1.4em;
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
 .break.major.width-100 {
                background-color: blue;
                height: 3px;
width: 100%;
margin-top:35px;
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
            
            font-size: 1.1em;
        }
.bold{
font-weight: bold;
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
