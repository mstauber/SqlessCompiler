﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sqless.Compiler.Lexer;

namespace Sqless.Compiler.PreProcessors
{
interface IPreProcessor
{
	string PreProcess(string source);
}
}
